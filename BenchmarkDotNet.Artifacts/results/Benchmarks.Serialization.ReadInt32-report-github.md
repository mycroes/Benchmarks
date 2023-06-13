``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-TIXCXF : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  Job-PGYRRQ : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-MXZRCV : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
  Job-FJZKVM : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256


```
|                                 Method |              Runtime |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|--------------------------------------- |--------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|----------:|----------:|------------:|
| BinaryPrimitives_ReadInt32LittleEndian |             .NET 6.0 |  0.0043 ns | 0.0085 ns | 0.0155 ns |  0.0000 ns | 0.000 |    0.00 |      49 B |         - |          NA |
| BinaryPrimitives_ReadInt32LittleEndian |             .NET 7.0 |  0.0349 ns | 0.0300 ns | 0.0493 ns |  0.0118 ns | 0.003 |    0.00 |      50 B |         - |          NA |
| BinaryPrimitives_ReadInt32LittleEndian | .NET Framework 4.6.2 | 12.5849 ns | 0.4337 ns | 1.2444 ns | 12.6127 ns | 1.000 |    0.00 |     173 B |         - |          NA |
| BinaryPrimitives_ReadInt32LittleEndian |   .NET Framework 4.8 | 13.3847 ns | 0.5973 ns | 1.6945 ns | 12.6782 ns | 1.078 |    0.19 |     173 B |         - |          NA |
|                                        |                      |            |           |           |            |       |         |           |           |             |
|                   Unsafe_ReadUnaligned |             .NET 6.0 |  0.0124 ns | 0.0137 ns | 0.0250 ns |  0.0000 ns | 0.001 |    0.00 |      23 B |         - |          NA |
|                   Unsafe_ReadUnaligned |             .NET 7.0 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns | 0.000 |    0.00 |      23 B |         - |          NA |
|                   Unsafe_ReadUnaligned | .NET Framework 4.6.2 | 12.1512 ns | 0.2818 ns | 0.4785 ns | 12.1353 ns | 1.000 |    0.00 |     110 B |         - |          NA |
|                   Unsafe_ReadUnaligned |   .NET Framework 4.8 | 11.7623 ns | 0.2685 ns | 0.3492 ns | 11.6804 ns | 0.970 |    0.05 |     110 B |         - |          NA |
