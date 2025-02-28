```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5555/22H2/2022Update)
AMD Ryzen 5 5600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  Job-XJEJRV : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=16  UnrollFactor=1  

```
| Method            | Entities | Mean          | Allocated   |
|------------------ |--------- |--------------:|------------:|
| Theia_C1          | 1        |      4.171 μs |     0.77 KB |
| Theia_C1_Optional | 1        |      2.469 μs |     0.55 KB |
| Arch_C1           | 1        |     16.980 μs |    42.27 KB |
| Friflo_C1         | 1        |      8.075 μs |     8.52 KB |
| Theia_C1          | 5        |      6.320 μs |     1.14 KB |
| Theia_C1_Optional | 5        |      4.544 μs |     0.92 KB |
| Arch_C1           | 5        |     21.993 μs |     42.5 KB |
| Friflo_C1         | 5        |     10.838 μs |      8.7 KB |
| Theia_C1          | 10       |      7.750 μs |     1.61 KB |
| Theia_C1_Optional | 10       |      6.040 μs |     1.39 KB |
| Arch_C1           | 10       |     26.000 μs |    42.87 KB |
| Friflo_C1         | 10       |     13.429 μs |    10.88 KB |
| Theia_C1          | 25       |     13.880 μs |     4.09 KB |
| Theia_C1_Optional | 25       |     11.593 μs |     3.88 KB |
| Arch_C1           | 25       |     39.838 μs |    43.98 KB |
| Friflo_C1         | 25       |     20.163 μs |    14.92 KB |
| Theia_C1          | 50       |     20.900 μs |     6.81 KB |
| Theia_C1_Optional | 50       |     18.825 μs |     6.59 KB |
| Arch_C1           | 50       |     57.685 μs |    45.65 KB |
| Friflo_C1         | 50       |     31.047 μs |    24.04 KB |
| Theia_C1          | 100      |     36.257 μs |    12.25 KB |
| Theia_C1_Optional | 100      |     32.833 μs |    12.03 KB |
| Arch_C1           | 100      |     92.450 μs |    48.91 KB |
| Friflo_C1         | 100      |     51.688 μs |    41.98 KB |
| Theia_C1          | 200      |     65.700 μs |    23.13 KB |
| Theia_C1_Optional | 200      |     60.040 μs |    22.91 KB |
| Arch_C1           | 200      |    164.080 μs |    55.09 KB |
| Friflo_C1         | 200      |     96.327 μs |     78.5 KB |
| Theia_C1          | 400      |    129.243 μs |    44.88 KB |
| Theia_C1_Optional | 400      |    121.444 μs |    44.66 KB |
| Arch_C1           | 400      |    269.792 μs |    67.95 KB |
| Friflo_C1         | 400      |    194.180 μs |   134.27 KB |
| Theia_C1          | 800      |    264.273 μs |    88.38 KB |
| Theia_C1_Optional | 800      |    260.667 μs |    88.16 KB |
| Arch_C1           | 800      |    513.625 μs |    93.86 KB |
| Friflo_C1         | 800      |    390.413 μs |   276.66 KB |
| Theia_C1          | 1600     |    501.720 μs |   191.82 KB |
| Theia_C1_Optional | 1600     |    430.807 μs |    272.3 KB |
| Arch_C1           | 1600     |  1,020.980 μs |   177.41 KB |
| Friflo_C1         | 1600     |    727.136 μs |   562.88 KB |
| Theia_C1          | 3200     |    792.036 μs |   390.62 KB |
| Theia_C1_Optional | 3200     |    549.114 μs |   558.45 KB |
| Arch_C1           | 3200     |  1,647.500 μs |   352.63 KB |
| Friflo_C1         | 3200     |  1,028.263 μs |  1138.78 KB |
| Theia_C1          | 6400     |  1,398.380 μs |   770.85 KB |
| Theia_C1_Optional | 6400     |  1,038.787 μs |  1114.68 KB |
| Arch_C1           | 6400     |  2,617.194 μs |    654.3 KB |
| Friflo_C1         | 6400     |  1,099.756 μs |  2295.38 KB |
| Theia_C1          | 16000    |    890.281 μs |  1879.67 KB |
| Theia_C1_Optional | 16000    |  1,761.333 μs |   2575.5 KB |
| Arch_C1           | 16000    |  3,151.781 μs |  1422.23 KB |
| Friflo_C1         | 16000    |  1,820.675 μs |  4621.72 KB |
| Theia_C1          | 32000    |  1,775.675 μs |   3765.9 KB |
| Theia_C1_Optional | 32000    |  1,816.953 μs |  5165.68 KB |
| Arch_C1           | 32000    |  6,232.471 μs |  2842.47 KB |
| Friflo_C1         | 32000    |  2,815.562 μs |  9299.58 KB |
| Theia_C1          | 64000    |  3,507.058 μs |  7522.07 KB |
| Theia_C1_Optional | 64000    |  3,604.746 μs | 10329.29 KB |
| Arch_C1           | 64000    | 12,528.693 μs |  5812.41 KB |
| Friflo_C1         | 64000    |  4,369.194 μs | 18709.34 KB |
| Theia_C1          | 100000   |  5,305.647 μs | 12101.88 KB |
| Theia_C1_Optional | 100000   |  5,514.293 μs | 17725.38 KB |
| Arch_C1           | 100000   | 19,763.138 μs | 10605.59 KB |
| Friflo_C1         | 100000   |  7,777.981 μs | 37636.59 KB |
