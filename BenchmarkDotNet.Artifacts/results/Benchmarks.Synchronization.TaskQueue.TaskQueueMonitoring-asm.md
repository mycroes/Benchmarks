## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.InterLockedExchangeTaskQueue()
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
       jmp       near ptr Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
       mov       rcx,20898001A68
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
       mov       rcx,20898001890
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8d,1
       xor       r9d,r9d
       call      System.Threading.EventWaitHandle.CreateEventCore(Boolean, System.Threading.EventResetMode, System.String, Boolean ByRef)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+RangeIterator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+8],eax
       xor       ecx,ecx
       mov       [rsi+14],ecx
       mov       dword ptr [rsi+18],8
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       mov       [rbx+18],r8
       mov       r8,rbx
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,20898007430
       mov       r8,[rcx]
       test      r8,r8
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20898007420
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbx+18],rdx
       mov       rcx,20898007430
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M04_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 354
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.InterLockedExchangeTaskQueue()
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
       mov       rcx,7FFC9D3CAA08
       mov       [rdi+18],rcx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC9D3C16C0]; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
       jmp       qword ptr [7FFC9D5776C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FFC9D577C00]; System.Threading.EventWaitHandle.CreateEventCore(Boolean, System.Threading.EventResetMode, System.String, Boolean ByRef)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+RangeIterator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+8],eax
       xor       ecx,ecx
       mov       [rsi+14],ecx
       mov       dword ptr [rsi+18],8
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,7FFC9D576750
       mov       [rbx+18],r8
       mov       r8,rbx
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      qword ptr [7FFC9D5795A0]; System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,1CF92806450
       mov       r8,[rcx]
       test      r8,r8
       jne       short M03_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1CF92806440
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFC9D578618
       mov       [rbx+18],rdx
       mov       rcx,1CF92806450
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M03_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      qword ptr [7FFC9D4D1510]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC9D577C48]; System.Threading.EventWaitHandle.Set()
       mov       rcx,rsi
       call      qword ptr [7FFC9D34B348]; System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 359
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
       call      qword ptr [7FFC9D5776D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.InterLockedExchangeTaskQueue()
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
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEW_CROSSCONTEXT
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.Threading.ManualResetEvent..ctor(Boolean)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       edx,8
       call      System.Linq.Enumerable.Range(Int32, Int32)
       mov       rbx,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,23FDDBE9F50
       mov       r8,[rcx]
       test      r8,r8
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23FDDBE9F40
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbx+18],rdx
       mov       rcx,23FDDBE9F50
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M04_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,rbx
       mov       rax,offset System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 325
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.InterLockedExchangeTaskQueue()
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
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEW_CROSSCONTEXT
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.Threading.ManualResetEvent..ctor(Boolean)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       edx,8
       call      System.Linq.Enumerable.Range(Int32, Int32)
       mov       rbx,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,1921ECF9F50
       mov       r8,[rcx]
       test      r8,r8
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1921ECF9F40
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbx+18],rdx
       mov       rcx,1921ECF9F50
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M04_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,rbx
       mov       rax,offset System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 325
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.InterLockedExchangeTaskQueue()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp-8]
       mov       r8,7FFC9D3EC0C0
       call      qword ptr [7FFC9D13B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC9D3E16C0]; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 84
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
       jmp       qword ptr [7FFC9D55DAC8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+18],rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       call      qword ptr [7FFC9D13B630]
       int       3
