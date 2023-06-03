``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.102
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                            Method |     Mean |     Error |    StdDev | Completed Work Items | Lock Contentions | Code Size |   Gen0 | Allocated |
|---------------------------------- |---------:|----------:|----------:|---------------------:|-----------------:|----------:|-------:|----------:|
|      InterLockedExchangeTaskQueue | 2.676 μs | 0.0354 μs | 0.0331 μs |               2.0000 |                - |     512 B | 0.0648 |     552 B |
| InterLockedExchangeAwaitTaskQueue | 1.652 μs | 0.0238 μs | 0.0223 μs |               1.0151 |                - |     397 B | 0.0572 |     488 B |
|                   LockedTaskQueue | 2.604 μs | 0.0182 μs | 0.0161 μs |               2.0000 |                - |     767 B | 0.0534 |     456 B |
|                  ChannelTaskQueue | 1.619 μs | 0.0252 μs | 0.0236 μs |               1.0161 |                - |     397 B | 0.0381 |     320 B |
