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
| Theia_C2  | 1        |      4.033 μs |     0.72 KB |
| Arch_C2   | 1        |     14.329 μs |    33.85 KB |
| Friflo_C2 | 1        |      7.027 μs |     10.6 KB |
| Theia_C2  | 5        |      6.153 μs |     1.09 KB |
| Arch_C2   | 5        |     19.025 μs |    34.09 KB |
| Friflo_C2 | 5        |      9.493 μs |    10.79 KB |
| Theia_C2  | 10       |      7.760 μs |     1.56 KB |
| Arch_C2   | 10       |     24.450 μs |    34.49 KB |
| Friflo_C2 | 10       |     12.327 μs |    12.97 KB |
| Theia_C2  | 25       |     13.900 μs |     4.05 KB |
| Arch_C2   | 25       |     36.114 μs |    35.25 KB |
| Friflo_C2 | 25       |     19.144 μs |    17.29 KB |
| Theia_C2  | 50       |     22.700 μs |     6.77 KB |
| Arch_C2   | 50       |     55.343 μs |    36.66 KB |
| Friflo_C2 | 50       |     30.243 μs |    26.13 KB |
| Theia_C2  | 100      |     39.014 μs |     12.2 KB |
| Arch_C2   | 100      |     91.362 μs |    39.15 KB |
| Friflo_C2 | 100      |     53.062 μs |    44.07 KB |
| Theia_C2  | 200      |     73.593 μs |    23.08 KB |
| Arch_C2   | 200      |    166.987 μs |    44.89 KB |
| Friflo_C2 | 200      |    101.307 μs |    80.59 KB |
| Theia_C2  | 400      |    148.988 μs |    44.83 KB |
| Arch_C2   | 400      |    301.760 μs |    55.74 KB |
| Friflo_C2 | 400      |    194.588 μs |   136.63 KB |
| Theia_C2  | 800      |    352.844 μs |    88.33 KB |
| Arch_C2   | 800      |    618.900 μs |    77.38 KB |
| Friflo_C2 | 800      |    446.394 μs |   282.77 KB |
| Theia_C2  | 1600     |    453.438 μs |    191.8 KB |
| Arch_C2   | 1600     |  1,064.760 μs |   160.97 KB |
| Friflo_C2 | 1600     |    589.260 μs |   577.01 KB |
| Theia_C2  | 3200     |    911.156 μs |   406.76 KB |
| Arch_C2   | 3200     |  2,207.906 μs |   311.98 KB |
| Friflo_C2 | 3200     |  1,052.175 μs |  1168.66 KB |
| Theia_C2  | 6400     |  1,522.581 μs |   803.18 KB |
| Arch_C2   | 6400     |  2,417.225 μs |   606.24 KB |
| Friflo_C2 | 6400     |  1,201.875 μs |  2357.56 KB |
| Theia_C2  | 16000    |  4,823.788 μs |  1943.84 KB |
| Arch_C2   | 16000    |  6,476.637 μs |  1351.32 KB |
| Friflo_C2 | 16000    |  1,936.213 μs |  4747.64 KB |
| Theia_C2  | 32000    |  2,018.037 μs |  3895.52 KB |
| Arch_C2   | 32000    |  6,920.313 μs |  2742.59 KB |
| Friflo_C2 | 32000    |  2,173.106 μs |  9554.18 KB |
| Theia_C2  | 64000    |  4,068.575 μs |  7779.64 KB |
| Arch_C2   | 64000    | 13,860.650 μs |  5592.79 KB |
| Friflo_C2 | 64000    |  4,038.142 μs | 19218.98 KB |
| Theia_C2  | 100000   |  6,411.940 μs | 12489.34 KB |
| Arch_C2   | 100000   | 21,747.347 μs | 10081.22 KB |
| Friflo_C2 | 100000   |  8,477.169 μs | 38658.25 KB |
