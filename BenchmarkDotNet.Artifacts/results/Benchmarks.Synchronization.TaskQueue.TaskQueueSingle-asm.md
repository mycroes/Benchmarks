## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.InterLockedExchangeTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
M00_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 79
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+3C],eax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue+<>c__DisplayClass1_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+34],2000400
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       call      System.Threading.Tasks.TaskExtensions.Unwrap(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       rdi,rax
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      System.Threading.Interlocked.Exchange(System.Object ByRef, System.Object)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue+<>c__DisplayClass1_0.<Execute>b__0(System.Threading.Tasks.Task)
       mov       [rbp+18],rax
       cmp       [rsi],esi
       call      System.Threading.Tasks.TaskScheduler.get_InternalCurrent()
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L00
       mov       rcx,1DB3A8D1A68
       mov       rbx,[rcx]
M03_L00:
       test      rbx,rbx
       je        near ptr M03_L03
       lea       rcx,[rsp+3C]
       mov       dword ptr [rcx],200
       mov       rcx,offset MT_System.Threading.Tasks.ContinuationTaskFromTask
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,[rsp+3C]
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],ecx
       mov       [rsp+30],rdx
       mov       rcx,r14
       mov       rdx,rbp
       xor       r9d,r9d
       xor       r8d,r8d
       call      System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       call      System.Threading.ExecutionContext.Capture()
       mov       rbp,rax
       test      rbp,rbp
       je        short M03_L02
       mov       rcx,1DB3A8D1890
       cmp       rbp,[rcx]
       je        short M03_L01
       mov       rcx,r14
       call      System.Threading.Tasks.Task.EnsureContingentPropertiesInitializedUnsafe()
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       lea       rcx,[r14+38]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsp+20],80000
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rbx
       xor       r9d,r9d
       call      System.Threading.Tasks.Task.ContinueWithCore(System.Threading.Tasks.Task, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
       or        dword ptr [r14+34],20000000
       jmp       short M03_L01
M03_L03:
       mov       ecx,30
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 415
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,1DB3A8D7418
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1DB3A8D7410
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,1DB3A8D7418
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       mov       rcx,[rsi+8]
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 119
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M05_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M05_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L02
M05_L01:
       add       rsp,20
       pop       rsi
       ret
M05_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M05_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.InterLockedExchangeTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFC9D3EAA08
       mov       [rdi+18],rcx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC9D3E16C0]; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
M00_L00:
       call      qword ptr [7FFC9D13B630]
       int       3
; Total bytes of code 81
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFC9D5973C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rsi
       sub       rsp,30
       mov       rax,27E6D006438
       mov       rdx,[rax]
       mov       [rsp+28],rcx
       test      rdx,rdx
       jne       short M03_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,27E6D006430
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFC9D596468
       mov       [rsi+18],rdx
       mov       rcx,27E6D006438
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
M03_L00:
       mov       rcx,[rsp+28]
       mov       rcx,[rcx+8]
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rsi
       jmp       qword ptr [rax+18]
; Total bytes of code 126
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC9D369AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFC9D369270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFC9D5973D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.InterLockedExchangeTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       nop       dword ptr [rax+rax]
       mov       rax,rcx
       ret
