## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.WriteInt32.BinaryPrimitives_WriteInt32LittleEndian()
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M00_L00
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M00_L01:
       mov       rax,[rcx+10]
       test      rax,rax
       jne       short M00_L02
       xor       ecx,ecx
       xor       r9d,r9d
       jmp       short M00_L03
M00_L02:
       lea       rcx,[rax+10]
       mov       r9d,[rax+8]
M00_L03:
       xor       eax,eax
M00_L04:
       mov       r10d,eax
       shl       r10d,2
       cmp       r10d,r9d
       ja        short M00_L05
       mov       r11d,r9d
       sub       r11d,r10d
       mov       r10d,r10d
       add       r10,rcx
       cmp       eax,r8d
       jae       short M00_L07
       movsxd    rsi,eax
       mov       esi,[rdx+rsi*4]
       cmp       r11d,4
       jb        short M00_L06
       mov       [r10],esi
       inc       eax
       cmp       eax,2710
       jl        short M00_L04
       add       rsp,20
       pop       rsi
       ret
M00_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L06:
       mov       ecx,29
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 137
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.WriteInt32.BinaryPrimitives_WriteInt32LittleEndian()
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+8]
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M00_L06
       lea       r8,[rcx+10]
       mov       ecx,[rcx+8]
M00_L01:
       xor       r9d,r9d
M00_L02:
       mov       r10d,r9d
       shl       r10d,2
       cmp       r10d,ecx
       ja        short M00_L03
       mov       r11d,r10d
       add       r11,r8
       mov       esi,ecx
       sub       esi,r10d
       cmp       r9d,eax
       jae       short M00_L07
       mov       r10d,r9d
       mov       r10d,[rdx+r10*4]
       cmp       esi,4
       jb        short M00_L04
       mov       [r11],r10d
       inc       r9d
       cmp       r9d,2710
       jl        short M00_L02
       add       rsp,20
       pop       rsi
       ret
M00_L03:
       call      qword ptr [7FF954347498]
       int       3
M00_L04:
       mov       ecx,29
       call      qword ptr [7FF9543477E0]
       int       3
M00_L05:
       xor       edx,edx
       xor       eax,eax
       jmp       short M00_L00
M00_L06:
       xor       r8d,r8d
       xor       ecx,ecx
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 139
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.WriteInt32.BinaryPrimitives_WriteInt32LittleEndian()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdx,[rcx+8]
       test      rdx,rdx
       jne       short M00_L00
       xor       edx,edx
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       mov       r8d,[rdx+8]
       mov       eax,8
M00_L01:
       mov       rsi,rdx
       mov       rdi,rax
       mov       ebx,r8d
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L02
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
       jmp       short M00_L03
M00_L02:
       mov       eax,[rcx+8]
       mov       edx,8
M00_L03:
       mov       rbp,rcx
       mov       r14,rdx
       mov       r15d,eax
       xor       r12d,r12d
M00_L04:
       mov       ecx,r12d
       shl       ecx,2
       cmp       ecx,r15d
       ja        near ptr M00_L08
       movsxd    rdx,ecx
       add       rdx,r14
       mov       eax,r15d
       sub       eax,ecx
       mov       ecx,eax
       mov       eax,ecx
       mov       ecx,eax
       cmp       r12d,ebx
       jae       near ptr M00_L09
       test      rsi,rsi
       jne       short M00_L05
       mov       rax,rdi
       movsxd    r8,r12d
       lea       rax,[rax+r8*4]
       jmp       short M00_L06
M00_L05:
       lea       rax,[rsi+8]
       add       rax,rdi
       movsxd    r8,r12d
       lea       rax,[rax+r8*4]
M00_L06:
       mov       r13,rdx
       mov       [rsp+40],ecx
       mov       eax,[rax]
       mov       [rsp+44],eax
       mov       ecx,1
       mov       edx,0B0
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FF9EBDF3DCD],0
       jne       short M00_L07
       mov       eax,[rsp+44]
       mov       ecx,eax
       and       ecx,0FF00FF
       and       eax,0FF00FF00
       rol       ecx,18
       rol       eax,8
       add       eax,ecx
       mov       [rsp+44],eax
M00_L07:
       mov       rdx,r13
       mov       r13d,[rsp+40]
       mov       ecx,r13d
       cmp       ecx,4
       jb        short M00_L10
       lea       r8,[rsp+28]
       mov       [r8],rbp
       mov       [r8+8],rdx
       mov       [r8+10],ecx
       lea       rcx,[rsp+28]
       call      System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       r13d,[rsp+44]
       mov       [rax],r13d
       inc       r12d
       cmp       r12d,2710
       jl        near ptr M00_L04
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       mov       ecx,1
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L09:
       call      System.ThrowHelper.ThrowIndexOutOfRangeException()
       int       3
M00_L10:
       xor       ecx,ecx
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 355
```
```assembly
; System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       rdx,[rcx]
       mov       rcx,[rcx+8]
       test      rdx,rdx
       jne       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       lea       rax,[rdx+8]
       add       rax,rcx
       ret
