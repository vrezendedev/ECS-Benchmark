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
| Theia_C1  | 1        |      1.783 μs |      0.2 KB |
| Arch_C1   | 1        |     11.138 μs |    33.34 KB |
| Friflo_C1 | 1        |      6.179 μs |     6.33 KB |
| Theia_C1  | 5        |      2.706 μs |     0.86 KB |
| Arch_C1   | 5        |     13.914 μs |    33.45 KB |
| Friflo_C1 | 5        |      8.767 μs |      6.6 KB |
| Theia_C1  | 10       |      3.664 μs |     1.33 KB |
| Arch_C1   | 10       |     16.436 μs |    33.66 KB |
| Friflo_C1 | 10       |     11.980 μs |     8.93 KB |
| Theia_C1  | 25       |      7.260 μs |     3.34 KB |
| Arch_C1   | 25       |     24.700 μs |    34.06 KB |
| Friflo_C1 | 25       |     19.333 μs |    13.52 KB |
| Theia_C1  | 50       |     11.463 μs |     5.93 KB |
| Arch_C1   | 50       |     36.285 μs |    34.84 KB |
| Friflo_C1 | 50       |     30.033 μs |    22.88 KB |
| Theia_C1  | 100      |     22.762 μs |    11.12 KB |
| Arch_C1   | 100      |     64.469 μs |    36.36 KB |
| Friflo_C1 | 100      |     50.864 μs |    41.85 KB |
| Theia_C1  | 200      |     36.767 μs |    21.49 KB |
| Arch_C1   | 200      |    112.308 μs |    39.38 KB |
| Friflo_C1 | 200      |     92.907 μs |    86.41 KB |
| Theia_C1  | 400      |     72.700 μs |    42.24 KB |
| Arch_C1   | 400      |    192.953 μs |    45.13 KB |
| Friflo_C1 | 400      |    187.056 μs |   158.51 KB |
| Theia_C1  | 800      |    146.050 μs |    83.74 KB |
| Arch_C1   | 800      |    383.950 μs |    57.43 KB |
| Friflo_C1 | 800      |    399.087 μs |   332.39 KB |
| Theia_C1  | 1600     |    117.462 μs |   166.74 KB |
| Arch_C1   | 1600     |    626.867 μs |   129.75 KB |
| Friflo_C1 | 1600     |    644.775 μs |    682.6 KB |
| Theia_C1  | 3200     |    217.580 μs |   429.24 KB |
| Arch_C1   | 3200     |  1,063.969 μs |   209.67 KB |
| Friflo_C1 | 3200     |  1,156.993 μs |   1385.9 KB |
| Theia_C1  | 6400     |    390.294 μs |   873.68 KB |
| Arch_C1   | 6400     |  2,079.588 μs |   401.88 KB |
| Friflo_C1 | 6400     |  2,022.650 μs |  2798.55 KB |
| Theia_C1  | 16000    |  2,125.688 μs |  2061.99 KB |
| Arch_C1   | 16000    |  4,662.127 μs |   924.13 KB |
| Friflo_C1 | 16000    |  4,316.163 μs |  5636.93 KB |
| Theia_C1  | 32000    |  4,015.188 μs |  4138.62 KB |
| Arch_C1   | 32000    |  7,457.981 μs |   1829.8 KB |
| Friflo_C1 | 32000    |  8,583.381 μs | 11339.16 KB |
| Theia_C1  | 64000    |  5,838.562 μs |  8292.97 KB |
| Arch_C1   | 64000    | 17,483.469 μs |  3637.06 KB |
| Friflo_C1 | 64000    | 10,905.050 μs | 22796.64 KB |
| Theia_C1  | 100000   | 16,090.906 μs | 13734.05 KB |
| Arch_C1   | 100000   | 11,752.700 μs |  6387.28 KB |
| Friflo_C1 | 100000   | 17,459.260 μs | 45820.27 KB |
