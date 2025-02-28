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
| Theia_C5  | 1        |      3.237 μs |     0.56 KB |
| Arch_C5   | 1        |      4.607 μs |     0.59 KB |
| Friflo_C5 | 1        |     10.657 μs |      2.6 KB |
| Theia_C5  | 5        |      4.387 μs |        1 KB |
| Arch_C5   | 5        |      5.944 μs |     0.98 KB |
| Friflo_C5 | 5        |     15.367 μs |     2.88 KB |
| Theia_C5  | 10       |      5.775 μs |     1.55 KB |
| Arch_C5   | 10       |      7.257 μs |      1.2 KB |
| Friflo_C5 | 10       |     20.836 μs |      6.3 KB |
| Theia_C5  | 25       |     10.256 μs |     3.79 KB |
| Arch_C5   | 25       |     10.660 μs |     1.59 KB |
| Friflo_C5 | 25       |     34.944 μs |    12.98 KB |
| Theia_C5  | 50       |     16.307 μs |     6.77 KB |
| Arch_C5   | 50       |     15.880 μs |     2.37 KB |
| Friflo_C5 | 50       |     57.964 μs |    26.44 KB |
| Theia_C5  | 100      |     27.843 μs |    12.74 KB |
| Arch_C5   | 100      |     28.600 μs |     3.89 KB |
| Friflo_C5 | 100      |    106.069 μs |    59.52 KB |
| Theia_C5  | 200      |     58.925 μs |    24.68 KB |
| Arch_C5   | 200      |     60.850 μs |     6.91 KB |
| Friflo_C5 | 200      |    214.787 μs |   120.16 KB |
| Theia_C5  | 400      |     95.364 μs |    64.74 KB |
| Arch_C5   | 400      |     94.456 μs |    12.94 KB |
| Friflo_C5 | 400      |    368.473 μs |   248.46 KB |
| Theia_C5  | 800      |    220.062 μs |   112.82 KB |
| Arch_C5   | 800      |    210.573 μs |    25.29 KB |
| Friflo_C5 | 800      |    758.953 μs |   502.98 KB |
| Theia_C5  | 1600     |    333.093 μs |   305.21 KB |
| Arch_C5   | 1600     |    366.733 μs |    49.31 KB |
| Friflo_C5 | 1600     |  1,058.314 μs |  1012.93 KB |
| Theia_C5  | 3200     |    693.119 μs |   624.77 KB |
| Arch_C5   | 3200     |    633.171 μs |    97.99 KB |
| Friflo_C5 | 3200     |  1,938.600 μs |  2036.91 KB |
| Theia_C5  | 6400     |  1,184.412 μs |  1232.34 KB |
| Arch_C5   | 6400     |  1,070.069 μs |   193.73 KB |
| Friflo_C5 | 6400     |  3,166.225 μs |   4089.3 KB |
| Theia_C5  | 16000    |    712.062 μs |  2893.39 KB |
| Arch_C5   | 16000    |    701.240 μs |   385.43 KB |
| Friflo_C5 | 16000    |  2,620.867 μs |     8207 KB |
| Theia_C5  | 32000    |  1,449.013 μs |  5801.72 KB |
| Arch_C5   | 32000    |  1,411.385 μs |   770.11 KB |
| Friflo_C5 | 32000    |  4,912.362 μs | 16470.29 KB |
| Theia_C5  | 64000    |  2,761.493 μs | 11601.16 KB |
| Arch_C5   | 64000    |  2,910.207 μs |  1538.13 KB |
| Friflo_C5 | 64000    | 10,212.536 μs | 33047.74 KB |
| Theia_C5  | 100000   |  4,386.323 μs | 19473.94 KB |
| Arch_C5   | 100000   |  4,334.167 μs |  3073.83 KB |
| Friflo_C5 | 100000   | 16,620.654 μs | 66311.11 KB |