; Total bytes of code 24
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.WriteInt32.BinaryPrimitives_WriteInt32LittleEndian()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdx,[rcx+8]
       test      rdx,rdx
       jne       short M00_L00
       xor       edx,edx
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       mov       r8d,[rdx+8]
       mov       eax,8
M00_L01:
       mov       rsi,rdx
       mov       rdi,rax
       mov       ebx,r8d
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L02
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
       jmp       short M00_L03
M00_L02:
       mov       eax,[rcx+8]
       mov       edx,8
M00_L03:
       mov       rbp,rcx
       mov       r14,rdx
       mov       r15d,eax
       xor       r12d,r12d
M00_L04:
       mov       ecx,r12d
       shl       ecx,2
       cmp       ecx,r15d
       ja        near ptr M00_L08
       movsxd    rdx,ecx
       add       rdx,r14
       mov       eax,r15d
       sub       eax,ecx
       mov       ecx,eax
       mov       eax,ecx
       mov       ecx,eax
       cmp       r12d,ebx
       jae       near ptr M00_L09
       test      rsi,rsi
       jne       short M00_L05
       mov       rax,rdi
       movsxd    r8,r12d
       lea       rax,[rax+r8*4]
       jmp       short M00_L06
M00_L05:
       lea       rax,[rsi+8]
       add       rax,rdi
       movsxd    r8,r12d
       lea       rax,[rax+r8*4]
M00_L06:
       mov       r13,rdx
       mov       [rsp+40],ecx
       mov       eax,[rax]
       mov       [rsp+44],eax
       mov       ecx,1
       mov       edx,0B0
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FF9EBDF3DCD],0
       jne       short M00_L07
       mov       eax,[rsp+44]
       mov       ecx,eax
       and       ecx,0FF00FF
       and       eax,0FF00FF00
       rol       ecx,18
       rol       eax,8
       add       eax,ecx
       mov       [rsp+44],eax
M00_L07:
       mov       rdx,r13
       mov       r13d,[rsp+40]
       mov       ecx,r13d
       cmp       ecx,4
       jb        short M00_L10
       lea       r8,[rsp+28]
       mov       [r8],rbp
       mov       [r8+8],rdx
       mov       [r8+10],ecx
       lea       rcx,[rsp+28]
       call      System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       r13d,[rsp+44]
       mov       [rax],r13d
       inc       r12d
       cmp       r12d,2710
       jl        near ptr M00_L04
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       mov       ecx,1
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L09:
       call      System.ThrowHelper.ThrowIndexOutOfRangeException()
       int       3
M00_L10:
       xor       ecx,ecx
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 355
```
```assembly
; System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       rdx,[rcx]
       mov       rcx,[rcx+8]
       test      rdx,rdx
       jne       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       lea       rax,[rdx+8]
       add       rax,rcx
       ret
; Total bytes of code 24
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.WriteInt32.Unsafe_WriteUnaligned()
       sub       rsp,28
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M00_L00
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M00_L01:
       mov       rax,[rcx+10]
       test      rax,rax
       jne       short M00_L02
       xor       ecx,ecx
       jmp       short M00_L03
M00_L02:
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M00_L03:
       xor       eax,eax
M00_L04:
       cmp       eax,r8d
       jae       short M00_L05
       movsxd    r9,eax
       mov       r9d,[rdx+r9*4]
       mov       r10d,eax
       shl       r10d,2
       movsxd    r10,r10d
       mov       [rcx+r10],r9d
       inc       eax
       cmp       eax,2710
       jl        short M00_L04
       add       rsp,28
       ret
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 96
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.WriteInt32.Unsafe_WriteUnaligned()
       sub       rsp,28
       mov       rax,[rcx+8]
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M00_L04
       lea       r8,[rcx+10]
       mov       ecx,[rcx+8]
M00_L01:
       xor       ecx,ecx
M00_L02:
       cmp       ecx,eax
       jae       short M00_L05
       mov       r9d,ecx
       mov       r9d,[rdx+r9*4]
       mov       r10d,ecx
       shl       r10d,2
       movsxd    r10,r10d
       mov       [r8+r10],r9d
       inc       ecx
       cmp       ecx,2710
       jl        short M00_L02
       add       rsp,28
       ret
M00_L03:
       xor       edx,edx
       xor       eax,eax
       jmp       short M00_L00
M00_L04:
       xor       r8d,r8d
       jmp       short M00_L01
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 95
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.WriteInt32.Unsafe_WriteUnaligned()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M00_L00
       xor       eax,eax
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       mov       r8d,[rax+8]
       mov       edx,8
M00_L01:
       mov       rsi,rax
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L02
       xor       ecx,ecx
       xor       eax,eax
       xor       edx,edx
       jmp       short M00_L03
M00_L02:
       mov       edx,[rcx+8]
       mov       eax,8
M00_L03:
       lea       r8,[rsp+28]
       mov       [r8],rcx
       mov       [r8+8],rax
       mov       [r8+10],edx
       lea       rcx,[rsp+28]
       call      System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       xor       edx,edx
