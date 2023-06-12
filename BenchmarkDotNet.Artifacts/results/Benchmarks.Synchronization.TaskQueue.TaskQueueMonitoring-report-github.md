``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.302
  [Host]              : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-FIJYSG          : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  Job-KNJVDR          : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-HDUSYM          : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
  Job-WVTWCH          : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
  TaskQueueMonitoring : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                            Method |                 Job |              Runtime | IterationCount | RunStrategy | UnrollFactor |      Mean |     Error |    StdDev | Ratio | RatioSD |       Gen0 | Code Size |      Gen1 |     Gen2 | Allocated | Alloc Ratio |
|---------------------------------- |-------------------- |--------------------- |--------------- |------------ |------------- |----------:|----------:|----------:|------:|--------:|-----------:|----------:|----------:|---------:|----------:|------------:|
|      InterLockedExchangeTaskQueue |          Job-FIJYSG |             .NET 6.0 |        Default |     Default |           16 |  93.85 ms |  1.790 ms |  1.587 ms |  0.43 |    0.01 |  5500.0000 |     952 B |         - |        - |  43.95 MB |        0.73 |
|      InterLockedExchangeTaskQueue |          Job-KNJVDR |             .NET 7.0 |        Default |     Default |           16 |  69.69 ms |  1.105 ms |  1.034 ms |  0.32 |    0.01 |  5500.0000 |     545 B |         - |        - |  43.95 MB |        0.73 |
|      InterLockedExchangeTaskQueue |          Job-HDUSYM | .NET Framework 4.6.2 |        Default |     Default |           16 | 220.15 ms |  3.288 ms |  2.915 ms |  1.00 |    0.00 |  9666.6667 |     839 B |  333.3333 |        - |  59.96 MB |        1.00 |
|      InterLockedExchangeTaskQueue |          Job-WVTWCH |   .NET Framework 4.8 |        Default |     Default |           16 | 218.14 ms |  2.745 ms |  2.292 ms |  0.99 |    0.01 |  9666.6667 |     839 B |  333.3333 |        - |  59.97 MB |        1.00 |
|      InterLockedExchangeTaskQueue | TaskQueueMonitoring |             .NET 7.0 |             10 |  Monitoring |            1 | 102.16 ms | 52.649 ms | 34.824 ms |  0.46 |    0.16 |  5000.0000 |     735 B |         - |        - |  43.95 MB |        0.73 |
|                                   |                     |                      |                |             |              |           |           |           |       |         |            |           |           |          |           |             |
| InterLockedExchangeAwaitTaskQueue |          Job-FIJYSG |             .NET 6.0 |        Default |     Default |           16 | 144.03 ms |  0.425 ms |  0.398 ms |  0.88 |    0.01 |  4750.0000 |     632 B |         - |        - |  38.16 MB |        0.60 |
| InterLockedExchangeAwaitTaskQueue |          Job-KNJVDR |             .NET 7.0 |        Default |     Default |           16 |  84.61 ms |  0.793 ms |  0.663 ms |  0.52 |    0.00 |  4666.6667 |     545 B |         - |        - |  38.18 MB |        0.60 |
| InterLockedExchangeAwaitTaskQueue |          Job-HDUSYM | .NET Framework 4.6.2 |        Default |     Default |           16 | 162.82 ms |  1.421 ms |  1.260 ms |  1.00 |    0.00 | 10500.0000 |     716 B |  500.0000 |        - |  63.92 MB |        1.00 |
| InterLockedExchangeAwaitTaskQueue |          Job-WVTWCH |   .NET Framework 4.8 |        Default |     Default |           16 | 165.62 ms |  2.155 ms |  2.015 ms |  1.02 |    0.02 | 10500.0000 |     716 B |  500.0000 |        - |  63.91 MB |        1.00 |
| InterLockedExchangeAwaitTaskQueue | TaskQueueMonitoring |             .NET 7.0 |             10 |  Monitoring |            1 | 100.54 ms | 19.396 ms | 12.829 ms |  0.62 |    0.08 |  4000.0000 |     736 B |         - |        - |   38.1 MB |        0.60 |
|                                   |                     |                      |                |             |              |           |           |           |       |         |            |           |           |          |           |             |
|                   LockedTaskQueue |          Job-FIJYSG |             .NET 6.0 |        Default |     Default |           16 |  90.16 ms |  1.349 ms |  1.262 ms |  0.43 |    0.01 |  4500.0000 |   1,004 B |         - |        - |  36.62 MB |        0.70 |
|                   LockedTaskQueue |          Job-KNJVDR |             .NET 7.0 |        Default |     Default |           16 |  68.44 ms |  0.922 ms |  0.863 ms |  0.33 |    0.01 |  4500.0000 |     545 B |         - |        - |  36.62 MB |        0.70 |
|                   LockedTaskQueue |          Job-HDUSYM | .NET Framework 4.6.2 |        Default |     Default |           16 | 208.42 ms |  3.321 ms |  3.106 ms |  1.00 |    0.00 |  8333.3333 |     893 B |  333.3333 |        - |  51.95 MB |        1.00 |
|                   LockedTaskQueue |          Job-WVTWCH |   .NET Framework 4.8 |        Default |     Default |           16 | 205.81 ms |  3.946 ms |  4.990 ms |  0.99 |    0.03 |  8333.3333 |     893 B |  333.3333 |        - |  51.98 MB |        1.00 |
|                   LockedTaskQueue | TaskQueueMonitoring |             .NET 7.0 |             10 |  Monitoring |            1 |  84.18 ms | 38.455 ms | 25.435 ms |  0.41 |    0.12 |  4000.0000 |     735 B |         - |        - |  36.62 MB |        0.71 |
|                                   |                     |                      |                |             |              |           |           |           |       |         |            |           |           |          |           |             |
|                  ChannelTaskQueue |          Job-FIJYSG |             .NET 6.0 |        Default |     Default |           16 | 157.17 ms |  1.008 ms |  0.943 ms |  0.65 |    0.01 |  3250.0000 |     632 B |         - |        - |  26.47 MB |        0.49 |
|                  ChannelTaskQueue |          Job-KNJVDR |             .NET 7.0 |        Default |     Default |           16 | 105.68 ms |  0.999 ms |  0.934 ms |  0.44 |    0.01 |  3200.0000 |     545 B |         - |        - |  26.46 MB |        0.49 |
|                  ChannelTaskQueue |          Job-HDUSYM | .NET Framework 4.6.2 |        Default |     Default |           16 | 242.96 ms |  4.524 ms |  4.232 ms |  1.00 |    0.00 |  8666.6667 |     716 B | 1000.0000 | 333.3333 |  53.72 MB |        1.00 |
|                  ChannelTaskQueue |          Job-WVTWCH |   .NET Framework 4.8 |        Default |     Default |           16 | 240.81 ms |  4.071 ms |  3.808 ms |  0.99 |    0.03 |  8666.6667 |     716 B | 1333.3333 | 333.3333 |  53.73 MB |        1.00 |
|                  ChannelTaskQueue | TaskQueueMonitoring |             .NET 7.0 |             10 |  Monitoring |            1 | 113.83 ms | 18.246 ms | 12.069 ms |  0.47 |    0.05 |  3000.0000 |     735 B |         - |        - |  26.47 MB |        0.49 |
