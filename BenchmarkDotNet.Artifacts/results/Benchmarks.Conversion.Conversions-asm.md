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