M00_L04:
       mov       ecx,edx
       shl       ecx,2
       movsxd    rcx,ecx
       add       rcx,rax
       cmp       edx,ebx
       jae       short M00_L07
       test      rsi,rsi
       jne       short M00_L05
       mov       r8,rdi
       movsxd    r9,edx
       lea       r8,[r8+r9*4]
       jmp       short M00_L06
M00_L05:
       lea       r8,[rsi+8]
       add       r8,rdi
       movsxd    r9,edx
       lea       r8,[r8+r9*4]
M00_L06:
       mov       r8d,[r8]
       mov       [rcx],r8d
       inc       edx
       cmp       edx,2710
       jl        short M00_L04
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      System.ThrowHelper.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 192
```
```assembly
; System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       rdx,[rcx]
       mov       rcx,[rcx+8]
       test      rdx,rdx
       jne       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       lea       rax,[rdx+8]
       add       rax,rcx
       ret
; Total bytes of code 24
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowIndexOutOfRangeException()

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.WriteInt32.Unsafe_WriteUnaligned()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M00_L00
       xor       eax,eax
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       mov       r8d,[rax+8]
       mov       edx,8
M00_L01:
       mov       rsi,rax
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L02
       xor       ecx,ecx
       xor       eax,eax
       xor       edx,edx
       jmp       short M00_L03
M00_L02:
       mov       edx,[rcx+8]
       mov       eax,8
M00_L03:
       lea       r8,[rsp+28]
       mov       [r8],rcx
       mov       [r8+8],rax
       mov       [r8+10],edx
       lea       rcx,[rsp+28]
       call      System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       xor       edx,edx
M00_L04:
       mov       ecx,edx
       shl       ecx,2
       movsxd    rcx,ecx
       add       rcx,rax
       cmp       edx,ebx
       jae       short M00_L07
       test      rsi,rsi
       jne       short M00_L05
       mov       r8,rdi
       movsxd    r9,edx
       lea       r8,[r8+r9*4]
       jmp       short M00_L06
M00_L05:
       lea       r8,[rsi+8]
       add       r8,rdi
       movsxd    r9,edx
       lea       r8,[r8+r9*4]
M00_L06:
       mov       r8d,[r8]
       mov       [rcx],r8d
       inc       edx
       cmp       edx,2710
       jl        short M00_L04
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      System.ThrowHelper.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 192
```
```assembly
; System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       rdx,[rcx]
       mov       rcx,[rcx+8]
       test      rdx,rdx
       jne       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       lea       rax,[rdx+8]
       add       rax,rcx
       ret
; Total bytes of code 24
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowIndexOutOfRangeException()

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.WriteInt32.MemoryMarshal_Cast_And_CopyTo()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdx,[rcx+8]
       test      rdx,rdx
       jne       short M00_L00
       xor       esi,esi
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       lea       rsi,[rdx+10]
       mov       r8d,[rdx+8]
M00_L01:
       mov       edx,r8d
       shl       rdx,2
       cmp       rdx,7FFFFFFF
       ja        short M00_L05
       mov       edi,edx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L02
       xor       ebx,ebx
       xor       ebp,ebp
       jmp       short M00_L03
M00_L02:
       lea       rbx,[rcx+10]
       mov       ebp,[rcx+8]
M00_L03:
       xor       r14d,r14d
M00_L04:
       mov       ecx,r14d
       shl       ecx,2
       mov       edx,ecx
       lea       r8,[rdx+4]
       mov       eax,edi
       cmp       r8,rax
       ja        short M00_L06
       lea       r8,[rdx+rsi]
       cmp       ecx,ebp
       ja        short M00_L06
       mov       eax,ebp
       sub       eax,ecx
       add       rdx,rbx
       mov       rcx,rdx
       cmp       eax,4
       jb        short M00_L07
       mov       rdx,r8
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r14d
       cmp       r14d,2710
       jl        short M00_L04
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       call      CORINFO_HELP_OVERFLOW
M00_L06:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L07:
       call      System.ThrowHelper.ThrowArgumentException_DestinationTooShort()
       int       3
; Total bytes of code 173
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L10
       lea       rax,[r8+rdx]
       lea       r9,[r8+rcx]
       cmp       r8,10
       jbe       short M01_L03
       cmp       r8,40
       ja        short M01_L04
M01_L00:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L01
       lea       r10,[rcx+10]
       vmovupd   xmm0,[rdx+10]
       vmovupd   [r10],xmm0
       cmp       r8,30
       ja        near ptr M01_L08
M01_L01:
       add       r9,0FFFFFFFFFFFFFFF0
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9],xmm0
M01_L02:
       ret
M01_L03:
       test      r8b,18
       jne       near ptr M01_L07
       test      r8b,4
       jne       near ptr M01_L06
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       lea       r8,[r9-2]
       movsx     rcx,word ptr [rax-2]
       mov       [r8],cx
       jmp       short M01_L02
M01_L04:
       cmp       r8,800
       ja        near ptr M01_L11
       mov       r10,r8
       shr       r10,6
