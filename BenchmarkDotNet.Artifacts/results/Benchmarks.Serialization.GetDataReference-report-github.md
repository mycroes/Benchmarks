``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.401
  [Host]     : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2


```
|                                        Method |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Completed Work Items | Lock Contentions | Code Size | Allocated | Alloc Ratio |
|---------------------------------------------- |----------:|----------:|----------:|----------:|------:|--------:|---------------------:|-----------------:|----------:|----------:|------------:|
| MemoryMarshal_Cast_MemoryMarshal_GetReference | 0.1545 ns | 0.0418 ns | 0.0429 ns | 0.1490 ns |  1.00 |    0.00 |                    - |                - |      51 B |         - |          NA |
|                         Unsafe_As_Ref_Index_0 | 0.0414 ns | 0.0274 ns | 0.0347 ns | 0.0514 ns |  0.27 |    0.30 |                    - |                - |      29 B |         - |          NA |
|          Unsafe_As_MemoryMarshal_GetReference | 0.2184 ns | 0.0356 ns | 0.0585 ns | 0.2101 ns |  1.72 |    0.54 |                    - |                - |      24 B |         - |          NA |
| Unsafe_As_MemoryMarshal_GetArrayDataReference | 0.0340 ns | 0.0253 ns | 0.0416 ns | 0.0123 ns |  0.16 |    0.21 |                    - |                - |      11 B |         - |          NA |
