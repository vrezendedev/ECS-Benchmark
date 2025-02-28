```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5555/22H2/2022Update)
AMD Ryzen 5 5600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  Job-XJEJRV : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=16  UnrollFactor=1  

```
| Method    | Entities | Mean          | Allocated   |
|---------- |--------- |--------------:|------------:|
| Theia_C1  | 1        |      3.769 μs |      0.7 KB |
| Arch_C1   | 1        |     14.979 μs |    41.59 KB |
| Friflo_C1 | 1        |      6.250 μs |     8.12 KB |
| Theia_C1  | 5        |      5.723 μs |     1.08 KB |
| Arch_C1   | 5        |     19.867 μs |    42.09 KB |
| Friflo_C1 | 5        |      9.244 μs |     8.59 KB |
| Theia_C1  | 10       |      7.136 μs |     1.55 KB |
| Arch_C1   | 10       |     23.743 μs |    42.46 KB |
| Friflo_C1 | 10       |     11.427 μs |    10.77 KB |
| Theia_C1  | 25       |     12.729 μs |     4.03 KB |
| Arch_C1   | 25       |     35.379 μs |    43.58 KB |
| Friflo_C1 | 25       |     17.986 μs |    15.09 KB |
| Theia_C1  | 50       |     20.606 μs |     6.75 KB |
| Arch_C1   | 50       |     53.729 μs |    45.24 KB |
| Friflo_C1 | 50       |     28.479 μs |    23.92 KB |
| Theia_C1  | 100      |     35.944 μs |    12.19 KB |
| Arch_C1   | 100      |     92.893 μs |    48.51 KB |
| Friflo_C1 | 100      |     49.320 μs |    41.87 KB |
| Theia_C1  | 200      |     63.153 μs |    23.06 KB |
| Arch_C1   | 200      |    151.423 μs |    54.97 KB |
| Friflo_C1 | 200      |    103.500 μs |    78.38 KB |
| Theia_C1  | 400      |    121.587 μs |    44.81 KB |
| Arch_C1   | 400      |    265.693 μs |    67.82 KB |
| Friflo_C1 | 400      |    186.088 μs |   134.43 KB |
| Theia_C1  | 800      |    236.044 μs |    88.31 KB |
| Arch_C1   | 800      |    509.407 μs |    93.45 KB |
| Friflo_C1 | 800      |    363.713 μs |   276.55 KB |
| Theia_C1  | 1600     |    397.620 μs |   191.76 KB |
| Arch_C1   | 1600     |    968.867 μs |   176.72 KB |
| Friflo_C1 | 1600     |    597.562 μs |   562.76 KB |
| Theia_C1  | 3200     |    743.947 μs |   390.55 KB |
| Arch_C1   | 3200     |  1,710.907 μs |   352.23 KB |
| Friflo_C1 | 3200     |    997.800 μs |  1138.66 KB |
| Theia_C1  | 6400     |  1,301.300 μs |   770.79 KB |
| Arch_C1   | 6400     |  2,267.256 μs |   653.89 KB |
| Friflo_C1 | 6400     |  1,389.806 μs |  2295.27 KB |
| Theia_C1  | 16000    |  2,673.219 μs |  1879.61 KB |
| Arch_C1   | 16000    |  3,145.907 μs |  1421.82 KB |
| Friflo_C1 | 16000    |  1,815.080 μs |   4621.6 KB |
| Theia_C1  | 32000    |  1,801.142 μs |  3765.84 KB |
| Arch_C1   | 32000    |  6,237.044 μs |  2842.06 KB |
| Friflo_C1 | 32000    |  3,379.877 μs |  9299.51 KB |
| Theia_C1  | 64000    |  3,448.988 μs |   7521.4 KB |
| Arch_C1   | 64000    | 12,950.406 μs |  5811.72 KB |
| Friflo_C1 | 64000    |  4,961.681 μs | 18709.27 KB |
| Theia_C1  | 100000   |  5,229.440 μs | 12101.48 KB |
| Arch_C1   | 100000   | 19,705.175 μs | 10604.81 KB |
| Friflo_C1 | 100000   |  7,883.294 μs | 37636.14 KB |
