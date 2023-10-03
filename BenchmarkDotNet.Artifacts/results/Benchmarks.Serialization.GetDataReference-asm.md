## .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.GetDataReference.MemoryMarshal_Cast_MemoryMarshal_GetReference()
       sub       rsp,28
       mov       rdx,[rcx+8]
       test      rdx,rdx
       jne       short M00_L02
       xor       eax,eax
       xor       ecx,ecx
M00_L00:
       mov       edx,ecx
       shl       rdx,3
       cmp       rdx,7FFFFFFF
       ja        short M00_L01
       add       rsp,28
       ret
M00_L01:
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       lea       rax,[rdx+10]
       mov       ecx,[rdx+8]
       jmp       short M00_L00
; Total bytes of code 51
```

## .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.GetDataReference.Unsafe_As_Ref_Index_0()
       sub       rsp,28
       mov       rax,[rcx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M00_L00
       add       rax,10
       add       rsp,28
       ret
M00_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 29
```

## .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.GetDataReference.Unsafe_As_MemoryMarshal_GetReference()
       mov       rax,[rcx+8]
       test      rax,rax
       je        short M00_L01
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       rax,rdx
       ret
M00_L01:
       xor       edx,edx
       jmp       short M00_L00
; Total bytes of code 24
```

## .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.GetDataReference.Unsafe_As_MemoryMarshal_GetArrayDataReference()
       mov       rax,[rcx+8]
       cmp       [rax],al
       add       rax,10
       ret
; Total bytes of code 11
```