; Total bytes of code 44
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M04_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp+10],rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FFC9D55DB40]; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       xor       edx,edx
       call      qword ptr [7FFC9D55F108]; System.Threading.ManualResetEvent..ctor(Boolean)
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       xor       ecx,ecx
       mov       edx,8
       call      qword ptr [7FFC9D2A1240]; System.Linq.Enumerable.Range(Int32, Int32)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-8]
       mov       r8,7FFC9D55CB58
       call      qword ptr [7FFC9D13B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r8,[rbp-20]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      qword ptr [7FFC9D55F6C0]; System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       [rbp-38],rax
       mov       rcx,7FFC9D3C4978
       mov       edx,11
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C0DC406438
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M04_L01
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,7FFC9D3C4978
       mov       edx,11
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1C0DC406428
       mov       rdx,[rdx]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       r8,7FFC9D55E738
       call      qword ptr [7FFC9D13B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FFC9D3C4978
       mov       edx,11
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-58]
       mov       rcx,1C0DC406438
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-58]
       mov       [rbp-48],r8
M04_L01:
       mov       r8,[rbp-48]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      qword ptr [7FFC9D4E3438]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-50],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC9D55F0D8]; System.Threading.EventWaitHandle.Set()
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC9D36B348]; System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 502
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M05_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFCED29BA60]; Precode of System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M05_L00:
       mov       rcx,rsi
       call      qword ptr [7FFCED29B840]; Precode of System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFCED29D738]
M05_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.InterLockedExchangeAwaitTaskQueue()
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
       jmp       near ptr Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8d,1
       xor       r9d,r9d
       call      System.Threading.EventWaitHandle.CreateEventCore(Boolean, System.Threading.EventResetMode, System.String, Boolean ByRef)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+RangeIterator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+8],eax
       xor       ecx,ecx
       mov       [rsi+14],ecx
       mov       dword ptr [rsi+18],8
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       mov       [rbx+18],r8
       mov       r8,rbx
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,25372467430
       mov       r8,[rcx]
       test      r8,r8
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25372467420
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbx+18],rdx
       mov       rcx,25372467430
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M04_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 354
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.InterLockedExchangeAwaitTaskQueue()
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
       mov       rcx,7FFC9D3EAA38
       mov       [rdi+18],rcx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC9D3E16C0]; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
       jmp       qword ptr [7FFC9D5976C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FFC9D597C00]; System.Threading.EventWaitHandle.CreateEventCore(Boolean, System.Threading.EventResetMode, System.String, Boolean ByRef)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+RangeIterator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+8],eax
       xor       ecx,ecx
       mov       [rsi+14],ecx
       mov       dword ptr [rsi+18],8
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,7FFC9D596750
       mov       [rbx+18],r8
       mov       r8,rbx
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      qword ptr [7FFC9D5995A0]; System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,28707C06450
       mov       r8,[rcx]
       test      r8,r8
       jne       short M03_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28707C06440
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFC9D598618
       mov       [rbx+18],rdx
       mov       rcx,28707C06450
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M03_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      qword ptr [7FFC9D4F1510]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC9D597C48]; System.Threading.EventWaitHandle.Set()
       mov       rcx,rsi
       call      qword ptr [7FFC9D36B348]; System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 359
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
       call      qword ptr [7FFC9D5976D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.InterLockedExchangeAwaitTaskQueue()
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
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEW_CROSSCONTEXT
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.Threading.ManualResetEvent..ctor(Boolean)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       edx,8
       call      System.Linq.Enumerable.Range(Int32, Int32)
       mov       rbx,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,19C50AD9F50
       mov       r8,[rcx]
       test      r8,r8
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,19C50AD9F40
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbx+18],rdx
       mov       rcx,19C50AD9F50
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M04_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,rbx
       mov       rax,offset System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 325
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.InterLockedExchangeAwaitTaskQueue()
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
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEW_CROSSCONTEXT
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.Threading.ManualResetEvent..ctor(Boolean)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       edx,8
       call      System.Linq.Enumerable.Range(Int32, Int32)
       mov       rbx,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,1D266A99F50
       mov       r8,[rcx]
       test      r8,r8
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D266A99F40
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbx+18],rdx
       mov       rcx,1D266A99F50
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M04_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,rbx
       mov       rax,offset System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 325
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.InterLockedExchangeAwaitTaskQueue()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rcx,[rbp-8]
       mov       r8,7FFC9D3EC0F0
       call      qword ptr [7FFC9D13B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC9D3E16C0]; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 84
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
       jmp       qword ptr [7FFC9D55DAC8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rsi+8]
       call      qword ptr [7FFCED2897A8]; CORINFO_HELP_ASSIGN_REF
       mov       [rsi+18],rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       call      qword ptr [7FFCED295870]
       int       3
