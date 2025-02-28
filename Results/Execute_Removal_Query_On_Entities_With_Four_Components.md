```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5555/22H2/2022Update)
AMD Ryzen 5 5600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  Job-XJEJRV : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=16  UnrollFactor=1  

```
| Method            | Entities | Mean          | Allocated   |
|------------------ |--------- |--------------:|------------:|
| Theia_C4          | 1        |      4.760 μs |     0.78 KB |
| Theia_C4_Optional | 1        |      3.050 μs |     0.55 KB |
| Arch_C4           | 1        |     14.857 μs |    26.02 KB |
| Friflo_C4         | 1        |      7.320 μs |     1.77 KB |
| Theia_C4          | 5        |      6.913 μs |     0.88 KB |
| Theia_C4_Optional | 5        |      5.243 μs |     0.92 KB |
| Arch_C4           | 5        |     19.673 μs |    26.34 KB |
| Friflo_C4         | 5        |     10.206 μs |     1.95 KB |
| Theia_C4          | 10       |      8.640 μs |     1.63 KB |
| Theia_C4_Optional | 10       |      7.200 μs |     1.39 KB |
| Arch_C4           | 10       |     25.477 μs |     26.8 KB |
| Friflo_C4         | 10       |     13.267 μs |     4.13 KB |
| Theia_C4          | 25       |     14.544 μs |     4.11 KB |
| Theia_C4_Optional | 25       |     13.586 μs |     3.88 KB |
| Arch_C4           | 25       |     39.913 μs |    27.96 KB |
| Friflo_C4         | 25       |     21.420 μs |     8.17 KB |
| Theia_C4          | 50       |     23.393 μs |     6.83 KB |
| Theia_C4_Optional | 50       |     22.714 μs |     6.59 KB |
| Arch_C4           | 50       |     66.513 μs |       30 KB |
| Friflo_C4         | 50       |     35.100 μs |    17.29 KB |
| Theia_C4          | 100      |     43.133 μs |    12.27 KB |
| Theia_C4_Optional | 100      |     40.714 μs |    12.03 KB |
| Arch_C4           | 100      |    127.847 μs |    34.06 KB |
| Friflo_C4         | 100      |     62.720 μs |    35.23 KB |
| Theia_C4          | 200      |     87.607 μs |    23.14 KB |
| Theia_C4_Optional | 200      |     79.900 μs |    22.91 KB |
| Arch_C4           | 200      |    253.350 μs |    42.16 KB |
| Friflo_C4         | 200      |    116.180 μs |    71.75 KB |
| Theia_C4          | 400      |    159.773 μs |    44.89 KB |
| Theia_C4_Optional | 400      |    156.738 μs |    44.66 KB |
| Arch_C4           | 400      |    434.553 μs |    58.34 KB |
| Friflo_C4         | 400      |    222.615 μs |    127.8 KB |
| Theia_C4          | 800      |    391.243 μs |    88.72 KB |
| Theia_C4_Optional | 800      |    302.793 μs |    88.48 KB |
| Arch_C4           | 800      |    642.247 μs |   106.62 KB |
| Friflo_C4         | 800      |    441.853 μs |   274.27 KB |
| Theia_C4          | 1600     |    614.000 μs |   191.86 KB |
| Theia_C4_Optional | 1600     |    599.687 μs |   272.33 KB |
| Arch_C4           | 1600     |  1,709.113 μs |   203.48 KB |
| Friflo_C4         | 1600     |    471.825 μs |   568.17 KB |
| Theia_C4          | 3200     |  1,204.136 μs |   406.82 KB |
| Theia_C4_Optional | 3200     |    833.500 μs |   574.63 KB |
| Arch_C4           | 3200     |  2,856.447 μs |   389.91 KB |
| Friflo_C4         | 3200     |    559.462 μs |   1160.1 KB |
| Theia_C4          | 6400     |  1,627.062 μs |   802.96 KB |
| Theia_C4_Optional | 6400     |  1,919.692 μs |  1146.73 KB |
| Arch_C4           | 6400     |  1,827.006 μs |   769.55 KB |
| Friflo_C4         | 6400     |  1,533.175 μs |  2348.45 KB |
| Theia_C4          | 16000    |  2,971.400 μs |  1944.51 KB |
| Theia_C4_Optional | 16000    |  1,933.307 μs |  2640.32 KB |
| Arch_C4           | 16000    |  4,475.638 μs |  1837.98 KB |
| Friflo_C4         | 16000    |  2,922.438 μs |   4738.8 KB |
| Theia_C4          | 32000    |  2,556.094 μs |   3894.8 KB |
| Theia_C4_Optional | 32000    |  2,460.353 μs |  5294.62 KB |
| Arch_C4           | 32000    |  8,854.362 μs |  3729.87 KB |
| Friflo_C4         | 32000    |  2,221.114 μs |  9545.34 KB |
| Theia_C4          | 64000    |  5,105.857 μs |  7779.12 KB |
| Theia_C4_Optional | 64000    |  4,963.329 μs | 10586.65 KB |
| Arch_C4           | 64000    | 17,721.457 μs |  7569.33 KB |
| Friflo_C4         | 64000    |  4,347.571 μs | 19210.75 KB |
| Theia_C4          | 100000   |  8,096.425 μs | 12489.45 KB |
| Theia_C4_Optional | 100000   |  7,838.033 μs | 18113.22 KB |
| Arch_C4           | 100000   | 28,369.513 μs | 12708.85 KB |
| Friflo_C4         | 100000   |  8,158.663 μs | 38649.74 KB |
