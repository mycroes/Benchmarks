using System.Buffers.Binary;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Serialization;

public class WriteInt32
{
    private const int N = 10000;
    private readonly int[] data;
    private readonly byte[] destination = new byte[N * sizeof(int)];

    public WriteInt32()
    {
        data = new int[N];
        var temp = new byte[N * sizeof(int)];
        new Random(42).NextBytes(temp);
        MemoryMarshal.Cast<byte, int>(temp).CopyTo(data);
    }

    [Benchmark]
    public void BinaryPrimitives_WriteInt32LittleEndian()
    {
        var source = data.AsSpan();
        var dest = destination.AsSpan();

        for (var i = 0; i < N; i++)
        {
            BinaryPrimitives.WriteInt32LittleEndian(dest.Slice(i * sizeof(int)), source[i]);
        }
    }

    [Benchmark]
    public void Unsafe_WriteUnaligned()
    {
        var source = data.AsSpan();
        ref var dest = ref MemoryMarshal.GetReference(destination.AsSpan());

        for (var i = 0; i < N; i++)
        {
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref dest, i * sizeof(int)), source[i]);
        }
    }

    [Benchmark]
    public void BinaryPrimitives_WriteInt32BigEndian()
    {
        var source = data.AsSpan();
        var dest = destination.AsSpan();

        for (var i = 0; i < N; i++)
        {
            BinaryPrimitives.WriteInt32BigEndian(dest.Slice(i * sizeof(int)), source[i]);
        }
    }

    [Benchmark]
    public void Unsafe_WriteUnaligned_With_BinaryPrimitives_ReverseEndianness()
    {
        var source = data.AsSpan();
        ref var dest = ref MemoryMarshal.GetReference(destination.AsSpan());

        for (var i = 0; i < N; i++)
        {
            Unsafe.WriteUnaligned(ref Unsafe.Add(ref dest, i * sizeof(int)), BinaryPrimitives.ReverseEndianness(source[i]));
        }
    }
}