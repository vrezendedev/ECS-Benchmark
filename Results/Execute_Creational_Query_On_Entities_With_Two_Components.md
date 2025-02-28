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
| Theia_C2  | 1        |      2.621 μs |     0.55 KB |
| Arch_C2   | 1        |      7.013 μs |     0.87 KB |
| Friflo_C2 | 1        |      8.393 μs |     2.02 KB |
| Theia_C2  | 5        |      3.733 μs |     0.96 KB |
| Arch_C2   | 5        |      9.353 μs |      0.7 KB |
| Friflo_C2 | 5        |     11.653 μs |     2.29 KB |
| Theia_C2  | 10       |      4.753 μs |     1.47 KB |
| Arch_C2   | 10       |     12.040 μs |      1.2 KB |
| Friflo_C2 | 10       |     15.093 μs |     4.89 KB |
| Theia_C2  | 25       |      8.731 μs |     3.59 KB |
| Arch_C2   | 25       |     19.880 μs |     1.59 KB |
| Friflo_C2 | 25       |     24.381 μs |    10.01 KB |
| Theia_C2  | 50       |     13.647 μs |     6.38 KB |
| Arch_C2   | 50       |     33.493 μs |     2.09 KB |
| Friflo_C2 | 50       |     38.120 μs |    20.39 KB |
| Theia_C2  | 100      |     24.044 μs |    11.96 KB |
| Arch_C2   | 100      |     64.100 μs |     3.89 KB |
| Friflo_C2 | 100      |     67.387 μs |    47.41 KB |
| Theia_C2  | 200      |     43.140 μs |    23.12 KB |
| Arch_C2   | 200      |    109.162 μs |     6.91 KB |
| Friflo_C2 | 200      |    127.643 μs |    95.97 KB |
| Theia_C2  | 400      |     84.025 μs |    45.43 KB |
| Arch_C2   | 400      |    189.644 μs |    12.94 KB |
| Friflo_C2 | 400      |    251.119 μs |   188.13 KB |
| Theia_C2  | 800      |    179.325 μs |   106.17 KB |
| Arch_C2   | 800      |    447.900 μs |    57.68 KB |
| Friflo_C2 | 800      |    608.450 μs |   382.25 KB |
| Theia_C2  | 1600     |    237.771 μs |   276.45 KB |
| Arch_C2   | 1600     |    654.943 μs |   121.22 KB |
| Friflo_C2 | 1600     |    804.731 μs |   772.46 KB |
| Theia_C2  | 3200     |    369.137 μs |   551.07 KB |
| Arch_C2   | 3200     |  1,205.525 μs |   210.17 KB |
| Friflo_C2 | 3200     |  1,308.300 μs |  1556.37 KB |
| Theia_C2  | 6400     |    435.075 μs |  1116.42 KB |
| Arch_C2   | 6400     |  1,233.780 μs |   411.23 KB |
| Friflo_C2 | 6400     |  2,202.594 μs |  3128.97 KB |
| Theia_C2  | 16000    |  1,402.506 μs |  2589.06 KB |
| Arch_C2   | 16000    |  4,433.462 μs |   965.65 KB |
| Friflo_C2 | 16000    |  4,071.137 μs |  6287.02 KB |
| Theia_C2  | 32000    |  1,089.819 μs |  5160.05 KB |
| Arch_C2   | 32000    |  3,003.081 μs |  1964.39 KB |
| Friflo_C2 | 32000    |  2,985.643 μs | 12629.49 KB |
| Theia_C2  | 64000    |  2,175.094 μs | 10333.43 KB |
| Arch_C2   | 64000    |  5,988.662 μs |  4014.29 KB |
| Friflo_C2 | 64000    |  6,226.727 μs | 25366.92 KB |
| Theia_C2  | 100000   |  3,447.667 μs | 17483.68 KB |
| Arch_C2   | 100000   |  9,404.487 μs |  7132.58 KB |
| Friflo_C2 | 100000   | 11,802.212 μs |  50950.5 KB |
