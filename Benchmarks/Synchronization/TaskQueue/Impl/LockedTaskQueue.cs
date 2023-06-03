namespace Benchmarks.Synchronization.TaskQueue.Impl;

internal sealed class LockedTaskQueue
{
    private Task queue = Task.CompletedTask;
    private readonly object exclusiveTaskLock = new();

    public Task Execute(Func<Task> func)
    {
        lock (exclusiveTaskLock)
            return queue = queue.ContinueWith(t => func()).Unwrap();
    }
}