; Total bytes of code 9
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       sub       rsp,28
       nop
       mov       rcx,[rcx]
       mov       eax,[rcx+3C]
       and       eax,11000000
       cmp       eax,1000000
       je        short M02_L00
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue+<>c__DisplayClass1_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rbp
       mov       dword ptr [rdx+3C],2000400
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      System.Threading.Tasks.TaskExtensions.Unwrap(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       rdi,rax
       mov       rcx,offset MT_System.Action`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       mov       r8,rdi
       mov       rcx,offset MD_System.Threading.Interlocked.Exchange[[System.Threading.Tasks.Task, mscorlib]](System.Threading.Tasks.Task ByRef, System.Threading.Tasks.Task)
       call      System.Threading.Interlocked.Exchange[[System.__Canon, mscorlib]](System.__Canon ByRef, System.__Canon)
       mov       rsi,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue+<>c__DisplayClass1_0.<Execute>b__0(System.Threading.Tasks.Task)
       mov       [rbp+18],rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,80000
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.ContinueWith(System.Action`1<System.Threading.Tasks.Task>, System.Threading.Tasks.TaskContinuationOptions)
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 224
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,20B6EC89F38
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20B6EC89F30
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,20B6EC89F38
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+8]
       mov       rcx,[rcx]
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 136
```
```assembly
; System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       push      rsi
       sub       rsp,20
       lea       rcx,[MT_System.ArgumentException]
       call      qword ptr [7FFDC7889870]; CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,374C
       call      00007FFDC788A776
       mov       rcx,rax
       call      qword ptr [7FFDC7357E98]; System.Environment.GetResourceFromDefault(System.String)
       mov       rdx,rax
       mov       rcx,rsi
       nop
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rsi
       call      00007FFDC788A76A
       int       3
; Total bytes of code 61
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+3C]
       test      ecx,1600000
       je        near ptr 00007FFDC86A2C22
       mov       rcx,rsi
       nop
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+3C]
       and       ecx,1600000
       cmp       ecx,1000000
       je        near ptr 00007FFDC86A2C1C
       mov       rcx,rsi
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       near ptr 00007FFDC86A2C1C
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
; Total bytes of code 95
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.InterLockedExchangeTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       nop       dword ptr [rax+rax]
       mov       rax,rcx
       ret
; Total bytes of code 9
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       sub       rsp,28
       nop
       mov       rcx,[rcx]
       mov       eax,[rcx+3C]
       and       eax,11000000
       cmp       eax,1000000
       je        short M02_L00
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue+<>c__DisplayClass1_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rbp
       mov       dword ptr [rdx+3C],2000400
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      System.Threading.Tasks.TaskExtensions.Unwrap(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       rdi,rax
       mov       rcx,offset MT_System.Action`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       mov       r8,rdi
       mov       rcx,offset MD_System.Threading.Interlocked.Exchange[[System.Threading.Tasks.Task, mscorlib]](System.Threading.Tasks.Task ByRef, System.Threading.Tasks.Task)
       call      System.Threading.Interlocked.Exchange[[System.__Canon, mscorlib]](System.__Canon ByRef, System.__Canon)
       mov       rsi,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue+<>c__DisplayClass1_0.<Execute>b__0(System.Threading.Tasks.Task)
       mov       [rbp+18],rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,80000
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.ContinueWith(System.Action`1<System.Threading.Tasks.Task>, System.Threading.Tasks.TaskContinuationOptions)
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 224
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,2364EAD9F38
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2364EAD9F30
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,2364EAD9F38
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+8]
       mov       rcx,[rcx]
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 136
```
```assembly
; System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       push      rsi
       sub       rsp,20
       lea       rcx,[MT_System.ArgumentException]
       call      qword ptr [7FFDC7889870]; CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,374C
       call      00007FFDC788A776
       mov       rcx,rax
       call      qword ptr [7FFDC7357E98]; System.Environment.GetResourceFromDefault(System.String)
       mov       rdx,rax
       mov       rcx,rsi
       nop
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rsi
       call      00007FFDC788A76A
       int       3
; Total bytes of code 61
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+3C]
       test      ecx,1600000
       je        near ptr 00007FFDC86A2C22
       mov       rcx,rsi
       nop
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+3C]
       and       ecx,1600000
       cmp       ecx,1000000
       je        near ptr 00007FFDC86A2C1C
       mov       rcx,rsi
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       near ptr 00007FFDC86A2C1C
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
; Total bytes of code 95
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.InterLockedExchangeAwaitTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeAwaitTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
M00_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 79
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeAwaitTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+20],rcx
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeAwaitTaskQueue+<Execute>d__1, Benchmarks]](<Execute>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,58
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M03_L00
; Total bytes of code 95
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,215DB577418
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,215DB577410
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,215DB577418
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       mov       rcx,[rsi+8]
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 119
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M05_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M05_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L02
M05_L01:
       add       rsp,20
       pop       rsi
       ret
M05_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M05_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.InterLockedExchangeAwaitTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFC9D3CAA38
       mov       [rdi+18],rcx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC9D3C16C0]; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
