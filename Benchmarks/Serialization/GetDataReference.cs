using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Serialization
{
    public class GetDataReference
    {
        private readonly ulong[] data = new ulong[8];

        [Benchmark(Baseline = true)]
        public ref byte MemoryMarshal_Cast_MemoryMarshal_GetReference()
        {
            var bytes = MemoryMarshal.Cast<ulong, byte>(data);
            return ref MemoryMarshal.GetReference(bytes);
        }

        [Benchmark]
        public ref byte Unsafe_As_Ref_Index_0()
        {
            var bytes = Unsafe.As<byte[]>(data)!;
            return ref bytes[0];
        }

        [Benchmark]
        public ref byte Unsafe_As_MemoryMarshal_GetReference()
        {
            var bytes = Unsafe.As<byte[]>(data);
            return ref MemoryMarshal.GetReference(bytes.AsSpan());
        }

        #if NET7_0_OR_GREATER
        [Benchmark]
        public ref byte Unsafe_As_MemoryMarshal_GetArrayDataReference()
        {
            var bytes = Unsafe.As<byte[]>(data);
            return ref MemoryMarshal.GetArrayDataReference(bytes);
        }
        #endif
    }
}
