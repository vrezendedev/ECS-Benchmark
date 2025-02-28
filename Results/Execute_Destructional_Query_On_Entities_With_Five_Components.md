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
| Theia_C5  | 1        |      2.720 μs |     0.55 KB |
| Arch_C5   | 1        |      6.737 μs |     0.87 KB |
| Friflo_C5 | 1        |      5.307 μs |     0.78 KB |
| Theia_C5  | 5        |      4.386 μs |     0.92 KB |
| Arch_C5   | 5        |      9.806 μs |     0.98 KB |
| Friflo_C5 | 5        |      6.633 μs |     0.92 KB |
| Theia_C5  | 10       |      5.638 μs |     1.11 KB |
| Arch_C5   | 10       |     13.180 μs |      1.2 KB |
| Friflo_C5 | 10       |      7.867 μs |     1.16 KB |
| Theia_C5  | 25       |     10.321 μs |     3.88 KB |
| Arch_C5   | 25       |     22.050 μs |     1.59 KB |
| Friflo_C5 | 25       |     10.969 μs |     1.58 KB |
| Theia_C5  | 50       |     16.153 μs |     6.31 KB |
| Arch_C5   | 50       |     37.075 μs |     2.37 KB |
| Friflo_C5 | 50       |     15.943 μs |     2.38 KB |
| Theia_C5  | 100      |     28.469 μs |    12.03 KB |
| Arch_C5   | 100      |     68.506 μs |     3.89 KB |
| Friflo_C5 | 100      |     25.750 μs |     3.92 KB |
| Theia_C5  | 200      |     63.519 μs |    22.91 KB |
| Arch_C5   | 200      |     92.107 μs |     6.91 KB |
| Friflo_C5 | 200      |     53.862 μs |     6.97 KB |
| Theia_C5  | 400      |    100.492 μs |    44.66 KB |
| Arch_C5   | 400      |    143.264 μs |    17.29 KB |
| Friflo_C5 | 400      |     95.425 μs |    13.02 KB |
| Theia_C5  | 800      |    206.086 μs |    88.48 KB |
| Arch_C5   | 800      |    282.100 μs |    33.64 KB |
| Friflo_C5 | 800      |    181.631 μs |    25.11 KB |
| Theia_C5  | 1600     |    374.812 μs |   175.48 KB |
| Arch_C5   | 1600     |    592.938 μs |    65.66 KB |
| Friflo_C5 | 1600     |    316.587 μs |    49.44 KB |
| Theia_C5  | 3200     |    519.493 μs |   366.16 KB |
| Arch_C5   | 3200     |  1,066.912 μs |   130.34 KB |
| Friflo_C5 | 3200     |    632.138 μs |    98.14 KB |
| Theia_C5  | 6400     |    412.850 μs |   729.88 KB |
| Arch_C5   | 6400     |  2,293.256 μs |   258.09 KB |
| Friflo_C5 | 6400     |    730.319 μs |   193.86 KB |
| Theia_C5  | 16000    |  1,450.381 μs |  1758.16 KB |
| Arch_C5   | 16000    |  1,626.247 μs |   514.39 KB |
| Friflo_C5 | 16000    |  1,805.675 μs |   386.28 KB |
| Theia_C5  | 32000    |  2,017.703 μs |  3514.21 KB |
| Arch_C5   | 32000    |  3,297.743 μs |  1026.46 KB |
| Friflo_C5 | 32000    |    936.629 μs |   770.61 KB |
| Theia_C5  | 64000    |  3,934.425 μs |  7026.16 KB |
| Arch_C5   | 64000    |  6,321.133 μs |  2050.48 KB |
| Friflo_C5 | 64000    |  1,826.160 μs |  1538.33 KB |
| Theia_C5  | 100000   |  6,113.347 μs | 11425.49 KB |
| Arch_C5   | 100000   | 10,272.860 μs |  4097.52 KB |
| Friflo_C5 | 100000   |  2,891.364 μs |  3074.05 KB |
