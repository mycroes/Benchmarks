## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.ReadInt32.BinaryPrimitives_ReadInt32LittleEndian()
       sub       rsp,28
       mov       rax,[rcx+8]
       test      rax,rax
       je        short M00_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       cmp       eax,4
       jl        short M00_L02
       mov       eax,[rcx]
       add       rsp,28
       ret
M00_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M00_L00
M00_L02:
       mov       ecx,29
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 49
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.ReadInt32.BinaryPrimitives_ReadInt32LittleEndian()
       sub       rsp,28
       mov       rax,[rcx+8]
       test      rax,rax
       je        short M00_L01
       lea       rcx,[rax+10]
       mov       edx,[rax+8]
M00_L00:
       cmp       edx,4
       jl        short M00_L02
       mov       eax,[rcx]
       add       rsp,28
       ret
M00_L01:
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M00_L00
M00_L02:
       mov       ecx,29
       call      qword ptr [7FFF5FA0B7E0]
       int       3
; Total bytes of code 50
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.ReadInt32.BinaryPrimitives_ReadInt32LittleEndian()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M00_L00
       xor       ecx,ecx
       xor       eax,eax
       xor       edx,edx
       jmp       short M00_L01
M00_L00:
       mov       edx,[rcx+8]
       mov       eax,8
M00_L01:
       cmp       edx,4
       jl        short M00_L03
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],rax
       mov       [r8+10],edx
       lea       rcx,[rsp+20]
       call      System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.ReadOnlySpan`1<Byte>)
       mov       esi,[rax]
       mov       ecx,1
       mov       edx,0B0
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FF850DE3DCD],0
       jne       short M00_L02
       mov       eax,esi
       and       eax,0FF00FF
       mov       ecx,esi
       and       ecx,0FF00FF00
       rol       eax,18
       rol       ecx,8
       lea       esi,[rax+rcx]
M00_L02:
       mov       eax,esi
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L03:
       xor       ecx,ecx
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 149
```
```assembly
; System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.ReadOnlySpan`1<Byte>)
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
; Benchmarks.Serialization.ReadInt32.BinaryPrimitives_ReadInt32LittleEndian()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M00_L00
       xor       ecx,ecx
       xor       eax,eax
       xor       edx,edx
       jmp       short M00_L01
M00_L00:
       mov       edx,[rcx+8]
       mov       eax,8
M00_L01:
       cmp       edx,4
       jl        short M00_L03
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],rax
       mov       [r8+10],edx
       lea       rcx,[rsp+20]
       call      System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.ReadOnlySpan`1<Byte>)
       mov       esi,[rax]
       mov       ecx,1
       mov       edx,0B0
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FF850DB3DCD],0
       jne       short M00_L02
       mov       eax,esi
       and       eax,0FF00FF
       mov       ecx,esi
       and       ecx,0FF00FF00
       rol       eax,18
       rol       ecx,8
       lea       esi,[rax+rcx]
M00_L02:
       mov       eax,esi
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L03:
       xor       ecx,ecx
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 149
```
```assembly
; System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.ReadOnlySpan`1<Byte>)
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
; Benchmarks.Serialization.ReadInt32.Unsafe_ReadUnaligned()
       mov       rax,[rcx+8]
       test      rax,rax
       je        short M00_L01
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       eax,[rdx]
       ret
M00_L01:
       xor       edx,edx
       jmp       short M00_L00
; Total bytes of code 23
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.ReadInt32.Unsafe_ReadUnaligned()
       mov       rax,[rcx+8]
       test      rax,rax
       je        short M00_L01
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       eax,[rdx]
       ret
M00_L01:
       xor       edx,edx
       jmp       short M00_L00
; Total bytes of code 23
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.ReadInt32.Unsafe_ReadUnaligned()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M00_L00
       xor       ecx,ecx
       xor       eax,eax
       xor       edx,edx
       jmp       short M00_L01
M00_L00:
       mov       edx,[rcx+8]
       mov       eax,8
M00_L01:
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],rax
       mov       [r8+10],edx
       lea       rcx,[rsp+20]
       call      System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       eax,[rax]
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.ReadInt32.Unsafe_ReadUnaligned()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M00_L00
       xor       ecx,ecx
       xor       eax,eax
       xor       edx,edx
       jmp       short M00_L01
M00_L00:
       mov       edx,[rcx+8]
       mov       eax,8
M00_L01:
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],rax
       mov       [r8+10],edx
       lea       rcx,[rsp+20]
       call      System.Runtime.InteropServices.MemoryMarshal.GetReference[[System.Byte, mscorlib]](System.Span`1<Byte>)
       mov       eax,[rax]
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
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