; Total bytes of code 45
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M04_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp+10],rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FFC9D55DB40]; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       xor       edx,edx
       call      qword ptr [7FFC9D55F108]; System.Threading.ManualResetEvent..ctor(Boolean)
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       xor       ecx,ecx
       mov       edx,8
       call      qword ptr [7FFC9D2A1240]; System.Linq.Enumerable.Range(Int32, Int32)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-8]
       mov       r8,7FFC9D55CB58
       call      qword ptr [7FFC9D13B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r8,[rbp-20]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      qword ptr [7FFC9D55F6C0]; System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       [rbp-38],rax
       mov       rcx,7FFC9D3C4978
       mov       edx,11
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27F79C06438
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M04_L01
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,7FFC9D3C4978
       mov       edx,11
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,27F79C06428
       mov       rdx,[rdx]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       r8,7FFC9D55E738
       call      qword ptr [7FFC9D13B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FFC9D3C4978
       mov       edx,11
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-58]
       mov       rcx,27F79C06438
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-58]
       mov       [rbp-48],r8
M04_L01:
       mov       r8,[rbp-48]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      qword ptr [7FFC9D4E3438]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-50],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC9D55F0D8]; System.Threading.EventWaitHandle.Set()
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC9D36B348]; System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 502
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M05_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFCED29BA60]; Precode of System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M05_L00:
       mov       rcx,rsi
       call      qword ptr [7FFCED29B840]; Precode of System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFCED29D738]
M05_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.LockedTaskQueue()
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
       jmp       near ptr Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
       mov       rcx,26430861A68
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
       mov       rcx,26430861890
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8d,1
       xor       r9d,r9d
       call      System.Threading.EventWaitHandle.CreateEventCore(Boolean, System.Threading.EventResetMode, System.String, Boolean ByRef)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+RangeIterator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+8],eax
       xor       ecx,ecx
       mov       [rsi+14],ecx
       mov       dword ptr [rsi+18],8
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       mov       [rbx+18],r8
       mov       r8,rbx
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,26430867430
       mov       r8,[rcx]
       test      r8,r8
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,26430867420
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbx+18],rdx
       mov       rcx,26430867430
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M04_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 354
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.LockedTaskQueue()
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
       mov       rcx,7FFC9D3FAA68
       mov       [rdi+18],rcx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC9D3F16C0]; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
