``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-DIRPAA : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

Runtime=.NET 7.0  Toolchain=net70  IterationTime=100.0000 ms  
WarmupCount=3  

```
|                 Method | Value |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|----------------------- |------ |----------:|----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| **IfModuloTwoIsOneAddOne** |     **1** | **0.3158 ns** | **0.0435 ns** | **0.0623 ns** | **0.3252 ns** |  **1.00** |    **0.00** |      **26 B** |         **-** |          **NA** |
|       IfBitIsSetAddOne |     1 | 0.0507 ns | 0.0306 ns | 0.0751 ns | 0.0085 ns |  0.23 |    0.26 |      11 B |         - |          NA |
|               NoBranch |     1 | 0.0253 ns | 0.0232 ns | 0.0310 ns | 0.0112 ns |  0.09 |    0.10 |      11 B |         - |          NA |
|                        |       |           |           |           |           |       |         |           |           |             |
| **IfModuloTwoIsOneAddOne** |     **2** | **0.0996 ns** | **0.0663 ns** | **0.1836 ns** | **0.0000 ns** |     **?** |       **?** |      **26 B** |         **-** |           **?** |
|       IfBitIsSetAddOne |     2 | 0.3976 ns | 0.0553 ns | 0.1550 ns | 0.3764 ns |     ? |       ? |      11 B |         - |           ? |
|               NoBranch |     2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |      11 B |         - |           ? |
|                        |       |           |           |           |           |       |         |           |           |             |
| **IfModuloTwoIsOneAddOne** |     **3** | **0.2670 ns** | **0.0452 ns** | **0.0924 ns** | **0.2525 ns** |  **1.00** |    **0.00** |      **26 B** |         **-** |          **NA** |
|       IfBitIsSetAddOne |     3 | 0.0189 ns | 0.0206 ns | 0.0426 ns | 0.0000 ns |  0.07 |    0.16 |      11 B |         - |          NA |
|               NoBranch |     3 | 0.0029 ns | 0.0094 ns | 0.0084 ns | 0.0000 ns |  0.01 |    0.04 |      11 B |         - |          NA |
|                        |       |           |           |           |           |       |         |           |           |             |
| **IfModuloTwoIsOneAddOne** |     **4** | **1.3477 ns** | **0.1765 ns** | **0.5205 ns** | **1.2100 ns** | **1.000** |    **0.00** |      **26 B** |         **-** |          **NA** |
|       IfBitIsSetAddOne |     4 | 0.2436 ns | 0.0384 ns | 0.0299 ns | 0.2404 ns | 0.152 |    0.05 |      11 B |         - |          NA |
|               NoBranch |     4 | 0.0103 ns | 0.0198 ns | 0.0308 ns | 0.0000 ns | 0.006 |    0.02 |      11 B |         - |          NA |
|                        |       |           |           |           |           |       |         |           |           |             |
| **IfModuloTwoIsOneAddOne** |     **5** | **0.2019 ns** | **0.0318 ns** | **0.0249 ns** | **0.2060 ns** |  **1.00** |    **0.00** |      **26 B** |         **-** |          **NA** |
|       IfBitIsSetAddOne |     5 | 0.0189 ns | 0.0240 ns | 0.0277 ns | 0.0000 ns |  0.14 |    0.17 |      11 B |         - |          NA |
|               NoBranch |     5 | 0.0126 ns | 0.0124 ns | 0.0242 ns | 0.0000 ns |  0.07 |    0.16 |      11 B |         - |          NA |
