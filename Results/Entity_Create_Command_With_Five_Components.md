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
| Theia_C5  | 1        |      1.856 μs |     0.22 KB |
| Arch_C5   | 1        |     10.637 μs |    25.41 KB |
| Friflo_C5 | 1        |     10.213 μs |    15.39 KB |
| Theia_C5  | 5        |      2.980 μs |     0.94 KB |
| Arch_C5   | 5        |     13.193 μs |    25.53 KB |
| Friflo_C5 | 5        |     14.457 μs |    15.66 KB |
| Theia_C5  | 10       |      4.113 μs |     1.48 KB |
| Arch_C5   | 10       |     16.280 μs |    25.46 KB |
| Friflo_C5 | 10       |     19.743 μs |    19.09 KB |
| Theia_C5  | 25       |      8.125 μs |     3.73 KB |
| Arch_C5   | 25       |     24.680 μs |    26.14 KB |
| Friflo_C5 | 25       |     33.100 μs |    25.77 KB |
| Theia_C5  | 50       |     13.421 μs |     6.71 KB |
| Arch_C5   | 50       |     38.136 μs |    26.91 KB |
| Friflo_C5 | 50       |     53.064 μs |    39.23 KB |
| Theia_C5  | 100      |     24.300 μs |    12.68 KB |
| Arch_C5   | 100      |     62.800 μs |    28.44 KB |
| Friflo_C5 | 100      |     98.381 μs |    66.29 KB |
| Theia_C5  | 200      |     45.769 μs |    24.62 KB |
| Arch_C5   | 200      |    108.687 μs |    31.46 KB |
| Friflo_C5 | 200      |    190.956 μs |   126.66 KB |
| Theia_C5  | 400      |     90.450 μs |    48.49 KB |
| Arch_C5   | 400      |    191.119 μs |    37.48 KB |
| Friflo_C5 | 400      |    391.836 μs |   230.85 KB |
| Theia_C5  | 800      |    192.588 μs |   112.43 KB |
| Arch_C5   | 800      |    369.625 μs |    73.43 KB |
| Friflo_C5 | 800      |    755.856 μs |   485.48 KB |
| Theia_C5  | 1600     |    246.877 μs |   224.12 KB |
| Arch_C5   | 1600     |    637.873 μs |   121.63 KB |
| Friflo_C5 | 1600     |  1,189.207 μs |    995.6 KB |
| Theia_C5  | 3200     |    476.857 μs |    528.2 KB |
| Arch_C5   | 3200     |  1,116.713 μs |   233.61 KB |
| Friflo_C5 | 3200     |  1,982.800 μs |  2019.09 KB |
| Theia_C5  | 6400     |    924.769 μs |  1071.13 KB |
| Arch_C5   | 6400     |  1,965.608 μs |   481.88 KB |
| Friflo_C5 | 6400     |  3,362.325 μs |  4071.92 KB |
| Theia_C5  | 16000    |  2,504.907 μs |  2572.86 KB |
| Arch_C5   | 16000    |  4,951.950 μs |  1110.31 KB |
| Friflo_C5 | 16000    |  7,540.100 μs |  8190.49 KB |
| Theia_C5  | 32000    |  5,345.527 μs |  5143.92 KB |
| Arch_C5   | 32000    |  8,596.513 μs |  2199.61 KB |
| Friflo_C5 | 32000    | 12,023.600 μs | 16452.91 KB |
| Theia_C5  | 64000    |  2,683.219 μs | 10302.23 KB |
| Arch_C5   | 64000    | 11,812.300 μs |  4440.69 KB |
| Friflo_C5 | 64000    | 17,211.263 μs | 33030.58 KB |
| Theia_C5  | 100000   |  4,379.688 μs | 16892.67 KB |
| Arch_C5   | 100000   | 10,867.946 μs |   7689.1 KB |
| Friflo_C5 | 100000   | 21,411.500 μs | 66294.39 KB |
