namespace Benchmarks.Synchronization.TaskQueue.Impl;

internal sealed class InterLockedExchangeAwaitTaskQueue
{
    private Task queue = Task.CompletedTask;

    public async Task Execute(Func<Task> func)
    {
        var tcs = new TaskCompletionSource<Task>();
        var completion = tcs.Task.Unwrap();

        try
        {
            await Interlocked.Exchange(ref queue, completion);
        }
        catch
        {
            // completion is awaited below, no need to throw the exception from previous completion here.
        }

        try
        {
            tcs.SetResult(func.Invoke());
        }
        catch (Exception e)
        {
            tcs.SetException(e);
        }


        await completion;
    }
}