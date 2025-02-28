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
| Theia_C2  | 1        |      1.783 μs |     0.49 KB |
| Arch_C2   | 1        |     10.343 μs |    25.34 KB |
| Friflo_C2 | 1        |      7.514 μs |     8.59 KB |
| Theia_C2  | 5        |      2.740 μs |      0.9 KB |
| Arch_C2   | 5        |     13.107 μs |    25.46 KB |
| Friflo_C2 | 5        |     10.900 μs |     8.87 KB |
| Theia_C2  | 10       |      3.820 μs |     1.41 KB |
| Arch_C2   | 10       |     15.864 μs |    25.67 KB |
| Friflo_C2 | 10       |     14.036 μs |    11.47 KB |
| Theia_C2  | 25       |      7.133 μs |     3.53 KB |
| Arch_C2   | 25       |     23.493 μs |    26.07 KB |
| Friflo_C2 | 25       |     22.700 μs |    16.59 KB |
| Theia_C2  | 50       |     11.860 μs |     6.32 KB |
| Arch_C2   | 50       |     36.107 μs |    26.84 KB |
| Friflo_C2 | 50       |     36.256 μs |    26.97 KB |
| Theia_C2  | 100      |     21.357 μs |     11.9 KB |
| Arch_C2   | 100      |     63.087 μs |    28.37 KB |
| Friflo_C2 | 100      |     61.231 μs |    47.96 KB |
| Theia_C2  | 200      |     38.350 μs |    23.05 KB |
| Arch_C2   | 200      |    110.262 μs |    31.39 KB |
| Friflo_C2 | 200      |    110.962 μs |    96.55 KB |
| Theia_C2  | 400      |     73.894 μs |    45.37 KB |
| Arch_C2   | 400      |    189.827 μs |    37.41 KB |
| Friflo_C2 | 400      |    224.536 μs |   176.66 KB |
| Theia_C2  | 800      |    147.494 μs |    89.99 KB |
| Arch_C2   | 800      |    356.773 μs |    49.44 KB |
| Friflo_C2 | 800      |    486.119 μs |   370.88 KB |
| Theia_C2  | 1600     |    119.608 μs |   195.36 KB |
| Arch_C2   | 1600     |    625.947 μs |   105.38 KB |
| Friflo_C2 | 1600     |    788.831 μs |   760.85 KB |
| Theia_C2  | 3200     |    233.250 μs |   470.68 KB |
| Arch_C2   | 3200     |  1,117.386 μs |   225.59 KB |
| Friflo_C2 | 3200     |  1,363.113 μs |   1544.2 KB |
| Theia_C2  | 6400     |    387.707 μs |   939.91 KB |
| Arch_C2   | 6400     |  2,008.271 μs |   433.79 KB |
| Friflo_C2 | 6400     |  2,368.325 μs |  3116.89 KB |
| Theia_C2  | 16000    |  2,052.419 μs |  2251.73 KB |
| Arch_C2   | 16000    |  4,810.453 μs |   948.02 KB |
| Friflo_C2 | 16000    |  5,107.938 μs |  6275.32 KB |
| Theia_C2  | 32000    |  4,656.560 μs |  4519.24 KB |
| Arch_C2   | 32000    |  8,612.247 μs |  1911.41 KB |
| Friflo_C2 | 32000    | 10,078.653 μs |  12617.6 KB |
| Theia_C2  | 64000    |  6,950.494 μs |  9036.69 KB |
| Arch_C2   | 64000    | 12,074.725 μs |   3872.7 KB |
| Friflo_C2 | 64000    | 14,462.225 μs | 25355.13 KB |
| Theia_C2  | 100000   |  3,891.720 μs |  14921.6 KB |
| Arch_C2   | 100000   | 10,401.575 μs |  6778.22 KB |
| Friflo_C2 | 100000   | 15,358.446 μs |  50938.8 KB |