M00_L00:
       call      qword ptr [7FFC9D14B630]
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
       jmp       qword ptr [7FFC9D5A76C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FFC9D5A7C00]; System.Threading.EventWaitHandle.CreateEventCore(Boolean, System.Threading.EventResetMode, System.String, Boolean ByRef)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+RangeIterator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+8],eax
       xor       ecx,ecx
       mov       [rsi+14],ecx
       mov       dword ptr [rsi+18],8
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,7FFC9D5A6750
       mov       [rbx+18],r8
       mov       r8,rbx
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      qword ptr [7FFC9D5A95A0]; System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,210D1406450
       mov       r8,[rcx]
       test      r8,r8
       jne       short M03_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,210D1406440
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFC9D5A8618
       mov       [rbx+18],rdx
       mov       rcx,210D1406450
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M03_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      qword ptr [7FFC9D501510]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC9D5A7C48]; System.Threading.EventWaitHandle.Set()
       mov       rcx,rsi
       call      qword ptr [7FFC9D37B348]; System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 359
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
       call      qword ptr [7FFC9D379AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFC9D379270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFC9D5A76D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.LockedTaskQueue()
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
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEW_CROSSCONTEXT
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.Threading.ManualResetEvent..ctor(Boolean)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       edx,8
       call      System.Linq.Enumerable.Range(Int32, Int32)
       mov       rbx,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,17FB6D59F50
       mov       r8,[rcx]
       test      r8,r8
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,17FB6D59F40
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbx+18],rdx
       mov       rcx,17FB6D59F50
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M04_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,rbx
       mov       rax,offset System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 325
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.LockedTaskQueue()
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
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEW_CROSSCONTEXT
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.Threading.ManualResetEvent..ctor(Boolean)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       edx,8
       call      System.Linq.Enumerable.Range(Int32, Int32)
       mov       rbx,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,1D9D2DE9F50
       mov       r8,[rcx]
       test      r8,r8
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D9D2DE9F40
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbx+18],rdx
       mov       rcx,1D9D2DE9F50
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M04_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,rbx
       mov       rax,offset System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 325
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.LockedTaskQueue()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+18]
       mov       rcx,[rbp-8]
       mov       r8,7FFC9D3EC120
       call      qword ptr [7FFC9D13B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC9D3E16C0]; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 84
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
       jmp       qword ptr [7FFC9D55DAC8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+18],rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       call      qword ptr [7FFC9D13B630]
       int       3
; Total bytes of code 44
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M04_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp+10],rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FFC9D55DB40]; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       xor       edx,edx
       call      qword ptr [7FFC9D55F108]; System.Threading.ManualResetEvent..ctor(Boolean)
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       xor       ecx,ecx
       mov       edx,8
       call      qword ptr [7FFC9D2A1240]; System.Linq.Enumerable.Range(Int32, Int32)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-8]
       mov       r8,7FFC9D55CB58
       call      qword ptr [7FFC9D13B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r8,[rbp-20]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      qword ptr [7FFC9D55F6C0]; System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       [rbp-38],rax
       mov       rcx,7FFC9D3C4978
       mov       edx,11
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23252C06438
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M04_L01
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,7FFC9D3C4978
       mov       edx,11
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,23252C06428
       mov       rdx,[rdx]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       r8,7FFC9D55E738
       call      qword ptr [7FFC9D13B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FFC9D3C4978
       mov       edx,11
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-58]
       mov       rcx,23252C06438
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-58]
       mov       [rbp-48],r8
M04_L01:
       mov       r8,[rbp-48]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      qword ptr [7FFC9D4E3438]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-50],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC9D55F0D8]; System.Threading.EventWaitHandle.Set()
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC9D36B348]; System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 502
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M05_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFCED29BA60]; Precode of System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M05_L00:
       mov       rcx,rsi
       call      qword ptr [7FFCED29B840]; Precode of System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFCED29D738]
