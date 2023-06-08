``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.302
  [Host]              : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-PVBHWX          : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  Job-HVGVMY          : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-MBMOVA          : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
  Job-BYDXEP          : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
  TaskQueueMonitoring : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                            Method |                 Job |              Runtime | IterationCount | RunStrategy | UnrollFactor |      Mean |     Error |    StdDev | Ratio | RatioSD | Code Size |       Gen0 |      Gen1 |     Gen2 | Allocated | Alloc Ratio |
|---------------------------------- |-------------------- |--------------------- |--------------- |------------ |------------- |----------:|----------:|----------:|------:|--------:|----------:|-----------:|----------:|---------:|----------:|------------:|
|      InterLockedExchangeTaskQueue |          Job-PVBHWX |             .NET 6.0 |        Default |     Default |           16 | 159.71 ms |  0.452 ms |  0.423 ms |  0.63 |    0.00 |     747 B |  5500.0000 |         - |        - |  43.95 MB |        0.73 |
|      InterLockedExchangeTaskQueue |          Job-HVGVMY |             .NET 7.0 |        Default |     Default |           16 | 109.29 ms |  0.393 ms |  0.367 ms |  0.43 |    0.00 |     545 B |  5400.0000 |         - |        - |  43.95 MB |        0.73 |
|      InterLockedExchangeTaskQueue |          Job-MBMOVA | .NET Framework 4.6.2 |        Default |     Default |           16 | 253.05 ms |  1.360 ms |  1.205 ms |  1.00 |    0.00 |     833 B | 10000.0000 |  500.0000 |        - |  60.31 MB |        1.00 |
|      InterLockedExchangeTaskQueue |          Job-BYDXEP |   .NET Framework 4.8 |        Default |     Default |           16 | 253.15 ms |  1.722 ms |  1.438 ms |  1.00 |    0.00 |     833 B | 10000.0000 |  500.0000 |        - |  60.25 MB |        1.00 |
|      InterLockedExchangeTaskQueue | TaskQueueMonitoring |             .NET 7.0 |             10 |  Monitoring |            1 | 128.93 ms | 30.258 ms | 20.014 ms |  0.51 |    0.08 |     735 B |  5000.0000 |         - |        - |  43.95 MB |        0.73 |
|                                   |                     |                      |                |             |              |           |           |           |       |         |           |            |           |          |           |             |
| InterLockedExchangeAwaitTaskQueue |          Job-PVBHWX |             .NET 6.0 |        Default |     Default |           16 | 143.99 ms |  2.139 ms |  2.001 ms |  0.87 |    0.01 |     632 B |  4750.0000 |         - |        - |  38.18 MB |        0.60 |
| InterLockedExchangeAwaitTaskQueue |          Job-HVGVMY |             .NET 7.0 |        Default |     Default |           16 |  84.88 ms |  0.918 ms |  0.814 ms |  0.51 |    0.01 |     545 B |  4666.6667 |         - |        - |  38.06 MB |        0.60 |
| InterLockedExchangeAwaitTaskQueue |          Job-MBMOVA | .NET Framework 4.6.2 |        Default |     Default |           16 | 165.56 ms |  1.171 ms |  1.038 ms |  1.00 |    0.00 |     716 B | 10500.0000 |  500.0000 |        - |   63.9 MB |        1.00 |
| InterLockedExchangeAwaitTaskQueue |          Job-BYDXEP |   .NET Framework 4.8 |        Default |     Default |           16 | 165.86 ms |  1.870 ms |  1.658 ms |  1.00 |    0.01 |     716 B | 10333.3333 |  333.3333 |        - |  63.95 MB |        1.00 |
| InterLockedExchangeAwaitTaskQueue | TaskQueueMonitoring |             .NET 7.0 |             10 |  Monitoring |            1 |  98.75 ms | 21.176 ms | 14.006 ms |  0.60 |    0.09 |     736 B |  4000.0000 |         - |        - |  38.13 MB |        0.60 |
|                                   |                     |                      |                |             |              |           |           |           |       |         |           |            |           |          |           |             |
|                   LockedTaskQueue |          Job-PVBHWX |             .NET 6.0 |        Default |     Default |           16 | 157.72 ms |  0.607 ms |  0.568 ms |  0.61 |    0.01 |   1,002 B |  4500.0000 |         - |        - |  36.62 MB |        0.70 |
|                   LockedTaskQueue |          Job-HVGVMY |             .NET 7.0 |        Default |     Default |           16 | 109.29 ms |  1.246 ms |  1.166 ms |  0.43 |    0.01 |     545 B |  4600.0000 |         - |        - |  36.62 MB |        0.70 |
|                   LockedTaskQueue |          Job-MBMOVA | .NET Framework 4.6.2 |        Default |     Default |           16 | 257.39 ms |  4.956 ms |  5.303 ms |  1.00 |    0.00 |     887 B |  8500.0000 |  500.0000 |        - |   52.2 MB |        1.00 |
|                   LockedTaskQueue |          Job-BYDXEP |   .NET Framework 4.8 |        Default |     Default |           16 | 254.21 ms |  2.958 ms |  2.767 ms |  0.99 |    0.02 |     887 B |  8500.0000 |  500.0000 |        - |  52.25 MB |        1.00 |
|                   LockedTaskQueue | TaskQueueMonitoring |             .NET 7.0 |             10 |  Monitoring |            1 | 123.19 ms | 30.348 ms | 20.073 ms |  0.49 |    0.08 |     735 B |  4000.0000 |         - |        - |  36.62 MB |        0.70 |
|                                   |                     |                      |                |             |              |           |           |           |       |         |           |            |           |          |           |             |
|                  ChannelTaskQueue |          Job-PVBHWX |             .NET 6.0 |        Default |     Default |           16 | 155.57 ms |  0.908 ms |  0.849 ms |  0.65 |    0.01 |     632 B |  3250.0000 |         - |        - |  26.47 MB |        0.49 |
|                  ChannelTaskQueue |          Job-HVGVMY |             .NET 7.0 |        Default |     Default |           16 | 104.95 ms |  0.658 ms |  0.584 ms |  0.44 |    0.00 |     545 B |  3200.0000 |         - |        - |  26.47 MB |        0.49 |
|                  ChannelTaskQueue |          Job-MBMOVA | .NET Framework 4.6.2 |        Default |     Default |           16 | 238.77 ms |  1.458 ms |  1.293 ms |  1.00 |    0.00 |     716 B |  8666.6667 | 1333.3333 | 333.3333 |  53.69 MB |        1.00 |
|                  ChannelTaskQueue |          Job-BYDXEP |   .NET Framework 4.8 |        Default |     Default |           16 | 240.72 ms |  2.065 ms |  1.831 ms |  1.01 |    0.01 |     716 B |  8666.6667 | 1000.0000 | 333.3333 |  53.71 MB |        1.00 |
|                  ChannelTaskQueue | TaskQueueMonitoring |             .NET 7.0 |             10 |  Monitoring |            1 | 115.06 ms | 17.592 ms | 11.636 ms |  0.48 |    0.05 |     735 B |  3000.0000 |         - |        - |  26.47 MB |        0.49 |
