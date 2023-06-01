# Benchmarks
Benchmarks of various solutions in C#

Running benchmarks
==================
Interactive selection:
```ps1
dotnet run -c Release --project Benchmarks -- -m -t -d
```

Matching filter:
```ps1
dotnet run -c Release --project Benchmarks -- -m -t -d -f '*TaskQueue*'
```

Credits, sources and inspiration
================================
* [RabbitMQ .NET Client](https://github.com/rabbitmq/rabbitmq-dotnet-client) (Serialization using `Unsafe.WriteUnaligned`)
* [@gfoidl](https://github.com/gfoidl) (Awareness, advice)