M01_L05:
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmm0,xmmword ptr [rdx+10]
       vmovdqu   xmmword ptr [rcx+10],xmm0
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rcx+20],xmm0
       vmovdqu   xmm0,xmmword ptr [rdx+30]
       vmovdqu   xmmword ptr [rcx+30],xmm0
       add       rcx,40
       add       rdx,40
       dec       r10
       jne       short M01_L05
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L00
       jmp       short M01_L09
M01_L06:
       mov       edx,[rdx]
       mov       [rcx],edx
       lea       rcx,[r9-4]
       mov       r9d,[rax-4]
       mov       [rcx],r9d
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       lea       rcx,[r9-8]
       mov       r9,[rax-8]
       mov       [rcx],r9
       jmp       near ptr M01_L02
M01_L08:
       add       rcx,20
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx],xmm0
       jmp       near ptr M01_L01
M01_L09:
       lea       rdx,[r9-10]
       vmovupd   xmm0,[rax-10]
       vmovupd   [rdx],xmm0
       jmp       near ptr M01_L02
M01_L10:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L11:
       jmp       near ptr System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 336
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.WriteInt32.MemoryMarshal_Cast_And_CopyTo()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L04
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
M00_L00:
       mov       edx,edi
       shl       rdx,2
       cmp       rdx,7FFFFFFF
       ja        short M00_L03
       mov       edi,edx
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M00_L05
       lea       rbx,[rcx+10]
       mov       ebp,[rcx+8]
M00_L01:
       xor       r14d,r14d
M00_L02:
       mov       ecx,r14d
       shl       ecx,2
       mov       edx,ecx
       lea       r8,[rdx+4]
       mov       eax,edi
       cmp       r8,rax
       ja        short M00_L06
       lea       r8,[rsi+rdx]
       cmp       ecx,ebp
       ja        short M00_L06
       add       rdx,rbx
       mov       eax,ebp
       sub       eax,ecx
       mov       rcx,rdx
       cmp       eax,4
       jb        short M00_L07
       mov       rdx,r8
       mov       r8d,4
       call      qword ptr [7FF9541E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r14d
       cmp       r14d,2710
       jl        short M00_L02
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       call      CORINFO_HELP_OVERFLOW
M00_L04:
       xor       esi,esi
       xor       edi,edi
       jmp       short M00_L00
M00_L05:
       xor       ebx,ebx
       xor       ebp,ebp
       jmp       short M00_L01
M00_L06:
       call      qword ptr [7FF954367498]
       int       3
M00_L07:
       call      qword ptr [7FF9543674B0]
       int       3
; Total bytes of code 177
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FF9541E9A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.WriteInt32.MemoryMarshal_Cast_And_CopyTo()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,18
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       test      rcx,rcx
       jne       short M00_L00
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
       jmp       short M00_L01
M00_L00:
       mov       eax,[rcx+8]
       mov       edx,8
M00_L01:
       lea       r8,[rsp+70]
       lea       r9,[rsp+40]
       mov       [r9],rcx
       mov       [r9+8],rdx
       mov       [r9+10],eax
       mov       rcx,r8
       lea       rdx,[rsp+40]
       call      System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Int32, mscorlib],[System.Byte, mscorlib]](System.Span`1<Int32>)
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       short M00_L02
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
       jmp       short M00_L03
M00_L02:
       mov       eax,[rcx+8]
       mov       edx,8
M00_L03:
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,eax
       xor       ebp,ebp
M00_L04:
       mov       ecx,ebp
       shl       ecx,2
       cmp       ecx,[rsp+80]
       ja        near ptr M00_L05
       mov       edx,[rsp+80]
       sub       edx,ecx
       cmp       edx,4
       jb        near ptr M00_L05
       mov       rdx,[rsp+78]
       movsxd    rcx,ecx
       add       rcx,rdx
       mov       rdx,[rsp+70]
       mov       eax,4
       mov       [rsp+58],rdx
       mov       [rsp+60],rcx
       mov       [rsp+68],eax
       mov       ecx,ebp
       shl       ecx,2
       cmp       ecx,ebx
       ja        short M00_L06
       movsxd    rdx,ecx
       add       rdx,rdi
       mov       eax,ebx
       sub       eax,ecx
       mov       ecx,eax
       mov       eax,ecx
       mov       ecx,eax
       lea       rax,[rsp+58]
       lea       r8,[rsp+28]
       mov       [r8],rsi
       mov       [r8+8],rdx
       mov       [r8+10],ecx
       mov       rcx,rax
       lea       rdx,[rsp+28]
       call      System.Span`1[[System.Byte, mscorlib]].TryCopyTo(System.Span`1<Byte>)
       test      al,al
       je        short M00_L07
       inc       ebp
       cmp       ebp,2710
       jl        near ptr M00_L04
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       ecx,1
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L06:
       mov       ecx,1
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L07:
       call      System.ThrowHelper.ThrowArgumentException_DestinationTooShort()
       int       3
; Total bytes of code 316
```
```assembly
; System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Int32, mscorlib],[System.Byte, mscorlib]](System.Span`1<Int32>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rdx+10]
       movsxd    rcx,ecx
       imul      rcx,4
       jo        short M01_L00
       cmp       rcx,7FFFFFFF
       jg        short M01_L00
       cmp       rcx,0FFFFFFFF80000000
       jl        short M01_L00
       mov       rdi,rcx
       mov       rax,[rdx]
       mov       rbx,[rdx+8]
       lea       rcx,[rsi]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rsi+8],rbx
       mov       [rsi+10],edi
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 85
```
```assembly
; System.Span`1[[System.Byte, mscorlib]].TryCopyTo(System.Span`1<Byte>)
       sub       rsp,28
       mov       r8,[rdx]
       mov       r9,[rdx+8]
       mov       edx,[rdx+10]
       mov       r10d,[rcx+10]
       test      r10d,r10d
       jne       short M02_L00
       mov       eax,1
       add       rsp,28
       ret
