```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5555/22H2/2022Update)
AMD Ryzen 5 5600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  Job-XJEJRV : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=16  UnrollFactor=1  

```
| Method                 | Mean      | Allocated |
|----------------------- |----------:|----------:|
| TheiaECS_WorldCreation |  4.343 μs |  55.55 KB |
| Arch_WorldCreation     | 14.106 μs |  41.35 KB |
| Fennecs_WorldCreation  | 46.600 μs | 165.36 KB |
| Friflo_WorldCreation   |  2.431 μs |   7.02 KB |
