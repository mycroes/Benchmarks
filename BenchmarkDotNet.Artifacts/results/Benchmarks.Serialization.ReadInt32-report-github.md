``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-BNDNOX : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  Job-TYERJG : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  Job-PZOYBW : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
  Job-UZPWQL : .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256


```
|                                          Method |              Runtime |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------------------------------------------ |--------------------- |----------:|----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
|          BinaryPrimitives_ReadInt32LittleEndian |             .NET 6.0 | 0.0255 ns | 0.0213 ns | 0.0325 ns | 0.0106 ns | 0.003 |    0.00 |      49 B |         - |          NA |
|          BinaryPrimitives_ReadInt32LittleEndian |             .NET 7.0 | 0.0044 ns | 0.0106 ns | 0.0109 ns | 0.0000 ns | 0.000 |    0.00 |      50 B |         - |          NA |
|          BinaryPrimitives_ReadInt32LittleEndian | .NET Framework 4.6.2 | 9.4310 ns | 0.2160 ns | 0.2312 ns | 9.4314 ns | 1.000 |    0.00 |     173 B |         - |          NA |
|          BinaryPrimitives_ReadInt32LittleEndian |   .NET Framework 4.8 | 9.6285 ns | 0.2170 ns | 0.2583 ns | 9.5827 ns | 1.023 |    0.03 |     173 B |         - |          NA |
|                                                 |                      |           |           |           |           |       |         |           |           |             |
|      Unsafe_ReadUnaligned_Ref_Buffer_Index_Zero |             .NET 6.0 | 0.2534 ns | 0.0262 ns | 0.0232 ns | 0.2558 ns |  3.03 |    0.99 |      31 B |         - |          NA |
|      Unsafe_ReadUnaligned_Ref_Buffer_Index_Zero |             .NET 7.0 | 0.0324 ns | 0.0237 ns | 0.0434 ns | 0.0167 ns |  0.64 |    0.44 |      28 B |         - |          NA |
|      Unsafe_ReadUnaligned_Ref_Buffer_Index_Zero | .NET Framework 4.6.2 | 0.0910 ns | 0.0290 ns | 0.0271 ns | 0.0968 ns |  1.00 |    0.00 |      31 B |         - |          NA |
|      Unsafe_ReadUnaligned_Ref_Buffer_Index_Zero |   .NET Framework 4.8 | 0.0722 ns | 0.0264 ns | 0.0403 ns | 0.0728 ns |  0.82 |    0.72 |      31 B |         - |          NA |
|                                                 |                      |           |           |           |           |       |         |           |           |             |
| Unsafe_ReadUnaligned_MemoryMarshal_GetReference |             .NET 6.0 | 0.0363 ns | 0.0224 ns | 0.0321 ns | 0.0338 ns | 0.004 |    0.00 |      23 B |         - |          NA |
| Unsafe_ReadUnaligned_MemoryMarshal_GetReference |             .NET 7.0 | 0.0346 ns | 0.0249 ns | 0.0416 ns | 0.0170 ns | 0.006 |    0.01 |      23 B |         - |          NA |
| Unsafe_ReadUnaligned_MemoryMarshal_GetReference | .NET Framework 4.6.2 | 8.1760 ns | 0.1865 ns | 0.2073 ns | 8.1631 ns | 1.000 |    0.00 |     110 B |         - |          NA |
| Unsafe_ReadUnaligned_MemoryMarshal_GetReference |   .NET Framework 4.8 | 8.0730 ns | 0.1760 ns | 0.1883 ns | 8.0839 ns | 0.987 |    0.04 |     110 B |         - |          NA |
