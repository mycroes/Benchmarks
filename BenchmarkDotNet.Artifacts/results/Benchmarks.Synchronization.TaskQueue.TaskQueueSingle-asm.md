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
       mov       rcx,offset Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue+<>c__DisplayClass1_0.<Execute>b__0(System.Threading.Tasks.Task)
       mov       [rbp+18],rcx
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Threading.Tasks.Task.ContinueWith(System.Action`1<System.Threading.Tasks.Task>)
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 210
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,2C668397630
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2C668397628
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,2C668397630
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
       mov       rax,1A2D01E7630
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1A2D01E7628
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,1A2D01E7630
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
       mov       rcx,25D98001A68
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
       mov       rcx,25D98001890
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
       xor       ecx,ecx
       mov       [rsp+20],ecx
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
; Total bytes of code 465
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueSingle.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rax,25D98007630
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,25D98007628
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,25D98007630
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
       mov       rax,15364087630
       mov       rdx,[rax]
       mov       rsi,rcx
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,offset MT_System.Func`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,15364087628
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmarks.Synchronization.TaskQueue.TaskQueueSingle+<>c.<Run>b__8_0()
       mov       [rdi+18],rdx
       mov       rcx,15364087630
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

