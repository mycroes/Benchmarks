using BenchmarkDotNet.Attributes;
using Benchmarks.Synchronization.TaskQueue.Impl;

namespace Benchmarks.Synchronization.TaskQueue;

public class TaskQueueSingle
{
    private readonly InterLockedExchangeTaskQueue interLockedExchangeTaskQueue = new();
    private readonly InterLockedExchangeAwaitTaskQueue interLockedExchangeAwaitTaskQueue = new();
    private readonly LockedTaskQueue lockedTaskQueue = new();
    private readonly ChannelTaskQueue channelTaskQueue = new();

    [Benchmark] public Task InterLockedExchangeTaskQueue() => Run(interLockedExchangeTaskQueue.Execute);
    [Benchmark] public Task InterLockedExchangeAwaitTaskQueue() => Run(interLockedExchangeAwaitTaskQueue.Execute);
    [Benchmark] public Task LockedTaskQueue() => Run(lockedTaskQueue.Execute);
    [Benchmark] public Task ChannelTaskQueue() => Run(channelTaskQueue.Execute);

    private static Task Run(Func<Func<Task>, Task> impl)
    {
        return impl.Invoke(static async () => await Task.Yield());
    }
}