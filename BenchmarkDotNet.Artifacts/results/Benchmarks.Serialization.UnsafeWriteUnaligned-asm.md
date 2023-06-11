## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteInt()
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L01
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       ecx,[rcx+20]
       mov       [rdx],ecx
       ret
M00_L01:
       xor       edx,edx
       jmp       short M00_L00
; Total bytes of code 26
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteBytes()
       sub       rsp,28
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L01
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       rax,[rcx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M00_L02
       movzx     eax,byte ptr [rax+10]
       mov       [rdx],al
       mov       rax,[rcx+8]
       cmp       dword ptr [rax+8],1
       jbe       short M00_L02
       movzx     eax,byte ptr [rax+11]
       mov       [rdx+1],al
       mov       rax,[rcx+8]
       cmp       dword ptr [rax+8],2
       jbe       short M00_L02
       movzx     eax,byte ptr [rax+12]
       mov       [rdx+2],al
       mov       rcx,[rcx+8]
       cmp       dword ptr [rcx+8],3
       jbe       short M00_L02
       movzx     eax,byte ptr [rcx+13]
       mov       [rdx+3],al
       add       rsp,28
       ret
M00_L01:
       xor       edx,edx
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 102
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteIntComposed()
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       rdx,rax
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M00_L02
       movzx     edx,byte ptr [rdx+10]
       mov       r9,rax
       cmp       r8d,1
       jbe       short M00_L02
       movzx     r9d,byte ptr [r9+11]
       add       r9d,r9d
       or        edx,r9d
       mov       r9,rax
       cmp       r8d,2
       jbe       short M00_L02
       movzx     r9d,byte ptr [r9+12]
       shl       r9d,2
       or        edx,r9d
       cmp       r8d,3
       jbe       short M00_L02
       movzx     eax,byte ptr [rax+13]
       shl       eax,3
       or        eax,edx
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdx+10]
       mov       edx,[rdx+8]
M00_L00:
       mov       [rcx],eax
       add       rsp,28
       ret
M00_L01:
       xor       ecx,ecx
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 113
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteLong()
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L01
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       rcx,[rcx+18]
       mov       [rdx],rcx
       ret
M00_L01:
       xor       edx,edx
       jmp       short M00_L00
; Total bytes of code 28
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteInt()
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L01
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       ecx,[rcx+20]
       mov       [rdx],ecx
       ret
M00_L01:
       xor       edx,edx
       jmp       short M00_L00
; Total bytes of code 26
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteBytes()
       sub       rsp,28
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L01
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       rax,[rcx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M00_L02
       movzx     eax,byte ptr [rax+10]
       mov       [rdx],al
       mov       rax,[rcx+8]
       cmp       dword ptr [rax+8],1
       jbe       short M00_L02
       movzx     eax,byte ptr [rax+11]
       mov       [rdx+1],al
       mov       rax,[rcx+8]
       cmp       dword ptr [rax+8],2
       jbe       short M00_L02
       movzx     eax,byte ptr [rax+12]
       mov       [rdx+2],al
       mov       rcx,[rcx+8]
       cmp       dword ptr [rcx+8],3
       jbe       short M00_L02
       movzx     eax,byte ptr [rcx+13]
       mov       [rdx+3],al
       add       rsp,28
       ret
M00_L01:
       xor       edx,edx
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 102
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteIntComposed()
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       rdx,rax
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M00_L02
       movzx     edx,byte ptr [rdx+10]
       mov       r9,rax
       cmp       r8d,1
       jbe       short M00_L02
       movzx     r9d,byte ptr [r9+11]
       add       r9d,r9d
       or        edx,r9d
       mov       r9,rax
       cmp       r8d,2
       jbe       short M00_L02
       movzx     r9d,byte ptr [r9+12]
       shl       r9d,2
       or        edx,r9d
       cmp       r8d,3
       jbe       short M00_L02
       movzx     eax,byte ptr [rax+13]
       shl       eax,3
       or        eax,edx
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rdx+10]
       mov       edx,[rdx+8]
M00_L00:
       mov       [rcx],eax
       add       rsp,28
       ret
M00_L01:
       xor       ecx,ecx
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 113
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteLong()
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L01
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M00_L00:
       mov       rcx,[rcx+18]
       mov       [rdx],rcx
       ret
