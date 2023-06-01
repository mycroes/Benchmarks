namespace Benchmarks.Synchronization.TaskQueue.Impl;

internal sealed class InterLockedExchangeTaskQueue
{
    private Task queue = Task.CompletedTask;

    public Task Execute(Func<Task> func)
    {
        var tcs = new TaskCompletionSource<Task>();
        var completion = tcs.Task.Unwrap();

        Interlocked.Exchange(ref queue, completion).ContinueWith(_ => tcs.SetResult(func.Invoke()));

        return completion;
    }
}