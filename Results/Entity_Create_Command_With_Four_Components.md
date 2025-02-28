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
| Theia_C4  | 1        |      1.831 μs |      0.5 KB |
| Arch_C4   | 1        |     10.547 μs |    25.41 KB |
| Friflo_C4 | 1        |      9.031 μs |    13.13 KB |
| Theia_C4  | 5        |      2.913 μs |     0.94 KB |
| Arch_C4   | 5        |     13.423 μs |    25.53 KB |
| Friflo_C4 | 5        |     13.060 μs |     13.4 KB |
| Theia_C4  | 10       |      3.987 μs |     1.48 KB |
| Arch_C4   | 10       |     16.213 μs |    25.74 KB |
| Friflo_C4 | 10       |     18.107 μs |    16.27 KB |
| Theia_C4  | 25       |      7.827 μs |     3.73 KB |
| Arch_C4   | 25       |     23.520 μs |    26.14 KB |
| Friflo_C4 | 25       |     29.606 μs |    22.71 KB |
| Theia_C4  | 50       |     12.988 μs |     6.71 KB |
| Arch_C4   | 50       |     37.544 μs |    26.91 KB |
| Friflo_C4 | 50       |     48.847 μs |    34.86 KB |
| Theia_C4  | 100      |     23.613 μs |    12.68 KB |
| Arch_C4   | 100      |     60.847 μs |    28.44 KB |
| Friflo_C4 | 100      |     84.743 μs |    60.18 KB |
| Theia_C4  | 200      |     41.087 μs |    24.62 KB |
| Arch_C4   | 200      |    109.838 μs |    31.46 KB |
| Friflo_C4 | 200      |    162.819 μs |   116.81 KB |
| Theia_C4  | 400      |     83.957 μs |    48.49 KB |
| Arch_C4   | 400      |    201.987 μs |    37.48 KB |
| Friflo_C4 | 400      |    325.344 μs |   212.98 KB |
| Theia_C4  | 800      |    176.180 μs |    96.24 KB |
| Arch_C4   | 800      |    376.144 μs |    73.71 KB |
| Friflo_C4 | 800      |    664.907 μs |      447 KB |
| Theia_C4  | 1600     |    218.300 μs |   207.65 KB |
| Arch_C4   | 1600     |    676.879 μs |   121.63 KB |
| Friflo_C4 | 1600     |  1,046.838 μs |   917.35 KB |
| Theia_C4  | 3200     |    429.400 μs |   512.01 KB |
| Arch_C4   | 3200     |  1,060.077 μs |   233.61 KB |
| Friflo_C4 | 3200     |  1,766.531 μs |  1860.79 KB |
| Theia_C4  | 6400     |    823.956 μs |  1038.76 KB |
| Arch_C4   | 6400     |  1,967.600 μs |   481.88 KB |
| Friflo_C4 | 6400     |  3,032.081 μs |  3753.58 KB |
| Theia_C4  | 16000    |  2,227.800 μs |  2508.11 KB |
| Arch_C4   | 16000    |  4,808.353 μs |  1110.31 KB |
| Friflo_C4 | 16000    |  6,847.400 μs |   7552.1 KB |
| Theia_C4  | 32000    |  5,134.780 μs |  5030.61 KB |
| Arch_C4   | 32000    |  6,883.081 μs |  2199.61 KB |
| Friflo_C4 | 32000    | 11,771.181 μs | 15174.48 KB |
| Theia_C4  | 64000    |  6,604.512 μs | 10059.42 KB |
| Arch_C4   | 64000    | 11,356.819 μs |  4440.69 KB |
| Friflo_C4 | 64000    | 15,469.256 μs | 30472.09 KB |
| Theia_C4  | 100000   |  4,272.337 μs | 16501.17 KB |
| Arch_C4   | 100000   | 10,888.712 μs |  7689.38 KB |
| Friflo_C4 | 100000   | 19,124.188 μs | 61175.86 KB |
