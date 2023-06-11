using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Serialization
{
    public class UnsafeWriteUnaligned
    {
        private readonly int intValue = 0x01020304;
        private readonly long longValue = 0x0102030405060708;
        private readonly byte[] byteValue = { 4, 3, 2, 1 };
        private readonly byte[] buffer = new byte[4];

        [Benchmark(Baseline = true)]
        public void WriteInt()
        {
            ref var start = ref MemoryMarshal.GetReference(buffer.AsSpan());
            Unsafe.WriteUnaligned(ref start, intValue);
        }

        [Benchmark]
        public void WriteBytes()
        {
            ref var start = ref MemoryMarshal.GetReference(buffer.AsSpan());
            Unsafe.WriteUnaligned(ref start, byteValue[0]);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref start, 1), byteValue[1]);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref start, 2), byteValue[2]);
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref start, 3), byteValue[3]);
        }

        [Benchmark]
        public void WriteIntComposed()
        {
            var value = byteValue[0] | byteValue[1] << 1 | byteValue[2] << 2 | byteValue[3] << 3;
            ref var start = ref MemoryMarshal.GetReference(buffer.AsSpan());
            Unsafe.WriteUnaligned(ref start, value);
        }

        [Benchmark]
        public void WriteLong()
        {
            ref var start = ref MemoryMarshal.GetReference(buffer.AsSpan());
            Unsafe.WriteUnaligned(ref start, longValue);
        }
    }
}