M05_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.ChannelTaskQueue()
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
       jmp       near ptr Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8d,1
       xor       r9d,r9d
       call      System.Threading.EventWaitHandle.CreateEventCore(Boolean, System.Threading.EventResetMode, System.String, Boolean ByRef)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+RangeIterator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+8],eax
       xor       ecx,ecx
       mov       [rsi+14],ecx
       mov       dword ptr [rsi+18],8
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       mov       [rbx+18],r8
       mov       r8,rbx
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,1A243067430
       mov       r8,[rcx]
       test      r8,r8
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A243067420
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbx+18],rdx
       mov       rcx,1A243067430
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M04_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 354
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.ChannelTaskQueue()
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
       mov       rcx,7FFC9D3CAAB0
       mov       [rdi+18],rcx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC9D3C16C0]; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
       jmp       qword ptr [7FFC9D5776C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FFC9D577C00]; System.Threading.EventWaitHandle.CreateEventCore(Boolean, System.Threading.EventResetMode, System.String, Boolean ByRef)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+RangeIterator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+8],eax
       xor       ecx,ecx
       mov       [rsi+14],ecx
       mov       dword ptr [rsi+18],8
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,7FFC9D576750
       mov       [rbx+18],r8
       mov       r8,rbx
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      qword ptr [7FFC9D5795A0]; System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,1C03C406450
       mov       r8,[rcx]
       test      r8,r8
       jne       short M03_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C03C406440
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFC9D578618
       mov       [rbx+18],rdx
       mov       rcx,1C03C406450
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M03_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      qword ptr [7FFC9D4D1510]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC9D577C48]; System.Threading.EventWaitHandle.Set()
       mov       rcx,rsi
       call      qword ptr [7FFC9D34B348]; System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 359
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
       call      qword ptr [7FFC9D5776D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET Framework 4.8 (4.8.4614.0), X64 RyuJIT VectorSize=256
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.ChannelTaskQueue()
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
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEW_CROSSCONTEXT
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.Threading.ManualResetEvent..ctor(Boolean)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       edx,8
       call      System.Linq.Enumerable.Range(Int32, Int32)
       mov       rbx,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,1EF10009F50
       mov       r8,[rcx]
       test      r8,r8
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1EF10009F40
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbx+18],rdx
       mov       rcx,1EF10009F50
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M04_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,rbx
       mov       rax,offset System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 325
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.ChannelTaskQueue()
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
       mov       rax,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
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
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEW_CROSSCONTEXT
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.Threading.ManualResetEvent..ctor(Boolean)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       edx,8
       call      System.Linq.Enumerable.Range(Int32, Int32)
       mov       rbx,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       rsi,rax
       mov       rcx,21DBC0A9F50
       mov       r8,[rcx]
       test      r8,r8
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21DBC0A9F40
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M04_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       mov       [rbx+18],rdx
       mov       rcx,21DBC0A9F50
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M04_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, mscorlib]], mscorlib],[System.Threading.Tasks.Task, mscorlib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, mscorlib],[System.__Canon, mscorlib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,rbx
       mov       rax,offset System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 325
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.ChannelTaskQueue()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,offset MT_System.Func`2[[System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       rcx,[rbp-8]
       mov       r8,7FFC9D3EC168
       call      qword ptr [7FFC9D13B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC9D3E16C0]; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 84
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
       jmp       qword ptr [7FFC9D55DAC8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+18],rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L00:
       call      qword ptr [7FFC9D13B630]
       int       3
; Total bytes of code 44
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M04_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp+10],rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FFC9D55DB40]; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ManualResetEvent
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       xor       edx,edx
       call      qword ptr [7FFC9D55F108]; System.Threading.ManualResetEvent..ctor(Boolean)
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       xor       ecx,ecx
       mov       edx,8
       call      qword ptr [7FFC9D2A1240]; System.Linq.Enumerable.Range(Int32, Int32)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-8]
       mov       r8,7FFC9D55CB58
       call      qword ptr [7FFC9D13B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r8,[rbp-20]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      qword ptr [7FFC9D55F6C0]; System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       [rbp-38],rax
       mov       rcx,7FFC9D3C4978
       mov       edx,11
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D5DF806438
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M04_L01
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,7FFC9D3C4978
       mov       edx,11
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1D5DF806428
       mov       rdx,[rdx]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       r8,7FFC9D55E738
       call      qword ptr [7FFC9D13B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FFC9D3C4978
       mov       edx,11
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-58]
       mov       rcx,1D5DF806438
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-58]
       mov       [rbp-48],r8
M04_L01:
       mov       r8,[rbp-48]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      qword ptr [7FFC9D4E3438]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-50],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC9D55F0D8]; System.Threading.EventWaitHandle.Set()
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC9D36B348]; System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 502
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M05_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFCED29BA60]; Precode of System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M05_L00:
       mov       rcx,rsi
       call      qword ptr [7FFCED29B840]; Precode of System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFCED29D738]
M05_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

