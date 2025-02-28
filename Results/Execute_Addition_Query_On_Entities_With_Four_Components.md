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
| Theia_C4          | 1        |      5.037 μs |     0.82 KB |
| Theia_C4_Optional | 1        |      3.136 μs |     0.55 KB |
| Arch_C4           | 1        |     16.186 μs |    26.38 KB |
| Friflo_C4         | 1        |      9.000 μs |    14.67 KB |
| Theia_C4          | 5        |      7.519 μs |      1.2 KB |
| Theia_C4_Optional | 5        |      5.400 μs |     0.92 KB |
| Arch_C4           | 5        |     20.813 μs |    26.51 KB |
| Friflo_C4         | 5        |     12.173 μs |    14.58 KB |
| Theia_C4          | 10       |      9.657 μs |     1.66 KB |
| Theia_C4_Optional | 10       |      7.314 μs |     1.39 KB |
| Arch_C4           | 10       |     26.577 μs |    26.88 KB |
| Friflo_C4         | 10       |     15.907 μs |    17.04 KB |
| Theia_C4          | 25       |     17.256 μs |     4.15 KB |
| Theia_C4_Optional | 25       |     14.721 μs |     3.88 KB |
| Arch_C4           | 25       |     41.307 μs |    27.99 KB |
| Friflo_C4         | 25       |     24.767 μs |    21.36 KB |
| Theia_C4          | 50       |     27.964 μs |     6.59 KB |
| Theia_C4_Optional | 50       |     25.719 μs |     6.59 KB |
| Arch_C4           | 50       |     66.388 μs |    29.66 KB |
| Friflo_C4         | 50       |     40.706 μs |     30.2 KB |
| Theia_C4          | 100      |     52.120 μs |     12.3 KB |
| Theia_C4_Optional | 100      |     42.621 μs |    12.03 KB |
| Arch_C4           | 100      |    116.867 μs |    32.92 KB |
| Friflo_C4         | 100      |     71.240 μs |    48.14 KB |
| Theia_C4          | 200      |    103.850 μs |    23.18 KB |
| Theia_C4_Optional | 200      |     83.619 μs |    22.63 KB |
| Arch_C4           | 200      |    204.881 μs |     39.1 KB |
| Friflo_C4         | 200      |    132.853 μs |    84.66 KB |
| Theia_C4          | 400      |    192.900 μs |    44.93 KB |
| Theia_C4_Optional | 400      |    158.243 μs |    44.66 KB |
| Arch_C4           | 400      |    346.871 μs |    52.23 KB |
| Friflo_C4         | 400      |    257.094 μs |    140.7 KB |
| Theia_C4          | 800      |    341.900 μs |   104.95 KB |
| Theia_C4_Optional | 800      |    317.262 μs |   104.67 KB |
| Arch_C4           | 800      |    707.114 μs |   110.25 KB |
| Friflo_C4         | 800      |    483.640 μs |   295.22 KB |
| Theia_C4          | 1600     |    844.906 μs |   207.85 KB |
| Theia_C4_Optional | 1600     |    578.533 μs |   288.56 KB |
| Arch_C4           | 1600     |  1,478.300 μs |   193.54 KB |
| Friflo_C4         | 1600     |    751.536 μs |   604.89 KB |
| Theia_C4          | 3200     |  1,427.747 μs |   423.19 KB |
| Theia_C4_Optional | 3200     |  1,198.620 μs |   590.96 KB |
| Arch_C4           | 3200     |  2,296.943 μs |   376.98 KB |
| Friflo_C4         | 3200     |    774.312 μs |  1229.15 KB |
| Theia_C4          | 6400     |  2,629.080 μs |   851.84 KB |
| Theia_C4_Optional | 6400     |    525.320 μs |  1195.57 KB |
| Arch_C4           | 6400     |  6,216.413 μs |   735.67 KB |
| Friflo_C4         | 6400     |  1,798.600 μs |  2481.49 KB |
| Theia_C4          | 16000    |  3,371.250 μs |  2075.52 KB |
| Theia_C4_Optional | 16000    |  2,041.958 μs |  2771.02 KB |
| Arch_C4           | 16000    |  4,297.269 μs |  1639.41 KB |
| Friflo_C4         | 16000    |  3,129.244 μs |  5000.27 KB |
| Theia_C4          | 32000    |  3,108.586 μs |  4140.63 KB |
| Theia_C4_Optional | 32000    |  2,480.862 μs |  5540.41 KB |
| Arch_C4           | 32000    | 13,153.694 μs |  3305.04 KB |
| Friflo_C4         | 32000    |  2,410.680 μs | 10062.53 KB |
| Theia_C4          | 64000    |  5,490.192 μs |  8286.62 KB |
| Theia_C4_Optional | 64000    |  4,982.681 μs |    11095 KB |
| Arch_C4           | 64000    | 17,056.580 μs |  6750.16 KB |
| Friflo_C4         | 64000    |  4,606.392 μs | 20239.98 KB |
| Theia_C4          | 100000   |  8,650.029 μs |  13293.2 KB |
| Theia_C4_Optional | 100000   |  8,237.260 μs | 18917.02 KB |
| Arch_C4           | 100000   | 26,858.669 μs |  12173.6 KB |
| Friflo_C4         | 100000   |  8,754.562 μs | 40703.35 KB |
