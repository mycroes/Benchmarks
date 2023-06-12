``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-FIJYSG : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  Job-KNJVDR : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-HDUSYM : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
  Job-WVTWCH : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256


```
|                            Method |              Runtime |     Mean |     Error |    StdDev | Ratio | RatioSD |   Gen0 | Code Size |   Gen1 |   Gen2 | Allocated | Alloc Ratio |
|---------------------------------- |--------------------- |---------:|----------:|----------:|------:|--------:|-------:|----------:|-------:|-------:|----------:|------------:|
|      InterLockedExchangeTaskQueue |             .NET 6.0 | 1.303 μs | 0.0247 μs | 0.0264 μs |  0.58 |    0.02 | 0.0648 |     717 B |      - |      - |     552 B |        0.74 |
|      InterLockedExchangeTaskQueue |             .NET 7.0 | 1.292 μs | 0.0151 μs | 0.0141 μs |  0.57 |    0.01 | 0.0648 |     312 B |      - |      - |     552 B |        0.74 |
|      InterLockedExchangeTaskQueue | .NET Framework 4.6.2 | 2.257 μs | 0.0267 μs | 0.0250 μs |  1.00 |    0.00 | 0.1183 |     650 B | 0.0038 |      - |     746 B |        1.00 |
|      InterLockedExchangeTaskQueue |   .NET Framework 4.8 | 2.252 μs | 0.0446 μs | 0.0373 μs |  1.00 |    0.02 | 0.1183 |     650 B | 0.0038 |      - |     746 B |        1.00 |
|                                   |                      |          |           |           |       |         |        |           |        |        |           |             |
| InterLockedExchangeAwaitTaskQueue |             .NET 6.0 | 1.341 μs | 0.0101 μs | 0.0089 μs |  0.55 |    0.01 | 0.0572 |     397 B |      - |      - |     488 B |        0.61 |
| InterLockedExchangeAwaitTaskQueue |             .NET 7.0 | 1.311 μs | 0.0095 μs | 0.0084 μs |  0.54 |    0.01 | 0.0572 |     312 B |      - |      - |     487 B |        0.61 |
| InterLockedExchangeAwaitTaskQueue | .NET Framework 4.6.2 | 2.438 μs | 0.0352 μs | 0.0329 μs |  1.00 |    0.00 | 0.1259 |     527 B | 0.0038 |      - |     795 B |        1.00 |
| InterLockedExchangeAwaitTaskQueue |   .NET Framework 4.8 | 2.363 μs | 0.0356 μs | 0.0333 μs |  0.97 |    0.02 | 0.1259 |     527 B | 0.0038 |      - |     795 B |        1.00 |
|                                   |                      |          |           |           |       |         |        |           |        |        |           |             |
|                   LockedTaskQueue |             .NET 6.0 | 1.212 μs | 0.0155 μs | 0.0145 μs |  0.55 |    0.01 | 0.0458 |     769 B |      - |      - |     384 B |        0.60 |
|                   LockedTaskQueue |             .NET 7.0 | 1.203 μs | 0.0180 μs | 0.0169 μs |  0.55 |    0.01 | 0.0458 |     312 B |      - |      - |     384 B |        0.60 |
|                   LockedTaskQueue | .NET Framework 4.6.2 | 2.208 μs | 0.0343 μs | 0.0321 μs |  1.00 |    0.00 | 0.0992 |     704 B | 0.0038 |      - |     642 B |        1.00 |
|                   LockedTaskQueue |   .NET Framework 4.8 | 2.117 μs | 0.0323 μs | 0.0302 μs |  0.96 |    0.02 | 0.0992 |     704 B | 0.0038 |      - |     642 B |        1.00 |
|                                   |                      |          |           |           |       |         |        |           |        |        |           |             |
|                  ChannelTaskQueue |             .NET 6.0 | 1.362 μs | 0.0214 μs | 0.0200 μs |  0.46 |    0.01 | 0.0381 |     397 B |      - |      - |     320 B |        0.51 |
|                  ChannelTaskQueue |             .NET 7.0 | 1.403 μs | 0.0154 μs | 0.0144 μs |  0.47 |    0.01 | 0.0381 |     312 B |      - |      - |     320 B |        0.51 |
|                  ChannelTaskQueue | .NET Framework 4.6.2 | 2.969 μs | 0.0448 μs | 0.0419 μs |  1.00 |    0.00 | 0.0992 |     527 B | 0.0114 | 0.0038 |     626 B |        1.00 |
|                  ChannelTaskQueue |   .NET Framework 4.8 | 2.953 μs | 0.0355 μs | 0.0332 μs |  0.99 |    0.02 | 0.0992 |     527 B | 0.0114 | 0.0038 |     626 B |        1.00 |