M00_L01:
       xor       edx,edx
       jmp       short M00_L00
; Total bytes of code 28
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteInt()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rsi,rcx
       mov       rcx,[rsi+10]
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
       mov       edx,[rsi+20]
       mov       [rax],edx
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
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
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteBytes()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rsi,rcx
       mov       rcx,[rsi+10]
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
       mov       rdx,[rsi+8]
       cmp       dword ptr [rdx+8],0
       jbe       short M00_L02
       movzx     edx,byte ptr [rdx+10]
       mov       [rax],dl
       mov       rdx,[rsi+8]
       cmp       dword ptr [rdx+8],1
       jbe       short M00_L02
       movzx     edx,byte ptr [rdx+11]
       mov       [rax+1],dl
       mov       rdx,[rsi+8]
       cmp       dword ptr [rdx+8],2
       jbe       short M00_L02
       movzx     edx,byte ptr [rdx+12]
       mov       [rax+2],dl
       mov       rdx,[rsi+8]
       cmp       dword ptr [rdx+8],3
       jbe       short M00_L02
       movzx     edx,byte ptr [rdx+13]
       mov       [rax+3],dl
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
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
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteIntComposed()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,[rcx+8]
       mov       rdx,rax
       mov       r8d,[rdx+8]
       cmp       r8d,0
       jbe       short M00_L02
       movzx     edx,byte ptr [rdx+10]
       mov       r9,rax
       cmp       r8d,1
       jbe       short M00_L02
       movzx     r9d,byte ptr [r9+11]
       shl       r9d,1
       or        edx,r9d
       mov       r9,rax
       cmp       r8d,2
       jbe       short M00_L02
       movzx     r9d,byte ptr [r9+12]
       shl       r9d,2
       or        edx,r9d
       cmp       r8d,3
       jbe       short M00_L02
       movzx     eax,byte ptr [rax+13]
       shl       eax,3
       mov       esi,edx
       or        esi,eax
       mov       rcx,[rcx+10]
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
       mov       [rax],esi
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 171
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
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteLong()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rsi,rcx
       mov       rcx,[rsi+10]
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
       mov       rdx,[rsi+18]
       mov       [rax],rdx
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
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
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteInt()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rsi,rcx
       mov       rcx,[rsi+10]
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
       mov       edx,[rsi+20]
       mov       [rax],edx
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
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
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteBytes()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rsi,rcx
       mov       rcx,[rsi+10]
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
       mov       rdx,[rsi+8]
       cmp       dword ptr [rdx+8],0
       jbe       short M00_L02
       movzx     edx,byte ptr [rdx+10]
       mov       [rax],dl
       mov       rdx,[rsi+8]
       cmp       dword ptr [rdx+8],1
       jbe       short M00_L02
       movzx     edx,byte ptr [rdx+11]
       mov       [rax+1],dl
       mov       rdx,[rsi+8]
       cmp       dword ptr [rdx+8],2
       jbe       short M00_L02
       movzx     edx,byte ptr [rdx+12]
       mov       [rax+2],dl
       mov       rdx,[rsi+8]
       cmp       dword ptr [rdx+8],3
       jbe       short M00_L02
       movzx     edx,byte ptr [rdx+13]
       mov       [rax+3],dl
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
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
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteIntComposed()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rax,[rcx+8]
       mov       rdx,rax
       mov       r8d,[rdx+8]
       cmp       r8d,0
       jbe       short M00_L02
       movzx     edx,byte ptr [rdx+10]
       mov       r9,rax
       cmp       r8d,1
       jbe       short M00_L02
       movzx     r9d,byte ptr [r9+11]
       shl       r9d,1
       or        edx,r9d
       mov       r9,rax
       cmp       r8d,2
       jbe       short M00_L02
       movzx     r9d,byte ptr [r9+12]
       shl       r9d,2
       or        edx,r9d
       cmp       r8d,3
       jbe       short M00_L02
       movzx     eax,byte ptr [rax+13]
       shl       eax,3
       mov       esi,edx
       or        esi,eax
       mov       rcx,[rcx+10]
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
       mov       [rax],esi
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 171
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
; Benchmarks.Serialization.UnsafeWriteUnaligned.WriteLong()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rsi,rcx
       mov       rcx,[rsi+10]
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
       mov       rdx,[rsi+18]
       mov       [rax],rdx
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
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

