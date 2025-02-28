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
| Theia_C1  | 1        |     2.420 μs |     0.55 KB |
| Arch_C1   | 1        |     6.300 μs |     0.59 KB |
| Friflo_C1 | 1        |     7.454 μs |     1.82 KB |
| Theia_C1  | 5        |     3.427 μs |     0.92 KB |
| Arch_C1   | 5        |     9.119 μs |     0.98 KB |
| Friflo_C1 | 5        |    10.047 μs |     2.09 KB |
| Theia_C1  | 10       |     4.575 μs |     1.39 KB |
| Arch_C1   | 10       |    12.080 μs |      1.2 KB |
| Friflo_C1 | 10       |    12.907 μs |     4.42 KB |
| Theia_C1  | 25       |     8.260 μs |      3.4 KB |
| Arch_C1   | 25       |    20.060 μs |     1.59 KB |
| Friflo_C1 | 25       |    20.440 μs |     9.02 KB |
| Theia_C1  | 50       |    13.420 μs |     5.99 KB |
| Arch_C1   | 50       |    32.893 μs |     2.37 KB |
| Friflo_C1 | 50       |    31.887 μs |    18.38 KB |
| Theia_C1  | 100      |    22.906 μs |    11.18 KB |
| Arch_C1   | 100      |    58.327 μs |     3.89 KB |
| Friflo_C1 | 100      |    54.650 μs |    43.37 KB |
| Theia_C1  | 200      |    40.264 μs |    21.55 KB |
| Arch_C1   | 200      |   110.186 μs |     6.91 KB |
| Friflo_C1 | 200      |    99.475 μs |    87.63 KB |
| Theia_C1  | 400      |    75.192 μs |     42.3 KB |
| Arch_C1   | 400      |   192.007 μs |    12.94 KB |
| Friflo_C1 | 400      |   206.167 μs |   168.02 KB |
| Theia_C1  | 800      |   156.536 μs |     83.8 KB |
| Arch_C1   | 800      |   396.175 μs |    73.78 KB |
| Friflo_C1 | 800      |   410.875 μs |   342.12 KB |
| Theia_C1  | 1600     |   253.006 μs |   263.91 KB |
| Arch_C1   | 1600     |   702.400 μs |    81.21 KB |
| Friflo_C1 | 1600     |   748.950 μs |    692.3 KB |
| Theia_C1  | 3200     |   339.007 μs |   525.99 KB |
| Arch_C1   | 3200     | 1,101.007 μs |   194.18 KB |
| Friflo_C1 | 3200     | 1,149.150 μs |  1396.19 KB |
| Theia_C1  | 6400     |   595.413 μs |  1034.07 KB |
| Arch_C1   | 6400     | 1,995.000 μs |   403.05 KB |
| Friflo_C1 | 6400     | 1,379.987 μs |  2808.48 KB |
| Theia_C1  | 16000    |   798.044 μs |  2398.46 KB |
| Arch_C1   | 16000    | 2,219.475 μs |   908.22 KB |
| Friflo_C1 | 16000    | 2,485.271 μs |  5647.08 KB |
| Theia_C1  | 32000    | 2,522.738 μs |  4795.86 KB |
| Arch_C1   | 32000    | 4,025.092 μs |  1810.04 KB |
| Friflo_C1 | 32000    | 4,705.373 μs | 11348.96 KB |
| Theia_C1  | 64000    | 2,141.646 μs |  9573.78 KB |
| Arch_C1   | 64000    | 5,990.340 μs |   3724.3 KB |
| Friflo_C1 | 64000    | 5,512.056 μs | 22806.65 KB |
| Theia_C1  | 100000   | 3,207.373 μs | 16310.75 KB |
| Arch_C1   | 100000   | 9,344.225 μs |  6633.36 KB |
| Friflo_C1 | 100000   | 9,190.944 μs | 45829.55 KB |
