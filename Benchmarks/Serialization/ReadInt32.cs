using System.Buffers.Binary;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Serialization;

public class ReadInt32
{
    private readonly byte[] buffer = new byte[sizeof(int)];

    public ReadInt32()
    {
        new Random(42).NextBytes(buffer);
    }

    [Benchmark]
    public int BinaryPrimitives_ReadInt32LittleEndian()
    {
        return BinaryPrimitives.ReadInt32LittleEndian(buffer);
    }

    [Benchmark]
    public int Unsafe_ReadUnaligned_Ref_Buffer_Index_Zero()
    {
        return Unsafe.ReadUnaligned<int>(ref buffer[0]);
    }

    [Benchmark]
    public int Unsafe_ReadUnaligned_MemoryMarshal_GetReference()
    {
        ref var start = ref MemoryMarshal.GetReference(buffer.AsSpan());

        return Unsafe.ReadUnaligned<int>(ref start);
    }
}