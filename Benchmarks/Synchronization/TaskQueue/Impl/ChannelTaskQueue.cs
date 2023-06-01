using System.Threading.Channels;

namespace Benchmarks.Synchronization.TaskQueue.Impl;

internal sealed class ChannelTaskQueue
{
    private readonly Channel<int> channel =
        Channel.CreateUnbounded<int>(new UnboundedChannelOptions { SingleWriter = true });

    public ChannelTaskQueue()
    {
        channel.Writer.TryWrite(1);
    }

    public async Task Execute(Func<Task> func)
    {
        await channel.Reader.ReadAsync();
        try
        {
            await func.Invoke();
        }
        finally
        {
            channel.Writer.TryWrite(1);
        }
    }
}