M02_L00:
       cmp       r10d,edx
       jbe       short M02_L01
       xor       eax,eax
       add       rsp,28
       ret
M02_L01:
       mov       rax,[rcx]
       test      rax,rax
       jne       short M02_L02
       mov       rax,[rcx+8]
       mov       rcx,rax
       mov       rax,rcx
       mov       rcx,rax
       mov       rax,rcx
       jmp       short M02_L03
M02_L02:
       cmp       [rax],eax
       add       rax,8
       mov       rcx,[rcx+8]
       add       rax,rcx
M02_L03:
       test      r8,r8
       jne       short M02_L04
       mov       rcx,r9
       mov       r9,rcx
       mov       rcx,r9
       jmp       short M02_L05
M02_L04:
       lea       rcx,[r8+8]
       add       rcx,r9
M02_L05:
       mov       r8,rax
       mov       r9d,r10d
       call      System.SpanHelpers.CopyTo[[System.Byte, mscorlib]](Byte ByRef, Int32, Byte ByRef, Int32)
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 128
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.WriteInt32.MemoryMarshal_Cast_And_CopyTo()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,18
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       test      rcx,rcx
       jne       short M00_L00
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
       jmp       short M00_L01
M00_L00:
       mov       eax,[rcx+8]
       mov       edx,8
M00_L01:
       lea       r8,[rsp+70]
       lea       r9,[rsp+40]
       mov       [r9],rcx
       mov       [r9+8],rdx
       mov       [r9+10],eax
       mov       rcx,r8
       lea       rdx,[rsp+40]
       call      System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Int32, mscorlib],[System.Byte, mscorlib]](System.Span`1<Int32>)
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       short M00_L02
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
       jmp       short M00_L03
M00_L02:
       mov       eax,[rcx+8]
       mov       edx,8
M00_L03:
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,eax
       xor       ebp,ebp
M00_L04:
       mov       ecx,ebp
       shl       ecx,2
       cmp       ecx,[rsp+80]
       ja        near ptr M00_L05
       mov       edx,[rsp+80]
       sub       edx,ecx
       cmp       edx,4
       jb        near ptr M00_L05
       mov       rdx,[rsp+78]
       movsxd    rcx,ecx
       add       rcx,rdx
       mov       rdx,[rsp+70]
       mov       eax,4
       mov       [rsp+58],rdx
       mov       [rsp+60],rcx
       mov       [rsp+68],eax
       mov       ecx,ebp
       shl       ecx,2
       cmp       ecx,ebx
       ja        short M00_L06
       movsxd    rdx,ecx
       add       rdx,rdi
       mov       eax,ebx
       sub       eax,ecx
       mov       ecx,eax
       mov       eax,ecx
       mov       ecx,eax
       lea       rax,[rsp+58]
       lea       r8,[rsp+28]
       mov       [r8],rsi
       mov       [r8+8],rdx
       mov       [r8+10],ecx
       mov       rcx,rax
       lea       rdx,[rsp+28]
       call      System.Span`1[[System.Byte, mscorlib]].TryCopyTo(System.Span`1<Byte>)
       test      al,al
       je        short M00_L07
       inc       ebp
       cmp       ebp,2710
       jl        near ptr M00_L04
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       ecx,1
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L06:
       mov       ecx,1
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L07:
       call      System.ThrowHelper.ThrowArgumentException_DestinationTooShort()
       int       3
; Total bytes of code 316
```
```assembly
; System.Runtime.InteropServices.MemoryMarshal.Cast[[System.Int32, mscorlib],[System.Byte, mscorlib]](System.Span`1<Int32>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rdx+10]
       movsxd    rcx,ecx
       imul      rcx,4
       jo        short M01_L00
       cmp       rcx,7FFFFFFF
       jg        short M01_L00
       cmp       rcx,0FFFFFFFF80000000
       jl        short M01_L00
       mov       rdi,rcx
       mov       rax,[rdx]
       mov       rbx,[rdx+8]
       lea       rcx,[rsi]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rsi+8],rbx
       mov       [rsi+10],edi
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 85
```
```assembly
; System.Span`1[[System.Byte, mscorlib]].TryCopyTo(System.Span`1<Byte>)
       sub       rsp,28
       mov       r8,[rdx]
       mov       r9,[rdx+8]
       mov       edx,[rdx+10]
       mov       r10d,[rcx+10]
       test      r10d,r10d
       jne       short M02_L00
       mov       eax,1
       add       rsp,28
       ret
