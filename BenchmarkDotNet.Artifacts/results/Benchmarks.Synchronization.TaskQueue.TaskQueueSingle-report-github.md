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
|                            Method |              Runtime |     Mean |     Error |    StdDev | Ratio | RatioSD | Code Size |   Gen0 |   Gen1 |   Gen2 | Allocated | Alloc Ratio |
|---------------------------------- |--------------------- |---------:|----------:|----------:|------:|--------:|----------:|-------:|-------:|-------:|----------:|------------:|
|      InterLockedExchangeTaskQueue |             .NET 6.0 | 2.032 μs | 0.0161 μs | 0.0150 μs |  0.44 |    0.01 |     512 B | 0.0648 |      - |      - |     552 B |        0.72 |
|      InterLockedExchangeTaskQueue |             .NET 7.0 | 1.699 μs | 0.0116 μs | 0.0109 μs |  0.37 |    0.00 |     312 B | 0.0648 |      - |      - |     552 B |        0.72 |
|      InterLockedExchangeTaskQueue | .NET Framework 4.6.2 | 4.610 μs | 0.0345 μs | 0.0323 μs |  1.00 |    0.00 |     644 B | 0.1144 | 0.0076 |      - |     764 B |        1.00 |
|      InterLockedExchangeTaskQueue |   .NET Framework 4.8 | 4.726 μs | 0.0306 μs | 0.0286 μs |  1.03 |    0.01 |     644 B | 0.1144 | 0.0076 |      - |     764 B |        1.00 |
|                                   |                      |          |           |           |       |         |           |        |        |        |           |             |
| InterLockedExchangeAwaitTaskQueue |             .NET 6.0 | 1.345 μs | 0.0088 μs | 0.0078 μs |  0.53 |    0.01 |     397 B | 0.0572 |      - |      - |     488 B |        0.61 |
| InterLockedExchangeAwaitTaskQueue |             .NET 7.0 | 1.310 μs | 0.0129 μs | 0.0121 μs |  0.52 |    0.01 |     312 B | 0.0572 |      - |      - |     486 B |        0.61 |
| InterLockedExchangeAwaitTaskQueue | .NET Framework 4.6.2 | 2.520 μs | 0.0449 μs | 0.0420 μs |  1.00 |    0.00 |     527 B | 0.1259 | 0.0038 |      - |     795 B |        1.00 |
| InterLockedExchangeAwaitTaskQueue |   .NET Framework 4.8 | 2.460 μs | 0.0374 μs | 0.0331 μs |  0.97 |    0.02 |     527 B | 0.1259 | 0.0038 |      - |     795 B |        1.00 |
|                                   |                      |          |           |           |       |         |           |        |        |        |           |             |
|                   LockedTaskQueue |             .NET 6.0 | 1.992 μs | 0.0214 μs | 0.0189 μs |  0.45 |    0.01 |     767 B | 0.0534 |      - |      - |     456 B |        0.69 |
|                   LockedTaskQueue |             .NET 7.0 | 1.535 μs | 0.0073 μs | 0.0069 μs |  0.35 |    0.00 |     312 B | 0.0534 |      - |      - |     456 B |        0.69 |
|                   LockedTaskQueue | .NET Framework 4.6.2 | 4.445 μs | 0.0645 μs | 0.0603 μs |  1.00 |    0.00 |     698 B | 0.0992 | 0.0076 |      - |     659 B |        1.00 |
|                   LockedTaskQueue |   .NET Framework 4.8 | 3.656 μs | 0.0310 μs | 0.0290 μs |  0.82 |    0.01 |     698 B | 0.1030 | 0.0191 | 0.0038 |     659 B |        1.00 |
|                                   |                      |          |           |           |       |         |           |        |        |        |           |             |
|                  ChannelTaskQueue |             .NET 6.0 | 1.376 μs | 0.0032 μs | 0.0027 μs |  0.46 |    0.01 |     397 B | 0.0381 |      - |      - |     320 B |        0.51 |
|                  ChannelTaskQueue |             .NET 7.0 | 1.394 μs | 0.0159 μs | 0.0149 μs |  0.46 |    0.01 |     312 B | 0.0381 |      - |      - |     320 B |        0.51 |
|                  ChannelTaskQueue | .NET Framework 4.6.2 | 3.010 μs | 0.0431 μs | 0.0382 μs |  1.00 |    0.00 |     527 B | 0.0992 | 0.0114 | 0.0038 |     626 B |        1.00 |
|                  ChannelTaskQueue |   .NET Framework 4.8 | 3.016 μs | 0.0600 μs | 0.0561 μs |  1.00 |    0.02 |     527 B | 0.0992 | 0.0114 | 0.0038 |     626 B |        1.00 |
