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
| Theia_C1  | 1        |     1.562 μs |     0.48 KB |
| Arch_C1   | 1        |     3.721 μs |     0.46 KB |
| Friflo_C1 | 1        |     3.027 μs |     0.66 KB |
| Theia_C1  | 5        |     2.829 μs |     0.58 KB |
| Arch_C1   | 5        |     6.653 μs |     0.58 KB |
| Friflo_C1 | 5        |     4.047 μs |      0.8 KB |
| Theia_C1  | 10       |     3.700 μs |     1.33 KB |
| Arch_C1   | 10       |     9.429 μs |     0.51 KB |
| Friflo_C1 | 10       |     4.867 μs |     1.04 KB |
| Theia_C1  | 25       |     7.136 μs |     3.81 KB |
| Arch_C1   | 25       |    17.500 μs |     1.19 KB |
| Friflo_C1 | 25       |     6.743 μs |     1.18 KB |
| Theia_C1  | 50       |    11.238 μs |     6.53 KB |
| Arch_C1   | 50       |    30.163 μs |     1.96 KB |
| Friflo_C1 | 50       |     9.787 μs |     2.26 KB |
| Theia_C1  | 100      |    19.331 μs |    11.97 KB |
| Arch_C1   | 100      |    55.400 μs |     3.48 KB |
| Friflo_C1 | 100      |    15.606 μs |      3.8 KB |
| Theia_C1  | 200      |    33.180 μs |    22.84 KB |
| Arch_C1   | 200      |    72.473 μs |     6.51 KB |
| Friflo_C1 | 200      |    26.680 μs |     6.85 KB |
| Theia_C1  | 400      |    64.315 μs |    44.59 KB |
| Arch_C1   | 400      |   145.843 μs |    16.88 KB |
| Friflo_C1 | 400      |    54.606 μs |     12.9 KB |
| Theia_C1  | 800      |   131.644 μs |    88.09 KB |
| Arch_C1   | 800      |   235.086 μs |    32.91 KB |
| Friflo_C1 | 800      |   117.375 μs |    24.95 KB |
| Theia_C1  | 1600     |   131.053 μs |   175.42 KB |
| Arch_C1   | 1600     |   441.231 μs |    65.26 KB |
| Friflo_C1 | 1600     |   234.047 μs |    49.32 KB |
| Theia_C1  | 3200     |   197.864 μs |    366.1 KB |
| Arch_C1   | 3200     |   817.607 μs |   129.94 KB |
| Friflo_C1 | 3200     |   361.536 μs |    98.02 KB |
| Theia_C1  | 6400     |   359.580 μs |    730.1 KB |
| Arch_C1   | 6400     | 1,619.246 μs |   257.96 KB |
| Friflo_C1 | 6400     |   748.625 μs |   194.07 KB |
| Theia_C1  | 16000    | 1,511.467 μs |   1758.1 KB |
| Arch_C1   | 16000    | 1,371.847 μs |   513.98 KB |
| Friflo_C1 | 16000    |   404.425 μs |   386.12 KB |
| Theia_C1  | 32000    | 1,214.750 μs |  3513.82 KB |
| Arch_C1   | 32000    | 2,675.656 μs |  1025.73 KB |
| Friflo_C1 | 32000    | 2,230.125 μs |   769.88 KB |
| Theia_C1  | 64000    | 2,377.993 μs |  7025.49 KB |
| Arch_C1   | 64000    | 5,353.129 μs |  2050.08 KB |
| Friflo_C1 | 64000    | 1,494.556 μs |  1538.21 KB |
| Theia_C1  | 100000   | 3,757.912 μs | 11424.49 KB |
| Arch_C1   | 100000   | 8,398.913 μs |  4096.79 KB |
| Friflo_C1 | 100000   | 2,374.231 μs |  3073.65 KB |
