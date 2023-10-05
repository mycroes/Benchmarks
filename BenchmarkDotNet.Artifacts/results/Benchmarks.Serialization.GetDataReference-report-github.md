``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.401
  [Host]     : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  Job-NEMWWM : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2

WarmupCount=2  

```
|                                        Method |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Completed Work Items | Lock Contentions | Code Size | Allocated | Alloc Ratio |
|---------------------------------------------- |----------:|----------:|----------:|----------:|------:|--------:|---------------------:|-----------------:|----------:|----------:|------------:|
| MemoryMarshal_Cast_MemoryMarshal_GetReference | 0.8062 ns | 0.0478 ns | 0.0988 ns | 0.7884 ns | 1.000 |    0.00 |                    - |                - |      51 B |         - |          NA |
|                         Unsafe_As_Ref_Index_0 | 0.2462 ns | 0.0357 ns | 0.0555 ns | 0.2204 ns | 0.308 |    0.08 |                    - |                - |      29 B |         - |          NA |
|          Unsafe_As_MemoryMarshal_GetReference | 0.0260 ns | 0.0220 ns | 0.0403 ns | 0.0000 ns | 0.033 |    0.05 |                    - |                - |      24 B |         - |          NA |
| Unsafe_As_MemoryMarshal_GetArrayDataReference | 0.0074 ns | 0.0118 ns | 0.0158 ns | 0.0000 ns | 0.009 |    0.02 |                    - |                - |      11 B |         - |          NA |
