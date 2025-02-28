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
| Theia_C4  | 1        |      2.892 μs |     0.56 KB |
| Arch_C4   | 1        |      4.433 μs |     0.59 KB |
| Friflo_C4 | 1        |      9.814 μs |     2.41 KB |
| Theia_C4  | 5        |      4.200 μs |        1 KB |
| Arch_C4   | 5        |      5.787 μs |     0.98 KB |
| Friflo_C4 | 5        |     14.194 μs |     2.68 KB |
| Theia_C4  | 10       |      5.253 μs |     1.27 KB |
| Arch_C4   | 10       |      6.853 μs |      1.2 KB |
| Friflo_C4 | 10       |     19.200 μs |     5.55 KB |
| Theia_C4  | 25       |      9.636 μs |     3.79 KB |
| Arch_C4   | 25       |     10.631 μs |     1.59 KB |
| Friflo_C4 | 25       |     31.067 μs |    11.99 KB |
| Theia_C4  | 50       |     14.920 μs |     6.77 KB |
| Arch_C4   | 50       |     16.040 μs |     2.37 KB |
| Friflo_C4 | 50       |     51.875 μs |    24.42 KB |
| Theia_C4  | 100      |     25.760 μs |    12.74 KB |
| Arch_C4   | 100      |     27.488 μs |     3.89 KB |
| Friflo_C4 | 100      |     90.381 μs |    55.48 KB |
| Theia_C4  | 200      |     46.556 μs |     24.4 KB |
| Arch_C4   | 200      |     49.529 μs |     6.91 KB |
| Friflo_C4 | 200      |    172.573 μs |   112.09 KB |
| Theia_C4  | 400      |     92.843 μs |    48.55 KB |
| Arch_C4   | 400      |     93.927 μs |    12.94 KB |
| Friflo_C4 | 400      |    343.447 μs |   228.35 KB |
| Theia_C4  | 800      |    193.115 μs |   112.82 KB |
| Arch_C4   | 800      |    201.764 μs |    25.29 KB |
| Friflo_C4 | 800      |    688.080 μs |   462.84 KB |
| Theia_C4  | 1600     |    420.827 μs |   304.93 KB |
| Arch_C4   | 1600     |    378.780 μs |    49.31 KB |
| Friflo_C4 | 1600     |  1,089.177 μs |   932.77 KB |
| Theia_C4  | 3200     |    508.644 μs |   608.59 KB |
| Arch_C4   | 3200     |    643.627 μs |    97.99 KB |
| Friflo_C4 | 3200     |  1,768.606 μs |  1876.73 KB |
| Theia_C4  | 6400     |  1,104.638 μs |  1215.05 KB |
| Arch_C4   | 6400     |  1,492.333 μs |   193.73 KB |
| Friflo_C4 | 6400     |  1,056.544 μs |  3769.09 KB |
| Theia_C4  | 16000    |    704.958 μs |  2844.13 KB |
| Arch_C4   | 16000    |  1,805.094 μs |   386.09 KB |
| Friflo_C4 | 16000    |  3,806.994 μs |   7567.8 KB |
| Theia_C4  | 32000    |  1,301.893 μs |  5672.22 KB |
| Arch_C4   | 32000    |  3,029.469 μs |   770.11 KB |
| Friflo_C4 | 32000    |  4,187.906 μs | 15190.04 KB |
| Theia_C4  | 64000    |  2,642.986 μs | 11342.16 KB |
| Arch_C4   | 64000    |  2,704.480 μs |  1538.13 KB |
| Friflo_C4 | 64000    |  8,317.471 μs | 30487.52 KB |
| Theia_C4  | 100000   |  4,244.450 μs | 19063.58 KB |
| Arch_C4   | 100000   |  4,242.408 μs |  3073.83 KB |
| Friflo_C4 | 100000   | 16,408.138 μs | 61191.09 KB |