M02_L00:
       cmp       r10d,edx
       jbe       short M02_L01
       xor       eax,eax
       add       rsp,28
       ret
M02_L01:
       mov       rax,[rcx]
       test      rax,rax
       jne       short M02_L02
       mov       rax,[rcx+8]
       mov       rcx,rax
       mov       rax,rcx
       mov       rcx,rax
       mov       rax,rcx
       jmp       short M02_L03
M02_L02:
       cmp       [rax],eax
       add       rax,8
       mov       rcx,[rcx+8]
       add       rax,rcx
M02_L03:
       test      r8,r8
       jne       short M02_L04
       mov       rcx,r9
       mov       r9,rcx
       mov       rcx,r9
       jmp       short M02_L05
M02_L04:
       lea       rcx,[r8+8]
       add       rcx,r9
M02_L05:
       mov       r8,rax
       mov       r9d,r10d
       call      System.SpanHelpers.CopyTo[[System.Byte, mscorlib]](Byte ByRef, Int32, Byte ByRef, Int32)
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 128
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.WriteInt32.BinaryPrimitives_WriteInt32BigEndian()
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M00_L00
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M00_L01:
       mov       rax,[rcx+10]
       test      rax,rax
       jne       short M00_L02
       xor       ecx,ecx
       xor       r9d,r9d
       jmp       short M00_L03
M00_L02:
       lea       rcx,[rax+10]
       mov       r9d,[rax+8]
M00_L03:
       xor       eax,eax
M00_L04:
       mov       r10d,eax
       shl       r10d,2
       cmp       r10d,r9d
       ja        short M00_L05
       mov       r11d,r9d
       sub       r11d,r10d
       mov       r10d,r10d
       add       r10,rcx
       cmp       eax,r8d
       jae       short M00_L07
       movsxd    rsi,eax
       mov       esi,[rdx+rsi*4]
       bswap     esi
       cmp       r11d,4
       jb        short M00_L06
       mov       [r10],esi
       inc       eax
       cmp       eax,2710
       jl        short M00_L04
       add       rsp,20
       pop       rsi
       ret
M00_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L06:
       mov       ecx,29
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 139
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.WriteInt32.BinaryPrimitives_WriteInt32BigEndian()
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+8]
       test      rax,rax
       je        short M00_L05
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M00_L06
       lea       r8,[rcx+10]
       mov       ecx,[rcx+8]
M00_L01:
       xor       r9d,r9d
       nop       dword ptr [rax+rax]
M00_L02:
       mov       r10d,r9d
       shl       r10d,2
       cmp       r10d,ecx
       ja        short M00_L03
       mov       r11d,r10d
       add       r11,r8
       mov       esi,ecx
       sub       esi,r10d
       cmp       r9d,eax
       jae       short M00_L07
       mov       r10d,r9d
       movbe     r10d,[rdx+r10*4]
       cmp       esi,4
       jb        short M00_L04
       mov       [r11],r10d
       inc       r9d
       cmp       r9d,2710
       jl        short M00_L02
       add       rsp,20
       pop       rsi
       ret
M00_L03:
       call      qword ptr [7FF954347498]
       int       3
M00_L04:
       mov       ecx,29
       call      qword ptr [7FF9543477E0]
       int       3
M00_L05:
       xor       edx,edx
       xor       eax,eax
       jmp       short M00_L00
M00_L06:
       xor       r8d,r8d
       xor       ecx,ecx
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 149
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.WriteInt32.BinaryPrimitives_WriteInt32BigEndian()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdx,[rcx+8]
       test      rdx,rdx
       jne       short M00_L00
       xor       edx,edx
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       mov       r8d,[rdx+8]
       mov       eax,8
M00_L01:
       mov       rsi,rdx
       mov       rdi,rax
       mov       ebx,r8d
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L02
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
       jmp       short M00_L03
M00_L02:
       mov       eax,[rcx+8]
       mov       edx,8
M00_L03:
       mov       rbp,rcx
       mov       r14,rdx
       mov       r15d,eax
       xor       r12d,r12d
M00_L04:
       mov       ecx,r12d
       shl       ecx,2
       cmp       ecx,r15d
       ja        near ptr M00_L08
       movsxd    rdx,ecx
       add       rdx,r14
       mov       eax,r15d
       sub       eax,ecx
       mov       ecx,eax
       mov       eax,ecx
       mov       ecx,eax
       cmp       r12d,ebx
       jae       near ptr M00_L09
       test      rsi,rsi
       jne       short M00_L05
       mov       rax,rdi
       movsxd    r8,r12d
       lea       rax,[rax+r8*4]
       jmp       short M00_L06
