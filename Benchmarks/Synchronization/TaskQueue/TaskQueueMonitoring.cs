using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using Benchmarks.Synchronization.TaskQueue.Impl;

namespace Benchmarks.Synchronization.TaskQueue;

[SimpleJob(RunStrategy.Monitoring, iterationCount: 10, id: "TaskQueueMonitoring")]
public class TaskQueueMonitoring
{
    private const int LoopCount = 10000;
    private const int NumberOfThreads = 8;

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
        var mre = new ManualResetEvent(false);
        var tasks = Enumerable.Range(0, NumberOfThreads).Select(i => Task.Factory.StartNew(async () =>
        {
            mre.WaitOne();

            for (var j = 0; j < LoopCount; j++)
            {
                await impl.Invoke(static async () => await Task.Yield());
            }
        })).Select(t => t.Unwrap());

        mre.Set();

        return Task.WhenAll(tasks);
    }
}