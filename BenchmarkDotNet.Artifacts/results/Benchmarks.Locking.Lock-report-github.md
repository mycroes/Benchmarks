``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3086/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-ZPMBNN : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2
  Job-EBYCEZ : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-VXASFE : .NET Framework 4.8 (4.8.4644.0), X64 RyuJIT VectorSize=256
  Job-HZZWLU : .NET Framework 4.8 (4.8.4644.0), X64 RyuJIT VectorSize=256


```
|          Method |              Runtime |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Code Size |   Gen0 |   Gen1 |   Gen2 | Allocated | Alloc Ratio |
|---------------- |--------------------- |----------:|----------:|----------:|----------:|------:|--------:|----------:|-------:|-------:|-------:|----------:|------------:|
|       LockMutex |             .NET 6.0 | 16.538 ns | 0.3564 ns | 0.6866 ns | 16.461 ns |  1.05 |    0.06 |     114 B |      - |      - |      - |         - |          NA |
|       LockMutex |             .NET 7.0 | 16.545 ns | 0.3534 ns | 0.4595 ns | 16.561 ns |  1.05 |    0.05 |     115 B |      - |      - |      - |         - |          NA |
|       LockMutex | .NET Framework 4.6.2 | 15.778 ns | 0.3400 ns | 0.4422 ns | 15.659 ns |  1.00 |    0.00 |     193 B |      - |      - |      - |         - |          NA |
|       LockMutex |   .NET Framework 4.8 | 16.435 ns | 0.3579 ns | 0.3348 ns | 16.534 ns |  1.04 |    0.04 |     193 B |      - |      - |      - |         - |          NA |
|                 |                      |           |           |           |           |       |         |           |        |        |        |           |             |
|    MonitorEnter |             .NET 6.0 | 15.681 ns | 0.3439 ns | 0.6708 ns | 15.481 ns |  1.02 |    0.05 |     125 B |      - |      - |      - |         - |          NA |
|    MonitorEnter |             .NET 7.0 | 16.948 ns | 0.3607 ns | 0.3859 ns | 16.883 ns |  1.07 |    0.04 |     127 B |      - |      - |      - |         - |          NA |
|    MonitorEnter | .NET Framework 4.6.2 | 15.866 ns | 0.2982 ns | 0.2644 ns | 15.833 ns |  1.00 |    0.00 |     214 B |      - |      - |      - |         - |          NA |
|    MonitorEnter |   .NET Framework 4.8 | 15.668 ns | 0.3280 ns | 0.3904 ns | 15.711 ns |  0.99 |    0.03 |     214 B |      - |      - |      - |         - |          NA |
|                 |                      |           |           |           |           |       |         |           |        |        |        |           |             |
| CompareExchange |             .NET 6.0 |  5.923 ns | 0.1474 ns | 0.1917 ns |  5.936 ns |  0.67 |    0.02 |      99 B |      - |      - |      - |         - |          NA |
| CompareExchange |             .NET 7.0 |  6.494 ns | 0.1626 ns | 0.2171 ns |  6.490 ns |  0.73 |    0.02 |     100 B |      - |      - |      - |         - |          NA |
| CompareExchange | .NET Framework 4.6.2 |  8.832 ns | 0.1985 ns | 0.2124 ns |  8.813 ns |  1.00 |    0.00 |     110 B |      - |      - |      - |         - |          NA |
| CompareExchange |   .NET Framework 4.8 |  9.028 ns | 0.2069 ns | 0.3399 ns |  8.970 ns |  1.04 |    0.05 |     110 B |      - |      - |      - |         - |          NA |
|                 |                      |           |           |           |           |       |         |           |        |        |        |           |             |
|     ChannelRead |             .NET 6.0 | 35.888 ns | 0.6666 ns | 0.8899 ns | 35.935 ns |  0.62 |    0.02 |     139 B |      - |      - |      - |         - |        0.00 |
|     ChannelRead |             .NET 7.0 | 38.052 ns | 0.7129 ns | 0.6669 ns | 38.203 ns |  0.66 |    0.02 |     140 B |      - |      - |      - |         - |        0.00 |
|     ChannelRead | .NET Framework 4.6.2 | 57.713 ns | 1.1847 ns | 1.2676 ns | 57.668 ns |  1.00 |    0.00 |     126 B | 0.0014 | 0.0007 | 0.0001 |       9 B |        1.00 |
|     ChannelRead |   .NET Framework 4.8 | 57.121 ns | 1.1690 ns | 2.4142 ns | 55.876 ns |  0.99 |    0.05 |     126 B | 0.0014 | 0.0007 | 0.0001 |       9 B |        1.00 |
