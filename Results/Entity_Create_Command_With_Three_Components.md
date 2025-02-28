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
| Theia_C3  | 1        |      1.775 μs |     0.49 KB |
| Arch_C3   | 1        |     10.300 μs |    25.38 KB |
| Friflo_C3 | 1        |      8.236 μs |    10.86 KB |
| Theia_C3  | 5        |      2.813 μs |      0.9 KB |
| Arch_C3   | 5        |     13.321 μs |     25.5 KB |
| Friflo_C3 | 5        |     12.047 μs |    10.85 KB |
| Theia_C3  | 10       |      3.786 μs |     1.41 KB |
| Arch_C3   | 10       |     15.873 μs |    25.71 KB |
| Friflo_C3 | 10       |     15.729 μs |    14.01 KB |
| Theia_C3  | 25       |      7.546 μs |     3.53 KB |
| Arch_C3   | 25       |     23.550 μs |    25.83 KB |
| Friflo_C3 | 25       |     25.873 μs |    19.65 KB |
| Theia_C3  | 50       |     12.312 μs |     6.32 KB |
| Arch_C3   | 50       |     36.246 μs |    26.88 KB |
| Friflo_C3 | 50       |     41.693 μs |    31.05 KB |
| Theia_C3  | 100      |     21.380 μs |     11.9 KB |
| Arch_C3   | 100      |     62.036 μs |    28.41 KB |
| Friflo_C3 | 100      |     72.657 μs |    54.07 KB |
| Theia_C3  | 200      |     41.540 μs |    23.05 KB |
| Arch_C3   | 200      |    112.893 μs |    31.43 KB |
| Friflo_C3 | 200      |    137.344 μs |   106.68 KB |
| Theia_C3  | 400      |     76.320 μs |    45.37 KB |
| Arch_C3   | 400      |    184.860 μs |    37.45 KB |
| Friflo_C3 | 400      |    284.738 μs |   194.82 KB |
| Theia_C3  | 800      |    151.944 μs |    89.99 KB |
| Arch_C3   | 800      |    367.125 μs |    49.48 KB |
| Friflo_C3 | 800      |    579.438 μs |   409.08 KB |
| Theia_C3  | 1600     |    211.873 μs |   195.38 KB |
| Arch_C3   | 1600     |    618.946 μs |   105.73 KB |
| Friflo_C3 | 1600     |    919.292 μs |    839.1 KB |
| Theia_C3  | 3200     |    383.006 μs |   486.87 KB |
| Arch_C3   | 3200     |  1,067.193 μs |   217.66 KB |
| Friflo_C3 | 3200     |  1,571.643 μs |  1702.49 KB |
| Theia_C3  | 6400     |    813.731 μs |   972.29 KB |
| Arch_C3   | 6400     |  1,971.213 μs |   441.84 KB |
| Friflo_C3 | 6400     |  2,706.306 μs |  3434.95 KB |
| Theia_C3  | 16000    |  2,239.829 μs |  2316.55 KB |
| Arch_C3   | 16000    |  4,665.038 μs |  1013.23 KB |
| Friflo_C3 | 16000    |  5,841.294 μs |  6913.71 KB |
| Theia_C3  | 32000    |  4,746.206 μs |  4648.91 KB |
| Arch_C3   | 32000    |  8,639.407 μs |  2043.75 KB |
| Friflo_C3 | 32000    | 10,200.327 μs | 13896.04 KB |
| Theia_C3  | 64000    |  5,195.663 μs |  9296.02 KB |
| Arch_C3   | 64000    | 12,533.200 μs |  4145.11 KB |
| Friflo_C3 | 64000    | 15,715.225 μs | 27913.61 KB |
| Theia_C3  | 100000   |  3,947.443 μs | 15310.69 KB |
| Arch_C3   | 100000   | 10,551.350 μs |   7214.5 KB |
| Friflo_C3 | 100000   | 17,534.314 μs | 56057.33 KB |
