``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.102
  [Host]              : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  TaskQueueMonitoring : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2

Job=TaskQueueMonitoring  IterationCount=10  RunStrategy=Monitoring  

```
|                            Method |     Mean |    Error |   StdDev | Completed Work Items | Lock Contentions | Code Size |      Gen0 | Allocated |
|---------------------------------- |---------:|---------:|---------:|---------------------:|-----------------:|----------:|----------:|----------:|
|      InterLockedExchangeTaskQueue | 253.2 ms | 15.93 ms | 10.54 ms |          160008.0000 |                - |     946 B | 5000.0000 |  43.95 MB |
| InterLockedExchangeAwaitTaskQueue | 220.9 ms | 16.20 ms | 10.71 ms |          147294.0000 |                - |     820 B | 4000.0000 |  37.99 MB |
|                   LockedTaskQueue | 251.4 ms | 18.97 ms | 12.55 ms |          160008.0000 |          29.0000 |   1,201 B | 4000.0000 |  36.62 MB |
|                  ChannelTaskQueue | 231.2 ms | 19.35 ms | 12.80 ms |          160447.0000 |           2.0000 |     820 B | 3000.0000 |  26.47 MB |
