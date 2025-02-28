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
| Theia_C2          | 1        |      4.579 μs |     0.78 KB |
| Theia_C2_Optional | 1        |      2.763 μs |     0.27 KB |
| Arch_C2           | 1        |     16.243 μs |    34.26 KB |
| Friflo_C2         | 1        |      8.800 μs |    10.72 KB |
| Theia_C2          | 5        |      6.557 μs |     1.16 KB |
| Theia_C2_Optional | 5        |      4.723 μs |     0.92 KB |
| Arch_C2           | 5        |     21.586 μs |     34.5 KB |
| Friflo_C2         | 5        |     11.427 μs |    10.91 KB |
| Theia_C2          | 10       |      8.392 μs |     1.63 KB |
| Theia_C2_Optional | 10       |      6.354 μs |     1.39 KB |
| Arch_C2           | 10       |     26.127 μs |     34.9 KB |
| Friflo_C2         | 10       |     14.136 μs |    13.09 KB |
| Theia_C2          | 25       |     14.871 μs |     4.11 KB |
| Theia_C2_Optional | 25       |     12.640 μs |     3.88 KB |
| Arch_C2           | 25       |     38.986 μs |    35.66 KB |
| Friflo_C2         | 25       |     22.040 μs |    17.41 KB |
| Theia_C2          | 50       |     24.738 μs |     6.83 KB |
| Theia_C2_Optional | 50       |     19.762 μs |     6.59 KB |
| Arch_C2           | 50       |     60.154 μs |    37.07 KB |
| Friflo_C2         | 50       |     33.427 μs |    26.24 KB |
| Theia_C2          | 100      |     38.793 μs |    12.27 KB |
| Theia_C2_Optional | 100      |     35.100 μs |    12.03 KB |
| Arch_C2           | 100      |     97.764 μs |    39.84 KB |
| Friflo_C2         | 100      |     59.000 μs |    44.19 KB |
| Theia_C2          | 200      |     73.000 μs |    23.14 KB |
| Theia_C2_Optional | 200      |     66.056 μs |    22.91 KB |
| Arch_C2           | 200      |    174.067 μs |     45.3 KB |
| Friflo_C2         | 200      |    107.671 μs |     80.7 KB |
| Theia_C2          | 400      |    150.480 μs |    44.89 KB |
| Theia_C2_Optional | 400      |    138.044 μs |    44.66 KB |
| Arch_C2           | 400      |    307.083 μs |    56.15 KB |
| Friflo_C2         | 400      |    211.981 μs |   136.75 KB |
| Theia_C2          | 800      |    353.438 μs |    88.39 KB |
| Theia_C2_Optional | 800      |    299.869 μs |    88.16 KB |
| Arch_C2           | 800      |    679.587 μs |    77.78 KB |
| Friflo_C2         | 800      |    459.137 μs |   282.89 KB |
| Theia_C2          | 1600     |    519.446 μs |   191.86 KB |
| Theia_C2_Optional | 1600     |    448.262 μs |   272.33 KB |
| Arch_C2           | 1600     |  1,050.221 μs |   161.38 KB |
| Friflo_C2         | 1600     |    684.415 μs |   576.84 KB |
| Theia_C2          | 3200     |    952.821 μs |   406.54 KB |
| Theia_C2_Optional | 3200     |    802.306 μs |   574.63 KB |
| Arch_C2           | 3200     |  1,983.119 μs |   312.67 KB |
| Friflo_C2         | 3200     |    929.919 μs |  1169.05 KB |
| Theia_C2          | 6400     |    575.900 μs |   803.24 KB |
| Theia_C2_Optional | 6400     |  1,306.979 μs |  1147.05 KB |
| Arch_C2           | 6400     |  3,469.338 μs |   606.65 KB |
| Friflo_C2         | 6400     |    884.567 μs |  2357.68 KB |
| Theia_C2          | 16000    |  4,411.960 μs |  1944.18 KB |
| Theia_C2_Optional | 16000    |  2,867.438 μs |  2640.04 KB |
| Arch_C2           | 16000    | 10,597.831 μs |  1352.71 KB |
| Friflo_C2         | 16000    |  2,200.944 μs |  4747.71 KB |
| Theia_C2          | 32000    |  2,043.364 μs |  3895.53 KB |
| Theia_C2_Optional | 32000    |  2,076.100 μs |  5295.34 KB |
| Arch_C2           | 32000    |  6,874.236 μs |     2743 KB |
| Friflo_C2         | 32000    |  2,169.392 μs |   9554.3 KB |
| Theia_C2          | 64000    |  4,177.487 μs |   7779.7 KB |
| Theia_C2_Optional | 64000    |  4,120.000 μs | 10588.17 KB |
| Arch_C2           | 64000    | 13,793.173 μs |  5593.85 KB |
| Friflo_C2         | 64000    |  4,121.415 μs | 19219.75 KB |
| Theia_C2          | 100000   |  6,426.988 μs | 12489.78 KB |
| Theia_C2_Optional | 100000   |  6,415.980 μs | 18113.27 KB |
| Arch_C2           | 100000   | 22,041.225 μs | 10082.61 KB |
| Friflo_C2         | 100000   |  8,675.869 μs | 38658.98 KB |
