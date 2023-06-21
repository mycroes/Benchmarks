using System.Threading.Channels;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Locking
{
    public class Lock
    {
        private readonly object mutex = new object();
        private object? exchange = null;

        private readonly Channel<int> channel =
            Channel.CreateUnbounded<int>(new UnboundedChannelOptions { SingleWriter = true });

        private readonly ChannelReader<int> reader;
        private readonly ChannelWriter<int> writer;

        public Lock()
        {
            reader = channel.Reader;
            writer = channel.Writer;

            writer.TryWrite(1);
        }

        [Benchmark]
        public int LockMutex()
        {
            lock (mutex)
            {
                return 0;
            }
        }

        [Benchmark]
        public int MonitorEnter()
        {
            if (!Monitor.TryEnter(mutex))
            {
                static void Throw()
                {
                    throw new Exception();
                }

                Throw();
            }

            try
            {
                return 0;
            }
            finally
            {
                Monitor.Exit(mutex);
            }
        }

        [Benchmark]
        public int CompareExchange()
        {
            if (Interlocked.CompareExchange(ref exchange, mutex, null) != null)
            {
                static void Throw()
                {
                    throw new Exception();
                }

                Throw();
            }

            try
            {
                return 0;
            }
            finally
            {
                exchange = null;
            }
        }

        [Benchmark]
        public int ChannelRead()
        {
            if (!reader.TryRead(out _))
            {
                static void Throw()
                {
                    throw new Exception();
                }

                Throw();
            }

            try
            {
                return 0;
            }
            finally
            {
                writer.TryWrite(1);
            }
        }
    }
}
