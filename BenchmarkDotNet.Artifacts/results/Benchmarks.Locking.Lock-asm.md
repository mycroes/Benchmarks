## .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2
```assembly
; Benchmarks.Locking.Lock.LockMutex()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-20],rsp
       mov       rcx,[rcx+8]
       mov       [rbp-10],rcx
       cmp       byte ptr [rbp-8],0
       jne       short M00_L00
       lea       rdx,[rbp-8]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M00_L01
M00_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M00_L01:
       cmp       byte ptr [rbp-8],0
       je        short M00_L02
       mov       rcx,[rbp-10]
       call      System.Threading.Monitor.Exit(System.Object)
M00_L02:
       xor       eax,eax
       add       rsp,40
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       byte ptr [rbp-8],0
       je        short M00_L03
       mov       rcx,[rbp-10]
       call      System.Threading.Monitor.Exit(System.Object)
M00_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 114
```
**Extern method**
System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
System.Threading.Monitor.Exit(System.Object)
**Method was not JITted yet.**
System.Threading.Monitor.ThrowLockTakenException()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Locking.Lock.LockMutex()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-20],rsp
       mov       rcx,[rcx+8]
       mov       [rbp-10],rcx
       cmp       byte ptr [rbp-8],0
       jne       short M00_L00
       lea       rdx,[rbp-8]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FF92E1B9030]
       int       3
M00_L01:
       cmp       byte ptr [rbp-8],0
       je        short M00_L02
       mov       rcx,[rbp-10]
       call      System.Threading.Monitor.Exit(System.Object)
M00_L02:
       xor       eax,eax
       add       rsp,40
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       byte ptr [rbp-8],0
       je        short M00_L03
       mov       rcx,[rbp-10]
       call      System.Threading.Monitor.Exit(System.Object)
M00_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 115
```
**Extern method**
System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
System.Threading.Monitor.Exit(System.Object)

## .NET Framework 4.8 (4.8.4644.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Locking.Lock.LockMutex()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-20],rsp
       mov       rax,[rcx+8]
       mov       [rbp-10],rax
       xor       eax,eax
       mov       [rbp-8],eax
       cmp       byte ptr [rbp-8],0
       je        short M00_L00
       call      System.Threading.Monitor.ThrowLockTakenException()
M00_L00:
       lea       rdx,[rbp-8]
       mov       rcx,[rbp-10]
       call      CORINFO_HELP_MON_ENTER
       nop
       mov       rcx,rsp
       call      M00_L01
       nop
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M00_L01:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       byte ptr [rbp-8],0
       je        short M00_L02
       mov       rcx,[rbp-10]
       call      System.Threading.Monitor.Exit(System.Object)
M00_L02:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 115
```
```assembly
; System.Threading.Monitor.ThrowLockTakenException()
       push      rdi
       push      rsi
       sub       rsp,28
       lea       rcx,[MT_System.ArgumentException]
       call      qword ptr [7FFA96E2AE70]; CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,298C3
       call      00007FFA96E2C776
       mov       rcx,rax
       call      qword ptr [7FFA968E7E98]; System.Environment.GetResourceFromDefault(System.String)
       mov       rdi,rax
       mov       ecx,298ED
       call      00007FFA96E2C776
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       nop
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      00007FFA96E2C76A
       int       3
; Total bytes of code 78
```
**Extern method**
System.Threading.Monitor.Exit(System.Object)

## .NET Framework 4.8 (4.8.4644.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Locking.Lock.LockMutex()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-20],rsp
       mov       rax,[rcx+8]
       mov       [rbp-10],rax
       xor       eax,eax
       mov       [rbp-8],eax
       cmp       byte ptr [rbp-8],0
       je        short M00_L00
       call      System.Threading.Monitor.ThrowLockTakenException()
M00_L00:
       lea       rdx,[rbp-8]
       mov       rcx,[rbp-10]
       call      CORINFO_HELP_MON_ENTER
       nop
       mov       rcx,rsp
       call      M00_L01
       nop
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M00_L01:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       byte ptr [rbp-8],0
       je        short M00_L02
       mov       rcx,[rbp-10]
       call      System.Threading.Monitor.Exit(System.Object)
M00_L02:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 115
```
```assembly
; System.Threading.Monitor.ThrowLockTakenException()
       push      rdi
       push      rsi
       sub       rsp,28
       lea       rcx,[MT_System.ArgumentException]
       call      qword ptr [7FFA96E2AE70]; CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,298C3
       call      00007FFA96E2C776
       mov       rcx,rax
       call      qword ptr [7FFA968E7E98]; System.Environment.GetResourceFromDefault(System.String)
       mov       rdi,rax
       mov       ecx,298ED
       call      00007FFA96E2C776
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       nop
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      00007FFA96E2C76A
       int       3
