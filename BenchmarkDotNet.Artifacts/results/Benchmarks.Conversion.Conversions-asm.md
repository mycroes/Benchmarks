## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Conversion.Conversions.FromExplicit()
       add       rcx,8
       movzx     eax,byte ptr [rcx]
       movzx     edx,byte ptr [rcx+1]
       add       eax,edx
       ret
; Total bytes of code 14
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Conversion.Conversions.FromExplicit()
       add       rcx,8
       movzx     eax,byte ptr [rcx]
       movzx     edx,byte ptr [rcx+1]
       add       eax,edx
       ret
; Total bytes of code 14
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Conversion.Conversions.FromExplicit()
       lea       rax,[rcx+8]
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+1]
       add       eax,edx
       ret
; Total bytes of code 14
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Conversion.Conversions.FromExplicit()
       lea       rax,[rcx+8]
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+1]
       add       eax,edx
       ret
; Total bytes of code 14
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Conversion.Conversions.FromImplicit()
       add       rcx,10
       movzx     eax,byte ptr [rcx]
       movzx     edx,byte ptr [rcx+1]
       add       eax,edx
       ret
; Total bytes of code 14
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Conversion.Conversions.FromImplicit()
       add       rcx,0A
       movzx     eax,byte ptr [rcx]
       movzx     edx,byte ptr [rcx+1]
       add       eax,edx
       ret
; Total bytes of code 14
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Conversion.Conversions.FromImplicit()
       lea       rax,[rcx+10]
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+1]
       add       eax,edx
       ret
; Total bytes of code 14
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Conversion.Conversions.FromImplicit()
       lea       rax,[rcx+10]
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+1]
       add       eax,edx
       ret
; Total bytes of code 14
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Conversion.Conversions.FromFactory()
       add       rcx,18
       movzx     eax,byte ptr [rcx]
       movzx     edx,byte ptr [rcx+1]
       add       eax,edx
       ret
; Total bytes of code 14
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Conversion.Conversions.FromFactory()
       add       rcx,0C
       movzx     eax,byte ptr [rcx]
       movzx     edx,byte ptr [rcx+1]
       add       eax,edx
       ret
; Total bytes of code 14
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Conversion.Conversions.FromFactory()
       lea       rax,[rcx+18]
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+1]
       add       eax,edx
       ret
; Total bytes of code 14
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Conversion.Conversions.FromFactory()
       lea       rax,[rcx+18]
       movzx     edx,byte ptr [rax]
       movzx     eax,byte ptr [rax+1]
       add       eax,edx
       ret
; Total bytes of code 14
```