M00_L00:
       call      qword ptr [7FFC9D11B630]
       int       3
; Total bytes of code 81
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFC9D5773C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rsi
       sub       rsp,30
       mov       rax,29768C06438
       mov       rdx,[rax]
       mov       [rsp+28],rcx
       test      rdx,rdx
       jne       short M03_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,29768C06430
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFC9D576468
       mov       [rsi+18],rdx
       mov       rcx,29768C06438
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
M03_L00:
       mov       rcx,[rsp+28]
       mov       rcx,[rcx+8]
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rsi
       jmp       qword ptr [rax+18]
; Total bytes of code 126
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC9D349AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFC9D349270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFC9D5773D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.InterLockedExchangeAwaitTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeAwaitTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       nop       dword ptr [rax+rax]
       mov       rax,rcx
       ret
; Total bytes of code 9
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       sub       rsp,28
       nop
       mov       rcx,[rcx]
       mov       eax,[rcx+3C]
       and       eax,11000000
       cmp       eax,1000000
       je        short M02_L00
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeAwaitTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,68
       vzeroupper
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,12
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       xor       eax,eax
       lea       r8,[rsp+48]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r8],xmm0
       mov       [r8+10],rax
       mov       [rsp+20],rcx
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeAwaitTaskQueue+<Execute>d__1, Benchmarks]](<Execute>d__1 ByRef)
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, mscorlib]].get_Task()
       nop
       add       rsp,68
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,16BEA9D9F38
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,16BEA9D9F30
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,16BEA9D9F38
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+8]
       mov       rcx,[rcx]
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 136
```
```assembly
; System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       push      rsi
       sub       rsp,20
       lea       rcx,[MT_System.ArgumentException]
       call      qword ptr [7FFDC7889870]; CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,374C
       call      00007FFDC788A776
       mov       rcx,rax
       call      qword ptr [7FFDC7357E98]; System.Environment.GetResourceFromDefault(System.String)
       mov       rdx,rax
       mov       rcx,rsi
       nop
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rsi
       call      00007FFDC788A76A
       int       3
; Total bytes of code 61
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+3C]
       test      ecx,1600000
       je        near ptr 00007FFDC86A2C22
       mov       rcx,rsi
       nop
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+3C]
       and       ecx,1600000
       cmp       ecx,1000000
       je        near ptr 00007FFDC86A2C1C
       mov       rcx,rsi
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       near ptr 00007FFDC86A2C1C
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
; Total bytes of code 95
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.InterLockedExchangeAwaitTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+10]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeAwaitTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       nop       dword ptr [rax+rax]
       mov       rax,rcx
       ret
; Total bytes of code 9
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       sub       rsp,28
       nop
       mov       rcx,[rcx]
       mov       eax,[rcx+3C]
       and       eax,11000000
       cmp       eax,1000000
       je        short M02_L00
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeAwaitTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,68
       vzeroupper
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,12
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       xor       eax,eax
       lea       r8,[rsp+48]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r8],xmm0
       mov       [r8+10],rax
       mov       [rsp+20],rcx
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeAwaitTaskQueue+<Execute>d__1, Benchmarks]](<Execute>d__1 ByRef)
       lea       rcx,[rsp+48]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, mscorlib]].get_Task()
       nop
       add       rsp,68
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,2C949479F38
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2C949479F30
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,2C949479F38
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+8]
       mov       rcx,[rcx]
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 136
```
```assembly
; System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       push      rsi
       sub       rsp,20
       lea       rcx,[MT_System.ArgumentException]
       call      qword ptr [7FFDC7889870]; CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,374C
       call      00007FFDC788A776
       mov       rcx,rax
       call      qword ptr [7FFDC7357E98]; System.Environment.GetResourceFromDefault(System.String)
       mov       rdx,rax
       mov       rcx,rsi
       nop
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rsi
       call      00007FFDC788A76A
       int       3
