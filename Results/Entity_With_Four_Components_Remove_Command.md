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
| Theia_C4  | 1        |      3.720 μs |     0.72 KB |
| Arch_C4   | 1        |     12.308 μs |    25.61 KB |
| Friflo_C4 | 1        |      5.186 μs |     1.65 KB |
| Theia_C4  | 5        |      5.833 μs |     1.09 KB |
| Arch_C4   | 5        |     17.053 μs |    25.93 KB |
| Friflo_C4 | 5        |      7.994 μs |     1.84 KB |
| Theia_C4  | 10       |      7.480 μs |     1.28 KB |
| Arch_C4   | 10       |     22.686 μs |    26.39 KB |
| Friflo_C4 | 10       |     10.773 μs |     4.02 KB |
| Theia_C4  | 25       |     13.600 μs |     4.05 KB |
| Arch_C4   | 25       |     37.038 μs |    27.55 KB |
| Friflo_C4 | 25       |     18.238 μs |     8.34 KB |
| Theia_C4  | 50       |     21.438 μs |     6.48 KB |
| Arch_C4   | 50       |     62.693 μs |    29.27 KB |
| Friflo_C4 | 50       |     32.194 μs |    17.17 KB |
| Theia_C4  | 100      |     43.007 μs |     12.2 KB |
| Arch_C4   | 100      |    121.431 μs |    33.66 KB |
| Friflo_C4 | 100      |     57.600 μs |    34.84 KB |
| Theia_C4  | 200      |     84.920 μs |     22.8 KB |
| Arch_C4   | 200      |    234.950 μs |    41.76 KB |
| Friflo_C4 | 200      |    109.975 μs |    71.63 KB |
| Theia_C4  | 400      |    156.053 μs |    44.83 KB |
| Arch_C4   | 400      |    416.257 μs |    57.94 KB |
| Friflo_C4 | 400      |    210.692 μs |   127.68 KB |
| Theia_C4  | 800      |    290.046 μs |    88.66 KB |
| Arch_C4   | 800      |    942.788 μs |   106.21 KB |
| Friflo_C4 | 800      |    412.633 μs |   274.15 KB |
| Theia_C4  | 1600     |    601.207 μs |    191.8 KB |
| Arch_C4   | 1600     |  1,762.412 μs |   203.36 KB |
| Friflo_C4 | 1600     |    614.279 μs |   568.05 KB |
| Theia_C4  | 3200     |    876.700 μs |   406.76 KB |
| Arch_C4   | 3200     |  2,870.536 μs |   389.51 KB |
| Friflo_C4 | 3200     |    514.993 μs |  1159.98 KB |
| Theia_C4  | 6400     |  2,022.787 μs |    802.9 KB |
| Arch_C4   | 6400     |  7,614.913 μs |   769.14 KB |
| Friflo_C4 | 6400     |  1,587.713 μs |  2348.33 KB |
| Theia_C4  | 16000    |  2,652.550 μs |  1944.45 KB |
| Arch_C4   | 16000    |  4,518.540 μs |  1837.58 KB |
| Friflo_C4 | 16000    |  1,405.994 μs |  4738.97 KB |
| Theia_C4  | 32000    |  2,494.512 μs |  3894.74 KB |
| Arch_C4   | 32000    |  9,189.720 μs |  3729.46 KB |
| Friflo_C4 | 32000    |  2,089.079 μs |  9545.23 KB |
| Theia_C4  | 64000    |  5,085.520 μs |   7778.4 KB |
| Arch_C4   | 64000    | 18,611.783 μs |  7567.66 KB |
| Friflo_C4 | 64000    |  4,133.738 μs | 19210.96 KB |
| Theia_C4  | 100000   |  7,927.633 μs | 12489.06 KB |
| Arch_C4   | 100000   | 28,720.750 μs | 12708.77 KB |
| Friflo_C4 | 100000   |  7,832.575 μs | 38649.91 KB |
