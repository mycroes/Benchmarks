## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp-8]
       call      Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 82
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       sub       rsp,28
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       call      qword ptr [7FFA1F0A2510]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
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
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+18],rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 43
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M05_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M05_L00
       mov       [rbp+10],rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0..ctor()
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
       call      System.Threading.ManualResetEvent..ctor(Boolean)
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       xor       ecx,ecx
       mov       edx,8
       call      System.Linq.Enumerable.Range(Int32, Int32)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-8]
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r8,[rbp-20]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       [rbp-38],rax
       mov       rcx,7FF9BF812FC8
       mov       edx,0D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B154CB7648
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M05_L01
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,7FF9BF812FC8
       mov       edx,0D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1B154CB7638
       mov       rdx,[rdx]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF9BF812FC8
       mov       edx,0D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B154CB7648
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,[rbp-58]
       mov       [rbp-48],r8
M05_L01:
       mov       r8,[rbp-48]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-50],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,[rbp-50]
       call      System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 493
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M06_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFA1F0A0D28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M06_L00:
       mov       rcx,rsi
       call      qword ptr [7FFA1F0A0B98]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M06_L02
M06_L01:
       add       rsp,20
       pop       rsi
       ret
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FFA1F0A2518]
       jmp       short M06_L01
; Total bytes of code 79
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.Impl.InterLockedExchangeAwaitTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp-8]
       call      Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 82
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
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+18],rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 43
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M05_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M05_L00
       mov       [rbp+10],rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0..ctor()
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
       call      System.Threading.ManualResetEvent..ctor(Boolean)
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       xor       ecx,ecx
       mov       edx,8
       call      System.Linq.Enumerable.Range(Int32, Int32)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-8]
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r8,[rbp-20]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       [rbp-38],rax
       mov       rcx,7FF9BF822FC8
       mov       edx,0D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C750A07648
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M05_L01
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,7FF9BF822FC8
       mov       edx,0D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1C750A07638
       mov       rdx,[rdx]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF9BF822FC8
       mov       edx,0D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C750A07648
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,[rbp-58]
       mov       [rbp-48],r8
M05_L01:
       mov       r8,[rbp-48]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-50],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,[rbp-50]
       call      System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 493
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M06_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFA1F0A0D28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M06_L00:
       mov       rcx,rsi
       call      qword ptr [7FFA1F0A0B98]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M06_L02
M06_L01:
       add       rsp,20
       pop       rsi
       ret
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FFA1F0A2518]
       jmp       short M06_L01
; Total bytes of code 79
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.Impl.LockedTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp-8]
       call      Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 82
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       sub       rsp,28
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       call      qword ptr [7FFA1F0A2510]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       short M02_L00
; Total bytes of code 35
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
       mov       rcx,1BC9E991A68
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
       mov       rcx,1BC9E991890
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
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+18],rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 43
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M05_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M05_L00
       mov       [rbp+10],rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0..ctor()
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
       call      System.Threading.ManualResetEvent..ctor(Boolean)
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       xor       ecx,ecx
       mov       edx,8
       call      System.Linq.Enumerable.Range(Int32, Int32)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-8]
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r8,[rbp-20]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       [rbp-38],rax
       mov       rcx,7FF9BF842FC8
       mov       edx,0D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BC9E997648
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M05_L01
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,7FF9BF842FC8
       mov       edx,0D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1BC9E997638
       mov       rdx,[rdx]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF9BF842FC8
       mov       edx,0D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BC9E997648
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,[rbp-58]
       mov       [rbp-48],r8
M05_L01:
       mov       r8,[rbp-48]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-50],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,[rbp-50]
       call      System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 493
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M06_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFA1F0A0D28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M06_L00:
       mov       rcx,rsi
       call      qword ptr [7FFA1F0A0B98]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M06_L02
M06_L01:
       add       rsp,20
       pop       rsi
       ret
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FFA1F0A2518]
       jmp       short M06_L01
; Total bytes of code 79
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.Impl.ChannelTaskQueue.Execute(System.Func`1<System.Threading.Tasks.Task>)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp-8]
       call      Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 82
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
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+18],rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 43
```
```assembly
; Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring.Run(System.Func`2<System.Func`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M05_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M05_L00
       mov       [rbp+10],rcx
       mov       rcx,offset MT_Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0..ctor()
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
       call      System.Threading.ManualResetEvent..ctor(Boolean)
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       xor       ecx,ecx
       mov       edx,8
       call      System.Linq.Enumerable.Range(Int32, Int32)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-8]
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c__DisplayClass10_0.<Run>b__0(Int32)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r8,[rbp-20]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>)
       call      System.Linq.Enumerable.Select[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, System.Func`2<Int32,System.__Canon>)
       mov       [rbp-38],rax
       mov       rcx,7FF9BF822FC8
       mov       edx,0D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EFDAE47648
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-38]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M05_L01
       mov       rcx,offset MT_System.Func`2[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,7FF9BF822FC8
       mov       edx,0D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1EFDAE47638
       mov       rdx,[rdx]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       r8,offset Benchmarks.Synchronization.TaskQueue.TaskQueueMonitoring+<>c.<Run>b__10_1(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF9BF822FC8
       mov       edx,0D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EFDAE47648
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,[rbp-58]
       mov       [rbp-48],r8
M05_L01:
       mov       r8,[rbp-48]
       mov       rdx,[rbp-40]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Threading.Tasks.Task`1[[System.Threading.Tasks.Task, System.Private.CoreLib]], System.Private.CoreLib],[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>>, System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-50],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      System.Threading.EventWaitHandle.Set()
       mov       rcx,[rbp-50]
       call      System.Threading.Tasks.Task.WhenAll(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 493
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M06_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFA1F0A0D28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M06_L00:
       mov       rcx,rsi
       call      qword ptr [7FFA1F0A0B98]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M06_L02
M06_L01:
       add       rsp,20
       pop       rsi
       ret
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FFA1F0A2518]
       jmp       short M06_L01
; Total bytes of code 79
```