; Total bytes of code 78
```
**Extern method**
System.Threading.Monitor.Exit(System.Object)

## .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2
```assembly
; Benchmarks.Locking.Lock.MonitorEnter()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rsp
       mov       [rbp+10],rcx
       mov       rdx,[rcx+8]
       cmp       byte ptr [rbp-8],0
       jne       short M00_L00
       lea       r8,[rbp-8]
       mov       rcx,rdx
       xor       edx,edx
       call      System.Threading.Monitor.ReliableEnterTimeout(System.Object, Int32, Boolean ByRef)
       cmp       byte ptr [rbp-8],0
       je        short M00_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      System.Threading.Monitor.Exit(System.Object)
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M00_L00:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M00_L01:
       call      Benchmarks.Locking.Lock.<MonitorEnter>g__Throw|7_0()
       int       3
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 125
```
**Extern method**
System.Threading.Monitor.ReliableEnterTimeout(System.Object, Int32, Boolean ByRef)
System.Threading.Monitor.Exit(System.Object)
**Method was not JITted yet.**
System.Threading.Monitor.ThrowLockTakenException()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Locking.Lock.MonitorEnter()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rsp
       mov       [rbp+10],rcx
       mov       rdx,[rcx+8]
       cmp       byte ptr [rbp-8],0
       jne       short M00_L00
       lea       r8,[rbp-8]
       mov       rcx,rdx
       xor       edx,edx
       call      System.Threading.Monitor.ReliableEnterTimeout(System.Object, Int32, Boolean ByRef)
       cmp       byte ptr [rbp-8],0
       je        short M00_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      System.Threading.Monitor.Exit(System.Object)
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M00_L00:
       call      qword ptr [7FF92E1D9030]
       int       3
M00_L01:
       call      qword ptr [7FF92E3E16D8]
       int       3
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 127
```
**Extern method**
System.Threading.Monitor.ReliableEnterTimeout(System.Object, Int32, Boolean ByRef)
System.Threading.Monitor.Exit(System.Object)

## .NET Framework 4.8 (4.8.4644.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Locking.Lock.MonitorEnter()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-20],rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rsi,[rax+8]
       xor       eax,eax
       mov       [rbp-10],eax
       mov       [rbp-10],eax
       cmp       byte ptr [rbp-10],0
       je        short M00_L00
       call      System.Threading.Monitor.ThrowLockTakenException()
M00_L00:
       lea       r8,[rbp-10]
       mov       rcx,rsi
       xor       edx,edx
       call      System.Threading.Monitor.ReliableEnterTimeout(System.Object, Int32, Boolean ByRef)
       cmp       byte ptr [rbp-10],0
       je        short M00_L01
       mov       rcx,rsp
       call      M00_L02
       nop
       xor       eax,eax
       lea       rsp,[rbp-8]
       pop       rsi
       pop       rbp
       ret
M00_L01:
       call      Benchmarks.Locking.Lock.<MonitorEnter>g__Throw|7_0()
       int       3
M00_L02:
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 136
```
```assembly
; System.Threading.Monitor.ThrowLockTakenException()
       push      rdi
       push      rsi
       sub       rsp,28
       lea       rcx,[MT_System.ArgumentException]
       call      qword ptr [7FFA96E2AE70]; CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,298C3
       call      00007FFA96E2C776
       mov       rcx,rax
       call      qword ptr [7FFA968E7E98]; System.Environment.GetResourceFromDefault(System.String)
       mov       rdi,rax
       mov       ecx,298ED
       call      00007FFA96E2C776
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       nop
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      00007FFA96E2C76A
       int       3
; Total bytes of code 78
```
**Extern method**
System.Threading.Monitor.ReliableEnterTimeout(System.Object, Int32, Boolean ByRef)
System.Threading.Monitor.Exit(System.Object)

## .NET Framework 4.8 (4.8.4644.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Locking.Lock.MonitorEnter()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-20],rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rsi,[rax+8]
       xor       eax,eax
       mov       [rbp-10],eax
       mov       [rbp-10],eax
       cmp       byte ptr [rbp-10],0
       je        short M00_L00
       call      System.Threading.Monitor.ThrowLockTakenException()
M00_L00:
       lea       r8,[rbp-10]
       mov       rcx,rsi
       xor       edx,edx
       call      System.Threading.Monitor.ReliableEnterTimeout(System.Object, Int32, Boolean ByRef)
       cmp       byte ptr [rbp-10],0
       je        short M00_L01
       mov       rcx,rsp
       call      M00_L02
       nop
       xor       eax,eax
       lea       rsp,[rbp-8]
       pop       rsi
       pop       rbp
       ret
M00_L01:
       call      Benchmarks.Locking.Lock.<MonitorEnter>g__Throw|7_0()
       int       3
M00_L02:
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 136
```
```assembly
; System.Threading.Monitor.ThrowLockTakenException()
       push      rdi
       push      rsi
       sub       rsp,28
       lea       rcx,[MT_System.ArgumentException]
       call      qword ptr [7FFA96E2AE70]; CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,298C3
       call      00007FFA96E2C776
       mov       rcx,rax
       call      qword ptr [7FFA968E7E98]; System.Environment.GetResourceFromDefault(System.String)
       mov       rdi,rax
       mov       ecx,298ED
       call      00007FFA96E2C776
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       nop
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      00007FFA96E2C76A
       int       3
; Total bytes of code 78
```
**Extern method**
System.Threading.Monitor.ReliableEnterTimeout(System.Object, Int32, Boolean ByRef)
System.Threading.Monitor.Exit(System.Object)

