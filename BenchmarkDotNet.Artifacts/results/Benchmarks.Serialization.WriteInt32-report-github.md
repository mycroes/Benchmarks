``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.102
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                                                        Method |      Mean |     Error |    StdDev |    Median | Completed Work Items | Lock Contentions | Code Size | Allocated |
|-------------------------------------------------------------- |----------:|----------:|----------:|----------:|---------------------:|-----------------:|----------:|----------:|
|                       BinaryPrimitives_WriteInt32LittleEndian | 10.427 μs | 0.1675 μs | 0.1399 μs | 10.427 μs |                    - |                - |     137 B |         - |
|                                         Unsafe_WriteUnaligned |  6.858 μs | 0.1337 μs | 0.3793 μs |  6.738 μs |                    - |                - |      96 B |         - |
|                                 MemoryMarshal_Cast_And_CopyTo | 35.415 μs | 0.7010 μs | 0.9827 μs | 35.268 μs |                    - |                - |     509 B |         - |
|                          BinaryPrimitives_WriteInt32BigEndian | 11.718 μs | 0.2313 μs | 0.4878 μs | 11.618 μs |                    - |                - |     139 B |         - |
| Unsafe_WriteUnaligned_With_BinaryPrimitives_ReverseEndianness |  7.527 μs | 0.1487 μs | 0.2359 μs |  7.520 μs |                    - |                - |      99 B |         - |