M00_L05:
       lea       rax,[rsi+8]
       add       rax,rdi
       movsxd    r8,r12d
       lea       rax,[rax+r8*4]
M00_L06:
       mov       r13,rdx
       mov       [rsp+40],ecx
       mov       eax,[rax]
       mov       [rsp+44],eax
       mov       ecx,1
       mov       edx,0B0
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FF9EBE23DCD],0
       je        short M00_L07
       mov       eax,[rsp+44]
       mov       ecx,eax
       and       ecx,0FF00FF
       and       eax,0FF00FF00
       rol       ecx,18
       rol       eax,8
       add       eax,ecx
       mov       [rsp+44],eax
M00_L07:
       mov       rdx,r13
       mov       r13d,[rsp+40]
       mov       ecx,r13d
       cmp       ecx,4
       jb        short M00_L10
       lea       r8,[rsp+28]
       mov       [r8],rbp
       mov       [r8+8],rdx
       mov       [r8+10],ecx
       lea       rcx,[rsp+28]
       call      System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       r13d,[rsp+44]
       mov       [rax],r13d
       inc       r12d
       cmp       r12d,2710
       jl        near ptr M00_L04
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       mov       ecx,1
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L09:
       call      System.ThrowHelper.ThrowIndexOutOfRangeException()
       int       3
M00_L10:
       xor       ecx,ecx
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 355
```
```assembly
; System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       rdx,[rcx]
       mov       rcx,[rcx+8]
       test      rdx,rdx
       jne       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       lea       rax,[rdx+8]
       add       rax,rcx
       ret
; Total bytes of code 24
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.WriteInt32.BinaryPrimitives_WriteInt32BigEndian()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdx,[rcx+8]
       test      rdx,rdx
       jne       short M00_L00
       xor       edx,edx
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       mov       r8d,[rdx+8]
       mov       eax,8
M00_L01:
       mov       rsi,rdx
       mov       rdi,rax
       mov       ebx,r8d
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L02
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
       jmp       short M00_L03
M00_L02:
       mov       eax,[rcx+8]
       mov       edx,8
M00_L03:
       mov       rbp,rcx
       mov       r14,rdx
       mov       r15d,eax
       xor       r12d,r12d
M00_L04:
       mov       ecx,r12d
       shl       ecx,2
       cmp       ecx,r15d
       ja        near ptr M00_L08
       movsxd    rdx,ecx
       add       rdx,r14
       mov       eax,r15d
       sub       eax,ecx
       mov       ecx,eax
       mov       eax,ecx
       mov       ecx,eax
       cmp       r12d,ebx
       jae       near ptr M00_L09
       test      rsi,rsi
       jne       short M00_L05
       mov       rax,rdi
       movsxd    r8,r12d
       lea       rax,[rax+r8*4]
       jmp       short M00_L06
M00_L05:
       lea       rax,[rsi+8]
       add       rax,rdi
       movsxd    r8,r12d
       lea       rax,[rax+r8*4]
M00_L06:
       mov       r13,rdx
       mov       [rsp+40],ecx
       mov       eax,[rax]
       mov       [rsp+44],eax
       mov       ecx,1
       mov       edx,0B0
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FF9EBE13DCD],0
       je        short M00_L07
       mov       eax,[rsp+44]
       mov       ecx,eax
       and       ecx,0FF00FF
       and       eax,0FF00FF00
       rol       ecx,18
       rol       eax,8
       add       eax,ecx
       mov       [rsp+44],eax
M00_L07:
       mov       rdx,r13
       mov       r13d,[rsp+40]
       mov       ecx,r13d
       cmp       ecx,4
       jb        short M00_L10
       lea       r8,[rsp+28]
       mov       [r8],rbp
       mov       [r8+8],rdx
       mov       [r8+10],ecx
       lea       rcx,[rsp+28]
       call      System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       r13d,[rsp+44]
       mov       [rax],r13d
       inc       r12d
       cmp       r12d,2710
       jl        near ptr M00_L04
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       mov       ecx,1
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L09:
       call      System.ThrowHelper.ThrowIndexOutOfRangeException()
       int       3
M00_L10:
       xor       ecx,ecx
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 355
```
```assembly
; System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       rdx,[rcx]
       mov       rcx,[rcx+8]
       test      rdx,rdx
       jne       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       lea       rax,[rdx+8]
       add       rax,rcx
       ret
; Total bytes of code 24
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.WriteInt32.Unsafe_WriteUnaligned_With_BinaryPrimitives_ReverseEndianness()
       sub       rsp,28
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M00_L00
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M00_L01:
       mov       rax,[rcx+10]
       test      rax,rax
       jne       short M00_L02
       xor       ecx,ecx
       jmp       short M00_L03
M00_L02:
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M00_L03:
       xor       eax,eax
