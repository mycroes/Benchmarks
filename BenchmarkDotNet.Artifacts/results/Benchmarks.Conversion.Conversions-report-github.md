``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.102
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|       Method |      Mean |     Error |    StdDev |    Median | Code Size | Completed Work Items | Lock Contentions | Allocated |
|------------- |----------:|----------:|----------:|----------:|----------:|---------------------:|-----------------:|----------:|
| FromExplicit | 0.0211 ns | 0.0254 ns | 0.0282 ns | 0.0058 ns |      14 B |                    - |                - |         - |
| FromImplicit | 0.0493 ns | 0.0195 ns | 0.0182 ns | 0.0457 ns |      14 B |                    - |                - |         - |
|  FromFactory | 0.0221 ns | 0.0176 ns | 0.0138 ns | 0.0251 ns |      14 B |                    - |                - |         - |