; Total bytes of code 61
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+3C]
       test      ecx,1600000
       je        near ptr 00007FFDC86A2C22
       mov       rcx,rsi
       nop
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+3C]
       and       ecx,1600000
       cmp       ecx,1000000
       je        near ptr 00007FFDC86A2C1C
       mov       rcx,rsi
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       near ptr 00007FFDC86A2C1C
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
; Total bytes of code 95
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.LockedTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
M00_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 79
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-34],eax
       mov       [rbp-48],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue+<>c__DisplayClass2_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+10]
       mov       [rbp-40],rcx
       cmp       byte ptr [rbp-30],0
       jne       near ptr M03_L03
       lea       rdx,[rbp-30]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task, System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rsi+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue+<>c__DisplayClass2_0.<Execute>b__0(System.Threading.Tasks.Task)
       mov       [rdi+18],rax
       cmp       [r14],r14d
       call      System.Threading.Tasks.TaskScheduler.get_InternalCurrent()
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L00
       mov       rcx,1DE481A1A68
       mov       rbx,[rcx]
M03_L00:
       test      rbx,rbx
       je        short M03_L02
       lea       rcx,[rbp-34]
       mov       dword ptr [rcx],200
       mov       rcx,offset MT_System.Threading.Tasks.ContinuationResultTaskFromTask`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbp-34]
       jmp       short M03_L04
M03_L01:
       or        dword ptr [r15+34],20000000
       jmp       short M03_L05
M03_L02:
       mov       ecx,30
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
M03_L03:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M03_L04:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],ecx
       mov       [rsp+30],rdx
       mov       rcx,r15
       mov       rdx,rdi
       xor       r9d,r9d
       xor       r8d,r8d
       call      System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       call      System.Threading.ExecutionContext.Capture()
       mov       rdi,rax
       test      rdi,rdi
       je        short M03_L01
       mov       rcx,1DE481A1890
       cmp       rdi,[rcx]
       je        short M03_L05
       mov       rcx,r15
       call      System.Threading.Tasks.Task.EnsureContingentPropertiesInitializedUnsafe()
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L05:
       lea       rcx,[r15+40]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsp+20],80000
       mov       rcx,r14
       mov       rdx,r15
       mov       r8,rbx
       xor       r9d,r9d
       call      System.Threading.Tasks.Task.ContinueWithCore(System.Threading.Tasks.Task, System.Threading.Tasks.TaskScheduler, System.Threading.CancellationToken, System.Threading.Tasks.TaskContinuationOptions)
       mov       rcx,r15
       call      System.Threading.Tasks.TaskExtensions.Unwrap(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       rdi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-30],0
       je        short M03_L06
       mov       rcx,[rbp-40]
       call      System.Threading.Monitor.Exit(System.Object)
M03_L06:
       mov       rax,rdi
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-30],0
       je        short M03_L07
       mov       rcx,[rbp-40]
       call      System.Threading.Monitor.Exit(System.Object)
M03_L07:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 467
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,1DE481A7418
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1DE481A7410
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,1DE481A7418
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       mov       rcx,[rsi+8]
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 119
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M05_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M05_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L02
M05_L01:
       add       rsp,20
       pop       rsi
       ret
M05_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M05_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.LockedTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFC9D3BAA68
       mov       [rdi+18],rcx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC9D3B16C0]; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
M00_L00:
       call      qword ptr [7FFC9D10B630]
       int       3
; Total bytes of code 81
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFC9D5673C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rsi
       sub       rsp,30
       mov       rax,18755406438
       mov       rdx,[rax]
       mov       [rsp+28],rcx
       test      rdx,rdx
       jne       short M03_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,18755406430
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFC9D566468
       mov       [rsi+18],rdx
       mov       rcx,18755406438
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
M03_L00:
       mov       rcx,[rsp+28]
       mov       rcx,[rcx+8]
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rsi
       jmp       qword ptr [rax+18]
; Total bytes of code 126
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC9D339AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFC9D339270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFC9D5673D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.LockedTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       nop       dword ptr [rax+rax]
       mov       rax,rcx
       ret
; Total bytes of code 9
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       sub       rsp,28
       nop
       mov       rcx,[rcx]
       mov       eax,[rcx+3C]
       and       eax,11000000
       cmp       eax,1000000
       je        short M02_L00
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-38],rax
       mov       [rbp-40],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue+<>c__DisplayClass2_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+10]
       mov       [rbp-30],rax
       xor       eax,eax
       mov       [rbp-28],eax
       cmp       byte ptr [rbp-28],0
       je        short M03_L00
       call      System.Threading.Monitor.ThrowLockTakenException()
M03_L00:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_MON_ENTER
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task, mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rsi+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue+<>c__DisplayClass2_0.<Execute>b__0(System.Threading.Tasks.Task)
       mov       [rdi+18],rcx
       mov       rcx,r14
       mov       r8,rdi
       mov       rdx,offset MD_System.Threading.Tasks.Task.ContinueWith[[System.Threading.Tasks.Task, mscorlib]](System.Func`2<System.Threading.Tasks.Task,System.Threading.Tasks.Task>, System.Threading.Tasks.TaskContinuationOptions)
       mov       r9d,80000
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.ContinueWith[[System.__Canon, mscorlib]](System.Func`2<System.Threading.Tasks.Task,System.__Canon>, System.Threading.Tasks.TaskContinuationOptions)
       mov       rcx,rax
       call      System.Threading.Tasks.TaskExtensions.Unwrap(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbp-38],rax
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,rsp
       call      M03_L01
       nop
       mov       rax,[rbp-38]
       lea       rsp,[rbp-20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L01:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       byte ptr [rbp-28],0
       je        short M03_L02
       mov       rcx,[rbp-30]
       call      System.Threading.Monitor.Exit(System.Object)
M03_L02:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 278
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,1E424A19F38
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1E424A19F30
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,1E424A19F38
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+8]
       mov       rcx,[rcx]
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 136
```
```assembly
; System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       push      rsi
       sub       rsp,20
       lea       rcx,[MT_System.ArgumentException]
       call      qword ptr [7FFDC7889870]; CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,374C
       call      00007FFDC788A776
       mov       rcx,rax
       call      qword ptr [7FFDC7357E98]; System.Environment.GetResourceFromDefault(System.String)
       mov       rdx,rax
       mov       rcx,rsi
       nop
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rsi
       call      00007FFDC788A76A
       int       3
; Total bytes of code 61
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+3C]
       test      ecx,1600000
       je        near ptr 00007FFDC86A2C22
       mov       rcx,rsi
       nop
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+3C]
       and       ecx,1600000
       cmp       ecx,1000000
       je        near ptr 00007FFDC86A2C1C
       mov       rcx,rsi
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       near ptr 00007FFDC86A2C1C
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
; Total bytes of code 95
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.LockedTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       nop       dword ptr [rax+rax]
       mov       rax,rcx
       ret
; Total bytes of code 9
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       sub       rsp,28
       nop
       mov       rcx,[rcx]
       mov       eax,[rcx+3C]
       and       eax,11000000
       cmp       eax,1000000
       je        short M02_L00
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-38],rax
       mov       [rbp-40],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue+<>c__DisplayClass2_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+10]
       mov       [rbp-30],rax
       xor       eax,eax
       mov       [rbp-28],eax
       cmp       byte ptr [rbp-28],0
       je        short M03_L00
       call      System.Threading.Monitor.ThrowLockTakenException()
M03_L00:
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_MON_ENTER
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task, mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rsi+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue+<>c__DisplayClass2_0.<Execute>b__0(System.Threading.Tasks.Task)
       mov       [rdi+18],rcx
       mov       rcx,r14
       mov       r8,rdi
       mov       rdx,offset MD_System.Threading.Tasks.Task.ContinueWith[[System.Threading.Tasks.Task, mscorlib]](System.Func`2<System.Threading.Tasks.Task,System.Threading.Tasks.Task>, System.Threading.Tasks.TaskContinuationOptions)
       mov       r9d,80000
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.ContinueWith[[System.__Canon, mscorlib]](System.Func`2<System.Threading.Tasks.Task,System.__Canon>, System.Threading.Tasks.TaskContinuationOptions)
       mov       rcx,rax
       call      System.Threading.Tasks.TaskExtensions.Unwrap(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbp-38],rax
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,rsp
       call      M03_L01
       nop
       mov       rax,[rbp-38]
       lea       rsp,[rbp-20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L01:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       byte ptr [rbp-28],0
       je        short M03_L02
       mov       rcx,[rbp-30]
       call      System.Threading.Monitor.Exit(System.Object)
M03_L02:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 278
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,2035B1F9F38
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2035B1F9F30
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,2035B1F9F38
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+8]
       mov       rcx,[rcx]
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 136
```
```assembly
; System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       push      rsi
       sub       rsp,20
       lea       rcx,[MT_System.ArgumentException]
       call      qword ptr [7FFDC7889870]; CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,374C
       call      00007FFDC788A776
       mov       rcx,rax
       call      qword ptr [7FFDC7357E98]; System.Environment.GetResourceFromDefault(System.String)
       mov       rdx,rax
       mov       rcx,rsi
       nop
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rsi
       call      00007FFDC788A76A
       int       3
; Total bytes of code 61
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+3C]
       test      ecx,1600000
       je        near ptr 00007FFDC86A2C22
       mov       rcx,rsi
       nop
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+3C]
       and       ecx,1600000
       cmp       ecx,1000000
       je        near ptr 00007FFDC86A2C1C
       mov       rcx,rsi
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       near ptr 00007FFDC86A2C1C
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
; Total bytes of code 95
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.ChannelTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+20]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.ChannelTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
M00_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 79
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; Benchmarks.Synchronization.TaskQueue.Impl.ChannelTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+20],rcx
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[Benchmarks.Synchronization.TaskQueue.Impl.ChannelTaskQueue+<Execute>d__4, Benchmarks]](<Execute>d__4 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,58
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M03_L00
; Total bytes of code 95
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,1BAF73A7418
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1BAF73A7410
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,1BAF73A7418
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       mov       rcx,[rsi+8]
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 119
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M05_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M05_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L02
M05_L01:
       add       rsp,20
       pop       rsi
       ret
M05_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M05_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.ChannelTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+20]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFC9D3EAAB0
       mov       [rdi+18],rcx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC9D3E16C0]; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
M00_L00:
       call      qword ptr [7FFC9D13B630]
       int       3
; Total bytes of code 81
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFC9D5973C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rsi
       sub       rsp,30
       mov       rax,24EEB406438
       mov       rdx,[rax]
       mov       [rsp+28],rcx
       test      rdx,rdx
       jne       short M03_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,24EEB406430
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFC9D596468
       mov       [rsi+18],rdx
       mov       rcx,24EEB406438
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
M03_L00:
       mov       rcx,[rsp+28]
       mov       rcx,[rcx+8]
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rsi
       jmp       qword ptr [rax+18]
; Total bytes of code 126
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC9D369AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFC9D369270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFC9D5973D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.ChannelTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+20]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.ChannelTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       nop       dword ptr [rax+rax]
       mov       rax,rcx
       ret
; Total bytes of code 9
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       sub       rsp,28
       nop
       mov       rcx,[rcx]
       mov       eax,[rcx+3C]
       and       eax,11000000
       cmp       eax,1000000
       je        short M02_L00
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; Benchmarks.Synchronization.TaskQueue.Impl.ChannelTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,68
       vzeroupper
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,12
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       xor       eax,eax
       lea       r8,[rsp+38]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r8],xmm0
       mov       [r8+10],rax
       mov       [rsp+20],rcx
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[Benchmarks.Synchronization.TaskQueue.Impl.ChannelTaskQueue+<Execute>d__4, Benchmarks]](<Execute>d__4 ByRef)
       lea       rcx,[rsp+38]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, mscorlib]].get_Task()
       nop
       add       rsp,68
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,2D2A6A89F38
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2D2A6A89F30
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,2D2A6A89F38
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+8]
       mov       rcx,[rcx]
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 136
```
```assembly
; System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       push      rsi
       sub       rsp,20
       lea       rcx,[MT_System.ArgumentException]
       call      qword ptr [7FFDC7889870]; CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,374C
       call      00007FFDC788A776
       mov       rcx,rax
       call      qword ptr [7FFDC7357E98]; System.Environment.GetResourceFromDefault(System.String)
       mov       rdx,rax
       mov       rcx,rsi
       nop
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rsi
       call      00007FFDC788A76A
       int       3
; Total bytes of code 61
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+3C]
       test      ecx,1600000
       je        near ptr 00007FFDC86A2C22
       mov       rcx,rsi
       nop
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+3C]
       and       ecx,1600000
       cmp       ecx,1000000
       je        near ptr 00007FFDC86A2C1C
       mov       rcx,rsi
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       near ptr 00007FFDC86A2C1C
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
; Total bytes of code 95
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.ChannelTaskQueue()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+20]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.ChannelTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       nop       dword ptr [rax+rax]
       mov       rax,rcx
       ret
; Total bytes of code 9
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       sub       rsp,28
       nop
       mov       rcx,[rcx]
       mov       eax,[rcx+3C]
       and       eax,11000000
       cmp       eax,1000000
       je        short M02_L00
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
M02_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; Benchmarks.Synchronization.TaskQueue.Impl.ChannelTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,68
       vzeroupper
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,12
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       xor       eax,eax
       lea       r8,[rsp+38]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r8],xmm0
       mov       [r8+10],rax
       mov       [rsp+20],rcx
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[Benchmarks.Synchronization.TaskQueue.Impl.ChannelTaskQueue+<Execute>d__4, Benchmarks]](<Execute>d__4 ByRef)
       lea       rcx,[rsp+38]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, mscorlib]].get_Task()
       nop
       add       rsp,68
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,2E247E09F38
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2E247E09F30
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,2E247E09F38
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+8]
       mov       rcx,[rcx]
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 136
```
```assembly
; System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       push      rsi
       sub       rsp,20
       lea       rcx,[MT_System.ArgumentException]
       call      qword ptr [7FFDC7889870]; CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,374C
       call      00007FFDC788A776
       mov       rcx,rax
       call      qword ptr [7FFDC7357E98]; System.Environment.GetResourceFromDefault(System.String)
       mov       rdx,rax
       mov       rcx,rsi
       nop
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rsi
       call      00007FFDC788A76A
       int       3
; Total bytes of code 61
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+3C]
       test      ecx,1600000
       je        near ptr 00007FFDC86A2C22
       mov       rcx,rsi
       nop
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+3C]
       and       ecx,1600000
       cmp       ecx,1000000
       je        near ptr 00007FFDC86A2C1C
       mov       rcx,rsi
       nop
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       near ptr 00007FFDC86A2C1C
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       int       3
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
; Total bytes of code 95
```