M00_L04:
       cmp       eax,r8d
       jae       short M00_L05
       movsxd    r9,eax
       mov       r9d,[rdx+r9*4]
       bswap     r9d
       mov       r10d,eax
       shl       r10d,2
       movsxd    r10,r10d
       mov       [rcx+r10],r9d
       inc       eax
       cmp       eax,2710
       jl        short M00_L04
       add       rsp,28
       ret
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 99
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.WriteInt32.Unsafe_WriteUnaligned_With_BinaryPrimitives_ReverseEndianness()
       sub       rsp,28
       mov       rax,[rcx+8]
       test      rax,rax
       je        short M00_L03
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M00_L04
       lea       r8,[rcx+10]
       mov       ecx,[rcx+8]
M00_L01:
       xor       ecx,ecx
M00_L02:
       cmp       ecx,eax
       jae       short M00_L05
       mov       r9d,ecx
       movbe     r9d,[rdx+r9*4]
       mov       r10d,ecx
       shl       r10d,2
       movsxd    r10,r10d
       mov       [r8+r10],r9d
       inc       ecx
       cmp       ecx,2710
       jl        short M00_L02
       add       rsp,28
       ret
M00_L03:
       xor       edx,edx
       xor       eax,eax
       jmp       short M00_L00
M00_L04:
       xor       r8d,r8d
       jmp       short M00_L01
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 97
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.WriteInt32.Unsafe_WriteUnaligned_With_BinaryPrimitives_ReverseEndianness()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M00_L00
       xor       eax,eax
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       mov       r8d,[rax+8]
       mov       edx,8
M00_L01:
       mov       rsi,rax
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L02
       xor       ecx,ecx
       xor       eax,eax
       xor       edx,edx
       jmp       short M00_L03
M00_L02:
       mov       edx,[rcx+8]
       mov       eax,8
M00_L03:
       lea       r8,[rsp+28]
       mov       [r8],rcx
       mov       [r8+8],rax
       mov       [r8+10],edx
       lea       rcx,[rsp+28]
       call      System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       xor       edx,edx
M00_L04:
       mov       ecx,edx
       shl       ecx,2
       movsxd    rcx,ecx
       add       rcx,rax
       cmp       edx,ebx
       jae       short M00_L07
       test      rsi,rsi
       jne       short M00_L05
       mov       r8,rdi
       movsxd    r9,edx
       lea       r8,[r8+r9*4]
       jmp       short M00_L06
M00_L05:
       lea       r8,[rsi+8]
       add       r8,rdi
       movsxd    r9,edx
       lea       r8,[r8+r9*4]
M00_L06:
       mov       r8d,[r8]
       mov       r9d,r8d
       and       r9d,0FF00FF
       and       r8d,0FF00FF00
       rol       r9d,18
       rol       r8d,8
       add       r9d,r8d
       mov       [rcx],r9d
       inc       edx
       cmp       edx,2710
       jl        short M00_L04
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      System.ThrowHelper.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 220
```
```assembly
; System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       rdx,[rcx]
       mov       rcx,[rcx+8]
       test      rdx,rdx
       jne       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       lea       rax,[rdx+8]
       add       rax,rcx
       ret
; Total bytes of code 24
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowIndexOutOfRangeException()

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.WriteInt32.Unsafe_WriteUnaligned_With_BinaryPrimitives_ReverseEndianness()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,[rcx+8]
       test      rax,rax
       jne       short M00_L00
       xor       eax,eax
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       mov       r8d,[rax+8]
       mov       edx,8
M00_L01:
       mov       rsi,rax
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M00_L02
       xor       ecx,ecx
       xor       eax,eax
       xor       edx,edx
       jmp       short M00_L03
M00_L02:
       mov       edx,[rcx+8]
       mov       eax,8
M00_L03:
       lea       r8,[rsp+28]
       mov       [r8],rcx
       mov       [r8+8],rax
       mov       [r8+10],edx
       lea       rcx,[rsp+28]
       call      System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       xor       edx,edx
M00_L04:
       mov       ecx,edx
       shl       ecx,2
       movsxd    rcx,ecx
       add       rcx,rax
       cmp       edx,ebx
       jae       short M00_L07
       test      rsi,rsi
       jne       short M00_L05
       mov       r8,rdi
       movsxd    r9,edx
       lea       r8,[r8+r9*4]
       jmp       short M00_L06
M00_L05:
       lea       r8,[rsi+8]
       add       r8,rdi
       movsxd    r9,edx
       lea       r8,[r8+r9*4]
M00_L06:
       mov       r8d,[r8]
       mov       r9d,r8d
       and       r9d,0FF00FF
       and       r8d,0FF00FF00
       rol       r9d,18
       rol       r8d,8
       add       r9d,r8d
       mov       [rcx],r9d
       inc       edx
       cmp       edx,2710
       jl        short M00_L04
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L07:
       call      System.ThrowHelper.ThrowIndexOutOfRangeException()
       int       3
; Total bytes of code 220
```
```assembly
; System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       rdx,[rcx]
       mov       rcx,[rcx+8]
       test      rdx,rdx
       jne       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       lea       rax,[rdx+8]
       add       rax,rcx
       ret
; Total bytes of code 24
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowIndexOutOfRangeException()

