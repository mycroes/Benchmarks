using BenchmarkDotNet.Running;

BenchmarkSwitcher.FromAssembly(System.Reflection.MethodBase.GetCurrentMethod()!.DeclaringType!.Assembly).Run(args);
