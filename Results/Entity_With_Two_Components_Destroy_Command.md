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
| Theia_C2  | 1        |     1.579 μs |     0.48 KB |
| Arch_C2   | 1        |     3.736 μs |     0.46 KB |
| Friflo_C2 | 1        |     3.207 μs |     0.66 KB |
| Theia_C2  | 5        |     2.940 μs |     0.86 KB |
| Arch_C2   | 5        |     6.464 μs |     0.58 KB |
| Friflo_C2 | 5        |     4.000 μs |      0.8 KB |
| Theia_C2  | 10       |     3.950 μs |     1.33 KB |
| Arch_C2   | 10       |     9.550 μs |     0.79 KB |
| Friflo_C2 | 10       |     5.027 μs |     1.04 KB |
| Theia_C2  | 25       |     7.775 μs |     3.81 KB |
| Arch_C2   | 25       |    17.747 μs |     1.19 KB |
| Friflo_C2 | 25       |     7.106 μs |     1.46 KB |
| Theia_C2  | 50       |    11.967 μs |     6.53 KB |
| Arch_C2   | 50       |    31.300 μs |     1.96 KB |
| Friflo_C2 | 50       |    10.367 μs |     2.26 KB |
| Theia_C2  | 100      |    20.362 μs |    11.97 KB |
| Arch_C2   | 100      |    56.400 μs |     3.48 KB |
| Friflo_C2 | 100      |    16.931 μs |      3.8 KB |
| Theia_C2  | 200      |    38.421 μs |    22.84 KB |
| Arch_C2   | 200      |    73.963 μs |     6.23 KB |
| Friflo_C2 | 200      |    29.225 μs |     6.85 KB |
| Theia_C2  | 400      |    73.740 μs |    44.59 KB |
| Arch_C2   | 400      |   127.985 μs |     16.6 KB |
| Friflo_C2 | 400      |    62.900 μs |     12.9 KB |
| Theia_C2  | 800      |   168.481 μs |    88.09 KB |
| Arch_C2   | 800      |   284.400 μs |    32.91 KB |
| Friflo_C2 | 800      |   140.525 μs |    24.95 KB |
| Theia_C2  | 1600     |   146.379 μs |   174.11 KB |
| Arch_C2   | 1600     |   450.315 μs |    65.26 KB |
| Friflo_C2 | 1600     |   221.500 μs |    49.32 KB |
| Theia_C2  | 3200     |   274.100 μs |    366.1 KB |
| Arch_C2   | 3200     |   865.379 μs |   129.94 KB |
| Friflo_C2 | 3200     |   398.764 μs |    98.02 KB |
| Theia_C2  | 6400     |   474.000 μs |    730.1 KB |
| Arch_C2   | 6400     |   825.420 μs |   257.68 KB |
| Friflo_C2 | 6400     |   687.900 μs |   194.07 KB |
| Theia_C2  | 16000    | 2,012.438 μs |  1757.82 KB |
| Arch_C2   | 16000    | 4,355.307 μs |   513.66 KB |
| Friflo_C2 | 16000    | 1,215.594 μs |   385.79 KB |
| Theia_C2  | 32000    | 1,355.294 μs |  3514.15 KB |
| Arch_C2   | 32000    | 2,882.507 μs |  1026.05 KB |
| Friflo_C2 | 32000    |   852.163 μs |   770.21 KB |
| Theia_C2  | 64000    | 2,718.994 μs |  7025.82 KB |
| Arch_C2   | 64000    | 5,789.706 μs |  2049.09 KB |
| Friflo_C2 | 64000    | 3,258.844 μs |  1538.21 KB |
| Theia_C2  | 100000   | 4,322.100 μs | 11424.49 KB |
| Arch_C2   | 100000   | 8,848.323 μs |  4097.45 KB |
| Friflo_C2 | 100000   | 2,467.847 μs |  3073.93 KB |
