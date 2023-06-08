``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-PVBHWX : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  Job-HVGVMY : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-MBMOVA : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
  Job-BYDXEP : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256


```
|                                                        Method |              Runtime |      Mean |     Error |    StdDev | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|-------------------------------------------------------------- |--------------------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
|                       BinaryPrimitives_WriteInt32LittleEndian |             .NET 6.0 |  8.692 μs | 0.1696 μs | 0.3268 μs |  0.19 |    0.01 |     137 B |         - |          NA |
|                       BinaryPrimitives_WriteInt32LittleEndian |             .NET 7.0 |  8.338 μs | 0.1623 μs | 0.1804 μs |  0.18 |    0.01 |     139 B |         - |          NA |
|                       BinaryPrimitives_WriteInt32LittleEndian | .NET Framework 4.6.2 | 45.596 μs | 0.8995 μs | 2.0668 μs |  1.00 |    0.00 |     379 B |         - |          NA |
|                       BinaryPrimitives_WriteInt32LittleEndian |   .NET Framework 4.8 | 39.376 μs | 0.7505 μs | 1.7092 μs |  0.87 |    0.06 |     379 B |         - |          NA |
|                                                               |                      |           |           |           |       |         |           |           |             |
|                                         Unsafe_WriteUnaligned |             .NET 6.0 |  5.443 μs | 0.0903 μs | 0.0845 μs |  0.59 |    0.02 |      96 B |         - |          NA |
|                                         Unsafe_WriteUnaligned |             .NET 7.0 |  5.463 μs | 0.0870 μs | 0.0893 μs |  0.60 |    0.02 |      95 B |         - |          NA |
|                                         Unsafe_WriteUnaligned | .NET Framework 4.6.2 |  9.163 μs | 0.1753 μs | 0.2217 μs |  1.00 |    0.00 |     216 B |         - |          NA |
|                                         Unsafe_WriteUnaligned |   .NET Framework 4.8 |  8.430 μs | 0.1650 μs | 0.2313 μs |  0.92 |    0.04 |     216 B |         - |          NA |
|                                                               |                      |           |           |           |       |         |           |           |             |
|                                 MemoryMarshal_Cast_And_CopyTo |             .NET 6.0 | 29.423 μs | 0.5478 μs | 0.8365 μs |  0.32 |    0.02 |     509 B |         - |          NA |
|                                 MemoryMarshal_Cast_And_CopyTo |             .NET 7.0 | 26.719 μs | 0.5245 μs | 0.7179 μs |  0.28 |    0.01 |     447 B |         - |          NA |
|                                 MemoryMarshal_Cast_And_CopyTo | .NET Framework 4.6.2 | 90.493 μs | 1.8083 μs | 4.7321 μs |  1.00 |    0.00 |     529 B |         - |          NA |
|                                 MemoryMarshal_Cast_And_CopyTo |   .NET Framework 4.8 | 96.210 μs | 1.9132 μs | 3.1435 μs |  1.05 |    0.06 |     529 B |         - |          NA |
|                                                               |                      |           |           |           |       |         |           |           |             |
|                          BinaryPrimitives_WriteInt32BigEndian |             .NET 6.0 |  9.075 μs | 0.1546 μs | 0.2217 μs |  0.21 |    0.01 |     139 B |         - |          NA |
|                          BinaryPrimitives_WriteInt32BigEndian |             .NET 7.0 |  9.267 μs | 0.1807 μs | 0.3117 μs |  0.21 |    0.01 |     149 B |         - |          NA |
|                          BinaryPrimitives_WriteInt32BigEndian | .NET Framework 4.6.2 | 43.713 μs | 0.7791 μs | 1.0131 μs |  1.00 |    0.00 |     379 B |         - |          NA |
|                          BinaryPrimitives_WriteInt32BigEndian |   .NET Framework 4.8 | 43.695 μs | 0.8319 μs | 0.8170 μs |  1.00 |    0.04 |     379 B |         - |          NA |
|                                                               |                      |           |           |           |       |         |           |           |             |
| Unsafe_WriteUnaligned_With_BinaryPrimitives_ReverseEndianness |             .NET 6.0 |  6.110 μs | 0.1106 μs | 0.2023 μs |  0.51 |    0.02 |      99 B |         - |          NA |
| Unsafe_WriteUnaligned_With_BinaryPrimitives_ReverseEndianness |             .NET 7.0 |  6.097 μs | 0.1198 μs | 0.1600 μs |  0.50 |    0.02 |      97 B |         - |          NA |
| Unsafe_WriteUnaligned_With_BinaryPrimitives_ReverseEndianness | .NET Framework 4.6.2 | 12.104 μs | 0.2365 μs | 0.2816 μs |  1.00 |    0.00 |     244 B |         - |          NA |
| Unsafe_WriteUnaligned_With_BinaryPrimitives_ReverseEndianness |   .NET Framework 4.8 | 12.390 μs | 0.2357 μs | 0.4309 μs |  1.03 |    0.05 |     244 B |         - |          NA |
