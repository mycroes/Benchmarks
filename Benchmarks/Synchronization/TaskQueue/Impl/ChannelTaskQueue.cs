using System.Threading.Channels;

namespace Benchmarks.Synchronization.TaskQueue.Impl;

internal sealed class ChannelTaskQueue
{
    private readonly Channel<int> channel =
        Channel.CreateUnbounded<int>(new UnboundedChannelOptions { SingleWriter = true });

    private readonly ChannelReader<int> reader;
    private readonly ChannelWriter<int> writer;

    public ChannelTaskQueue()
    {
        reader = channel.Reader;
        writer = channel.Writer;
        writer.TryWrite(1);
    }

    public async Task Execute(Func<Task> func)
    {
        await reader.ReadAsync();
        try
        {
            await func.Invoke();
        }
        finally
        {
            writer.TryWrite(1);
        }
    }
}