## .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2
```assembly
; Benchmarks.Locking.Lock.CompareExchange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp-10],rsp
       mov       [rbp+10],rcx
       add       rcx,10
       mov       rax,[rbp+10]
       mov       rdx,[rax+8]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       eax,eax
       mov       rcx,[rbp+10]
       mov       [rcx+10],rax
       add       rsp,30
       pop       rbp
       ret
M00_L00:
       call      Benchmarks.Locking.Lock.<CompareExchange>g__Throw|8_0()
       int       3
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       xor       eax,eax
       mov       rcx,[rbp+10]
       mov       [rcx+10],rax
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 99
```
**Extern method**
System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
**Method was not JITted yet.**
Benchmarks.Locking.Lock.<CompareExchange>g__Throw|8_0()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Locking.Lock.CompareExchange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp-10],rsp
       mov       [rbp+10],rcx
       add       rcx,10
       mov       rax,[rbp+10]
       mov       rdx,[rax+8]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       short M00_L00
       xor       eax,eax
       mov       rcx,[rbp+10]
       mov       [rcx+10],rax
       add       rsp,30
       pop       rbp
       ret
M00_L00:
       call      qword ptr [7FF92E3E16F0]
       int       3
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       xor       eax,eax
       mov       rcx,[rbp+10]
       mov       [rcx+10],rax
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 100
```
**Extern method**
System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)

## .NET Framework 4.8 (4.8.4644.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Locking.Lock.CompareExchange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp-10],rsp
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       mov       rcx,[rbp+10]
       add       rcx,10
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+8]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       short M00_L00
       mov       rcx,rsp
       call      M00_L01
       nop
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M00_L00:
       call      Benchmarks.Locking.Lock.<CompareExchange>g__Throw|8_0()
       int       3
M00_L01:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rax,[rbp+10]
       xor       edx,edx
       mov       [rax+10],rdx
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
```
**Extern method**
System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
**Method was not JITted yet.**
Benchmarks.Locking.Lock.<CompareExchange>g__Throw|8_0()

## .NET Framework 4.8 (4.8.4644.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Locking.Lock.CompareExchange()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp-10],rsp
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       mov       rcx,[rbp+10]
       add       rcx,10
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+8]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       short M00_L00
       mov       rcx,rsp
       call      M00_L01
       nop
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M00_L00:
       call      Benchmarks.Locking.Lock.<CompareExchange>g__Throw|8_0()
       int       3
M00_L01:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rax,[rbp+10]
       xor       edx,edx
       mov       [rax+10],rdx
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
```
**Extern method**
System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
**Method was not JITted yet.**
Benchmarks.Locking.Lock.<CompareExchange>g__Throw|8_0()

## .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2
```assembly
; Benchmarks.Locking.Lock.ChannelRead()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rsp
       mov       [rbp+10],rcx
       mov       rax,[rcx+20]
       mov       rcx,rax
       lea       rdx,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       je        short M00_L00
       xor       ecx,ecx
       mov       [rbp-8],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
M00_L00:
       call      Benchmarks.Locking.Lock.<ChannelRead>g__Throw|9_0()
       int       3
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 139
```
**Method was not JITted yet.**
Benchmarks.Locking.Lock.<ChannelRead>g__Throw|9_0()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Locking.Lock.ChannelRead()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rsp
       mov       [rbp+10],rcx
       mov       rax,[rcx+20]
       mov       rcx,rax
       lea       rdx,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      eax,eax
       je        short M00_L00
       xor       ecx,ecx
       mov       [rbp-8],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
M00_L00:
       call      qword ptr [7FF92E3F1708]
       int       3
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 140
```

## .NET Framework 4.8 (4.8.4644.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Locking.Lock.ChannelRead()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rsp
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+20]
       lea       rdx,[rbp-8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      al,al
       je        short M00_L00
       xor       ecx,ecx
       mov       [rbp-8],ecx
       mov       rcx,rsp
       call      M00_L01
       nop
       mov       eax,[rbp-8]
       lea       rsp,[rbp]
       pop       rbp
       ret
M00_L00:
       call      Benchmarks.Locking.Lock.<ChannelRead>g__Throw|9_0()
       int       3
M00_L01:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 126
```
**Method was not JITted yet.**
Benchmarks.Locking.Lock.<ChannelRead>g__Throw|9_0()

## .NET Framework 4.8 (4.8.4644.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Locking.Lock.ChannelRead()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rsp
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+20]
       lea       rdx,[rbp-8]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       test      al,al
       je        short M00_L00
       xor       ecx,ecx
       mov       [rbp-8],ecx
       mov       rcx,rsp
       call      M00_L01
       nop
       mov       eax,[rbp-8]
       lea       rsp,[rbp]
       pop       rbp
       ret
M00_L00:
       call      Benchmarks.Locking.Lock.<ChannelRead>g__Throw|9_0()
       int       3
M00_L01:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 126
```
**Method was not JITted yet.**
Benchmarks.Locking.Lock.<ChannelRead>g__Throw|9_0()

