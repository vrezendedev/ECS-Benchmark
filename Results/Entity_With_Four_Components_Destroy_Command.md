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
| Theia_C4  | 1        |     1.569 μs |     0.48 KB |
| Arch_C4   | 1        |     3.820 μs |     0.46 KB |
| Friflo_C4 | 1        |     3.069 μs |     0.66 KB |
| Theia_C4  | 5        |     3.127 μs |     0.58 KB |
| Arch_C4   | 5        |     6.833 μs |     0.58 KB |
| Friflo_C4 | 5        |     4.200 μs |      0.8 KB |
| Theia_C4  | 10       |     4.247 μs |     1.33 KB |
| Arch_C4   | 10       |     9.850 μs |     0.79 KB |
| Friflo_C4 | 10       |     5.223 μs |     1.04 KB |
| Theia_C4  | 25       |     8.671 μs |     3.81 KB |
| Arch_C4   | 25       |    18.153 μs |     1.19 KB |
| Friflo_C4 | 25       |     7.862 μs |     1.46 KB |
| Theia_C4  | 50       |    13.740 μs |     6.53 KB |
| Arch_C4   | 50       |    32.569 μs |     1.96 KB |
| Friflo_C4 | 50       |    11.879 μs |     2.26 KB |
| Theia_C4  | 100      |    24.329 μs |    11.97 KB |
| Arch_C4   | 100      |    69.419 μs |     3.48 KB |
| Friflo_C4 | 100      |    20.200 μs |      3.8 KB |
| Theia_C4  | 200      |    44.994 μs |    22.56 KB |
| Arch_C4   | 200      |    75.453 μs |     6.51 KB |
| Friflo_C4 | 200      |    36.020 μs |     6.85 KB |
| Theia_C4  | 400      |    87.593 μs |    44.59 KB |
| Arch_C4   | 400      |   144.819 μs |    16.88 KB |
| Friflo_C4 | 400      |    73.562 μs |     12.9 KB |
| Theia_C4  | 800      |   182.033 μs |    88.42 KB |
| Arch_C4   | 800      |   248.315 μs |    32.95 KB |
| Friflo_C4 | 800      |   160.487 μs |    25.27 KB |
| Theia_C4  | 1600     |   261.313 μs |   175.42 KB |
| Arch_C4   | 1600     |   590.163 μs |    65.26 KB |
| Friflo_C4 | 1600     |   277.371 μs |    49.32 KB |
| Theia_C4  | 3200     |   370.747 μs |    366.1 KB |
| Arch_C4   | 3200     |   865.953 μs |   129.94 KB |
| Friflo_C4 | 3200     |   616.369 μs |    98.02 KB |
| Theia_C4  | 6400     |   776.794 μs |   729.77 KB |
| Arch_C4   | 6400     | 2,015.325 μs |   257.68 KB |
| Friflo_C4 | 6400     |   980.350 μs |   193.79 KB |
| Theia_C4  | 16000    | 1,453.044 μs |   1758.1 KB |
| Arch_C4   | 16000    | 4,700.519 μs |   514.03 KB |
| Friflo_C4 | 16000    | 1,658.256 μs |   386.12 KB |
| Theia_C4  | 32000    | 1,720.156 μs |   3514.1 KB |
| Arch_C4   | 32000    | 3,120.071 μs |  1026.05 KB |
| Friflo_C4 | 32000    |   818.821 μs |   770.21 KB |
| Theia_C4  | 64000    | 3,507.593 μs |  7025.45 KB |
| Arch_C4   | 64000    | 6,241.286 μs |  2050.03 KB |
| Friflo_C4 | 64000    | 1,652.969 μs |  1538.21 KB |
| Theia_C4  | 100000   | 5,534.927 μs | 11424.77 KB |
| Arch_C4   | 100000   | 9,850.206 μs |  4097.73 KB |
| Friflo_C4 | 100000   | 2,532.940 μs |  3073.98 KB |
