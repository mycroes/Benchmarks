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
|       Method |              Runtime |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------- |--------------------- |----------:|----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| FromExplicit |             .NET 6.0 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |      14 B |         - |           ? |
| FromExplicit |             .NET 7.0 | 0.1243 ns | 0.0330 ns | 0.0969 ns | 0.1042 ns |     ? |       ? |      14 B |         - |           ? |
| FromExplicit | .NET Framework 4.6.2 | 0.0845 ns | 0.0248 ns | 0.0622 ns | 0.0874 ns |     ? |       ? |      14 B |         - |           ? |
| FromExplicit |   .NET Framework 4.8 | 0.0095 ns | 0.0156 ns | 0.0214 ns | 0.0000 ns |     ? |       ? |      14 B |         - |           ? |
|              |                      |           |           |           |           |       |         |           |           |             |
| FromImplicit |             .NET 6.0 | 0.0312 ns | 0.0239 ns | 0.0400 ns | 0.0164 ns |     ? |       ? |      14 B |         - |           ? |
| FromImplicit |             .NET 7.0 | 0.0160 ns | 0.0138 ns | 0.0202 ns | 0.0000 ns |     ? |       ? |      14 B |         - |           ? |
| FromImplicit | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |      14 B |         - |           ? |
| FromImplicit |   .NET Framework 4.8 | 0.0353 ns | 0.0231 ns | 0.0439 ns | 0.0184 ns |     ? |       ? |      14 B |         - |           ? |
|              |                      |           |           |           |           |       |         |           |           |             |
|  FromFactory |             .NET 6.0 | 0.0399 ns | 0.0267 ns | 0.0407 ns | 0.0329 ns |     ? |       ? |      14 B |         - |           ? |
|  FromFactory |             .NET 7.0 | 0.0051 ns | 0.0081 ns | 0.0109 ns | 0.0000 ns |     ? |       ? |      14 B |         - |           ? |
|  FromFactory | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |      14 B |         - |           ? |
|  FromFactory |   .NET Framework 4.8 | 0.0053 ns | 0.0095 ns | 0.0098 ns | 0.0000 ns |     ? |       ? |      14 B |         - |           ? |
