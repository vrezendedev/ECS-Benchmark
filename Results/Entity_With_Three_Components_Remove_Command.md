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
| Theia_C3  | 1        |      3.663 μs |      0.7 KB |
| Arch_C3   | 1        |     13.513 μs |    33.59 KB |
| Friflo_C3 | 1        |      5.240 μs |     1.37 KB |
| Theia_C3  | 5        |      5.600 μs |     1.08 KB |
| Arch_C3   | 5        |     18.323 μs |    33.88 KB |
| Friflo_C3 | 5        |      7.781 μs |     1.84 KB |
| Theia_C3  | 10       |      6.981 μs |     1.55 KB |
| Arch_C3   | 10       |     22.815 μs |     34.3 KB |
| Friflo_C3 | 10       |     10.400 μs |     4.02 KB |
| Theia_C3  | 25       |     12.767 μs |     4.03 KB |
| Arch_C3   | 25       |     35.807 μs |    35.35 KB |
| Friflo_C3 | 25       |     17.113 μs |     8.34 KB |
| Theia_C3  | 50       |     19.443 μs |     6.75 KB |
| Arch_C3   | 50       |     56.914 μs |     37.2 KB |
| Friflo_C3 | 50       |     28.293 μs |    17.17 KB |
| Theia_C3  | 100      |     34.407 μs |    12.19 KB |
| Arch_C3   | 100      |    101.146 μs |    40.87 KB |
| Friflo_C3 | 100      |     50.500 μs |    35.12 KB |
| Theia_C3  | 200      |     69.020 μs |    23.06 KB |
| Arch_C3   | 200      |    210.019 μs |    48.19 KB |
| Friflo_C3 | 200      |     95.820 μs |    71.63 KB |
| Theia_C3  | 400      |    147.831 μs |    44.81 KB |
| Arch_C3   | 400      |    435.175 μs |     62.8 KB |
| Friflo_C3 | 400      |    215.700 μs |   127.68 KB |
| Theia_C3  | 800      |    258.585 μs |    88.31 KB |
| Arch_C3   | 800      |    656.729 μs |    92.02 KB |
| Friflo_C3 | 800      |    385.540 μs |    269.8 KB |
| Theia_C3  | 1600     |    479.553 μs |   191.76 KB |
| Arch_C3   | 1600     |  1,625.444 μs |   190.78 KB |
| Friflo_C3 | 1600     |    547.327 μs |   556.01 KB |
| Theia_C3  | 3200     |    751.513 μs |   390.55 KB |
| Arch_C3   | 3200     |  2,741.350 μs |   380.48 KB |
| Friflo_C3 | 3200     |    934.200 μs |  1131.91 KB |
| Theia_C3  | 6400     |  1,772.281 μs |   770.79 KB |
| Arch_C3   | 6400     |  2,144.650 μs |   719.18 KB |
| Friflo_C3 | 6400     |  1,322.844 μs |  2288.52 KB |
| Theia_C3  | 16000    |  1,070.415 μs |  1878.95 KB |
| Arch_C3   | 16000    |  7,873.750 μs |  1652.37 KB |
| Friflo_C3 | 16000    |  2,641.869 μs |  4614.52 KB |
| Theia_C3  | 32000    |  2,260.986 μs |  3765.51 KB |
| Arch_C3   | 32000    |  8,176.120 μs |  3336.95 KB |
| Friflo_C3 | 32000    |  2,702.338 μs |  9293.04 KB |
| Theia_C3  | 64000    |  4,306.893 μs |  7521.23 KB |
| Arch_C3   | 64000    | 15,945.425 μs |  6760.84 KB |
| Friflo_C3 | 64000    |  4,026.012 μs | 18702.52 KB |
| Theia_C3  | 100000   |  6,843.900 μs | 12099.96 KB |
| Arch_C3   | 100000   | 25,037.556 μs | 11425.41 KB |
| Friflo_C3 | 100000   |  7,650.200 μs | 37629.67 KB |
