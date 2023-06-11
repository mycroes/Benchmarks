``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-UNEEFO : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  Job-IFWEFP : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-ULUCMY : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
  Job-YUHCIT : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256


```
|           Method |              Runtime |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|----------------- |--------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|----------:|----------:|------------:|
|         WriteInt |             .NET 6.0 |  0.0378 ns | 0.0289 ns | 0.0735 ns |  0.0000 ns | 0.006 |    0.01 |      26 B |         - |          NA |
|       WriteBytes |             .NET 6.0 |  2.2084 ns | 0.0823 ns | 0.0643 ns |  2.2121 ns | 0.171 |    0.01 |     102 B |         - |          NA |
| WriteIntComposed |             .NET 6.0 |  1.0167 ns | 0.0604 ns | 0.0992 ns |  0.9777 ns | 0.081 |    0.01 |     113 B |         - |          NA |
|        WriteLong |             .NET 6.0 |  0.0535 ns | 0.0302 ns | 0.0838 ns |  0.0000 ns | 0.008 |    0.01 |      28 B |         - |          NA |
|         WriteInt |             .NET 7.0 |  0.0063 ns | 0.0130 ns | 0.0231 ns |  0.0000 ns | 0.001 |    0.00 |      26 B |         - |          NA |
|       WriteBytes |             .NET 7.0 |  2.1079 ns | 0.0719 ns | 0.0601 ns |  2.0896 ns | 0.162 |    0.01 |     102 B |         - |          NA |
| WriteIntComposed |             .NET 7.0 |  0.9609 ns | 0.0614 ns | 0.1227 ns |  0.9176 ns | 0.076 |    0.01 |     113 B |         - |          NA |
|        WriteLong |             .NET 7.0 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns | 0.000 |    0.00 |      28 B |         - |          NA |
|         WriteInt | .NET Framework 4.6.2 | 12.9250 ns | 0.3002 ns | 0.3457 ns | 12.8630 ns | 1.000 |    0.00 |     116 B |         - |          NA |
|       WriteBytes | .NET Framework 4.6.2 | 13.7015 ns | 0.3081 ns | 0.6010 ns | 13.6544 ns | 1.063 |    0.06 |     184 B |         - |          NA |
| WriteIntComposed | .NET Framework 4.6.2 | 13.7783 ns | 0.3029 ns | 0.7198 ns | 13.6307 ns | 1.075 |    0.07 |     195 B |         - |          NA |
|        WriteLong | .NET Framework 4.6.2 | 13.1900 ns | 0.2985 ns | 0.6231 ns | 13.0193 ns | 1.011 |    0.05 |     118 B |         - |          NA |
|         WriteInt |   .NET Framework 4.8 | 13.5071 ns | 0.3077 ns | 0.8828 ns | 13.2465 ns | 1.035 |    0.07 |     116 B |         - |          NA |
|       WriteBytes |   .NET Framework 4.8 | 13.6829 ns | 0.3027 ns | 0.5458 ns | 13.6687 ns | 1.063 |    0.06 |     184 B |         - |          NA |
| WriteIntComposed |   .NET Framework 4.8 | 13.7416 ns | 0.3106 ns | 0.6882 ns | 13.5610 ns | 1.082 |    0.07 |     195 B |         - |          NA |
|        WriteLong |   .NET Framework 4.8 | 13.2194 ns | 0.2730 ns | 0.4486 ns | 13.2460 ns | 1.020 |    0.05 |     118 B |         - |          NA |
