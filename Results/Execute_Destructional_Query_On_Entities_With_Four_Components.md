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
| Theia_C4  | 1        |     2.593 μs |     0.55 KB |
| Arch_C4   | 1        |     6.554 μs |     0.87 KB |
| Friflo_C4 | 1        |     5.188 μs |     0.78 KB |
| Theia_C4  | 5        |     4.073 μs |     0.92 KB |
| Arch_C4   | 5        |     9.475 μs |     0.98 KB |
| Friflo_C4 | 5        |     6.347 μs |     0.92 KB |
| Theia_C4  | 10       |     5.307 μs |     1.39 KB |
| Arch_C4   | 10       |    13.054 μs |      1.2 KB |
| Friflo_C4 | 10       |     7.619 μs |     1.16 KB |
| Theia_C4  | 25       |     9.931 μs |     3.88 KB |
| Arch_C4   | 25       |    21.677 μs |     1.59 KB |
| Friflo_C4 | 25       |    10.312 μs |     1.58 KB |
| Theia_C4  | 50       |    15.627 μs |     6.59 KB |
| Arch_C4   | 50       |    36.180 μs |     2.37 KB |
| Friflo_C4 | 50       |    15.037 μs |     2.38 KB |
| Theia_C4  | 100      |    26.938 μs |    12.03 KB |
| Arch_C4   | 100      |    66.675 μs |     3.89 KB |
| Friflo_C4 | 100      |    24.214 μs |     3.92 KB |
| Theia_C4  | 200      |    49.843 μs |    22.91 KB |
| Arch_C4   | 200      |    80.377 μs |     6.91 KB |
| Friflo_C4 | 200      |    42.679 μs |     6.97 KB |
| Theia_C4  | 400      |    96.881 μs |    44.66 KB |
| Arch_C4   | 400      |   142.515 μs |    17.01 KB |
| Friflo_C4 | 400      |    83.700 μs |    13.02 KB |
| Theia_C4  | 800      |   206.421 μs |    88.48 KB |
| Arch_C4   | 800      |   277.920 μs |    33.64 KB |
| Friflo_C4 | 800      |   166.733 μs |    25.39 KB |
| Theia_C4  | 1600     |   346.620 μs |   175.48 KB |
| Arch_C4   | 1600     |   549.920 μs |    65.66 KB |
| Friflo_C4 | 1600     |   323.847 μs |    49.44 KB |
| Theia_C4  | 3200     |   561.938 μs |   366.16 KB |
| Arch_C4   | 3200     | 1,143.233 μs |   130.34 KB |
| Friflo_C4 | 3200     |   501.327 μs |    98.14 KB |
| Theia_C4  | 6400     |   946.825 μs |   729.88 KB |
| Arch_C4   | 6400     | 2,079.300 μs |   258.09 KB |
| Friflo_C4 | 6400     | 1,035.669 μs |   193.91 KB |
| Theia_C4  | 16000    | 1,057.300 μs |  1758.16 KB |
| Arch_C4   | 16000    | 3,846.700 μs |   514.44 KB |
| Friflo_C4 | 16000    | 1,648.800 μs |   386.23 KB |
| Theia_C4  | 32000    | 1,738.369 μs |  3514.21 KB |
| Arch_C4   | 32000    | 3,091.069 μs |  1026.41 KB |
| Friflo_C4 | 32000    |   911.492 μs |   770.33 KB |
| Theia_C4  | 64000    | 3,482.340 μs |  7025.88 KB |
| Arch_C4   | 64000    | 6,121.864 μs |  2050.77 KB |
| Friflo_C4 | 64000    | 1,774.686 μs |  1538.33 KB |
| Theia_C4  | 100000   | 5,525.657 μs | 11424.51 KB |
| Arch_C4   | 100000   | 9,807.331 μs |  4097.52 KB |
| Friflo_C4 | 100000   | 2,822.929 μs |   3074.7 KB |
