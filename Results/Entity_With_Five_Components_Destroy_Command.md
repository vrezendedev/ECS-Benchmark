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
| Theia_C5  | 1        |      1.573 μs |     0.48 KB |
| Arch_C5   | 1        |      3.836 μs |     0.46 KB |
| Friflo_C5 | 1        |      3.100 μs |     0.66 KB |
| Theia_C5  | 5        |      3.286 μs |     0.86 KB |
| Arch_C5   | 5        |      6.867 μs |     0.58 KB |
| Friflo_C5 | 5        |      4.273 μs |      0.8 KB |
| Theia_C5  | 10       |      4.493 μs |     1.33 KB |
| Arch_C5   | 10       |     10.043 μs |     0.79 KB |
| Friflo_C5 | 10       |      5.347 μs |     1.04 KB |
| Theia_C5  | 25       |      9.173 μs |     3.81 KB |
| Arch_C5   | 25       |     19.181 μs |     1.19 KB |
| Friflo_C5 | 25       |      7.980 μs |     1.46 KB |
| Theia_C5  | 50       |     14.450 μs |     6.53 KB |
| Arch_C5   | 50       |     31.933 μs |     1.96 KB |
| Friflo_C5 | 50       |     12.194 μs |     2.26 KB |
| Theia_C5  | 100      |     26.720 μs |    11.97 KB |
| Arch_C5   | 100      |     62.862 μs |     3.48 KB |
| Friflo_C5 | 100      |     20.900 μs |      3.8 KB |
| Theia_C5  | 200      |     56.919 μs |    22.84 KB |
| Arch_C5   | 200      |     91.823 μs |     6.51 KB |
| Friflo_C5 | 200      |     45.163 μs |     6.85 KB |
| Theia_C5  | 400      |     96.127 μs |    44.59 KB |
| Arch_C5   | 400      |    140.456 μs |    16.88 KB |
| Friflo_C5 | 400      |     77.015 μs |     12.9 KB |
| Theia_C5  | 800      |    175.681 μs |    88.42 KB |
| Arch_C5   | 800      |    264.850 μs |    33.23 KB |
| Friflo_C5 | 800      |    160.780 μs |    25.27 KB |
| Theia_C5  | 1600     |    227.807 μs |   175.42 KB |
| Arch_C5   | 1600     |    500.144 μs |    65.26 KB |
| Friflo_C5 | 1600     |    286.660 μs |    49.32 KB |
| Theia_C5  | 3200     |    424.733 μs |    366.1 KB |
| Arch_C5   | 3200     |  1,182.156 μs |   129.94 KB |
| Friflo_C5 | 3200     |    511.262 μs |    98.02 KB |
| Theia_C5  | 6400     |    368.944 μs |   729.82 KB |
| Arch_C5   | 6400     |  1,556.175 μs |   257.68 KB |
| Friflo_C5 | 6400     |    536.344 μs |   193.79 KB |
| Theia_C5  | 16000    |  1,248.719 μs |  1757.82 KB |
| Arch_C5   | 16000    |  3,251.781 μs |   513.33 KB |
| Friflo_C5 | 16000    |  1,419.200 μs |   386.16 KB |
| Theia_C5  | 32000    |  2,013.258 μs |  3514.15 KB |
| Arch_C5   | 32000    |  3,303.164 μs |  1026.05 KB |
| Friflo_C5 | 32000    |    860.085 μs |   770.21 KB |
| Theia_C5  | 64000    |  3,928.360 μs |  7025.82 KB |
| Arch_C5   | 64000    |  6,543.057 μs |  2050.03 KB |
| Friflo_C5 | 64000    |  1,669.556 μs |  1538.26 KB |
| Theia_C5  | 100000   |  6,182.787 μs | 11424.45 KB |
| Arch_C5   | 100000   | 10,344.450 μs |   4097.4 KB |
| Friflo_C5 | 100000   |  2,634.400 μs |   3073.6 KB |
