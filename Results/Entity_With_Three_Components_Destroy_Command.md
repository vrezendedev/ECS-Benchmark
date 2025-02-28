```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5555/22H2/2022Update)
AMD Ryzen 5 5600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  Job-XJEJRV : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=16  UnrollFactor=1  

```
| Method    | Entities | Mean         | Allocated   |
|---------- |--------- |-------------:|------------:|
| Theia_C3  | 1        |     1.579 μs |     0.48 KB |
| Arch_C3   | 1        |     3.836 μs |     0.46 KB |
| Friflo_C3 | 1        |     3.079 μs |     0.66 KB |
| Theia_C3  | 5        |     3.060 μs |     0.86 KB |
| Arch_C3   | 5        |     6.631 μs |     0.58 KB |
| Friflo_C3 | 5        |     4.114 μs |      0.8 KB |
| Theia_C3  | 10       |     4.112 μs |     1.33 KB |
| Arch_C3   | 10       |     9.807 μs |     0.79 KB |
| Friflo_C3 | 10       |     5.079 μs |     1.04 KB |
| Theia_C3  | 25       |     8.125 μs |     3.81 KB |
| Arch_C3   | 25       |    18.453 μs |     1.19 KB |
| Friflo_C3 | 25       |     7.300 μs |     1.46 KB |
| Theia_C3  | 50       |    12.940 μs |     6.53 KB |
| Arch_C3   | 50       |    32.773 μs |     1.96 KB |
| Friflo_C3 | 50       |    11.329 μs |     2.26 KB |
| Theia_C3  | 100      |    23.113 μs |    11.97 KB |
| Arch_C3   | 100      |    58.581 μs |     3.48 KB |
| Friflo_C3 | 100      |    18.286 μs |      3.8 KB |
| Theia_C3  | 200      |    42.756 μs |    22.56 KB |
| Arch_C3   | 200      |    73.120 μs |     6.51 KB |
| Friflo_C3 | 200      |    33.469 μs |     6.85 KB |
| Theia_C3  | 400      |    96.531 μs |    44.59 KB |
| Arch_C3   | 400      |   154.967 μs |     16.6 KB |
| Friflo_C3 | 400      |    72.825 μs |     12.9 KB |
| Theia_C3  | 800      |   166.423 μs |    88.09 KB |
| Arch_C3   | 800      |   248.238 μs |    32.91 KB |
| Friflo_C3 | 800      |   132.979 μs |    24.95 KB |
| Theia_C3  | 1600     |   211.271 μs |   175.42 KB |
| Arch_C3   | 1600     |   568.794 μs |    65.26 KB |
| Friflo_C3 | 1600     |   237.812 μs |    49.32 KB |
| Theia_C3  | 3200     |   309.247 μs |    366.1 KB |
| Arch_C3   | 3200     |   842.853 μs |   129.94 KB |
| Friflo_C3 | 3200     |   388.831 μs |    97.74 KB |
| Theia_C3  | 6400     |   695.688 μs |    730.1 KB |
| Arch_C3   | 6400     | 2,136.819 μs |   257.96 KB |
| Friflo_C3 | 6400     |   180.573 μs |   194.07 KB |
| Theia_C3  | 16000    | 2,179.947 μs |  1757.82 KB |
| Arch_C3   | 16000    | 3,778.213 μs |   513.66 KB |
| Friflo_C3 | 16000    | 1,945.056 μs |   385.84 KB |
| Theia_C3  | 32000    | 1,709.354 μs |  3514.15 KB |
| Arch_C3   | 32000    | 3,006.423 μs |  1026.05 KB |
| Friflo_C3 | 32000    |   799.860 μs |   770.21 KB |
| Theia_C3  | 64000    | 3,122.644 μs |  7025.82 KB |
| Arch_C3   | 64000    | 5,910.886 μs |  2050.36 KB |
| Friflo_C3 | 64000    | 1,608.114 μs |  1538.21 KB |
| Theia_C3  | 100000   | 4,948.627 μs | 11424.49 KB |
| Arch_C3   | 100000   | 9,279.564 μs |  4097.12 KB |
| Friflo_C3 | 100000   | 2,461.420 μs |  3073.65 KB |
