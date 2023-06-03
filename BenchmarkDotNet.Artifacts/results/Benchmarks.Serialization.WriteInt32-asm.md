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

