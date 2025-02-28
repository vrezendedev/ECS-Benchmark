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
| Theia_C2  | 1        |     2.340 μs |     0.55 KB |
| Arch_C2   | 1        |     6.207 μs |     0.59 KB |
| Friflo_C2 | 1        |     4.962 μs |      0.5 KB |
| Theia_C2  | 5        |     3.700 μs |     0.92 KB |
| Arch_C2   | 5        |     8.907 μs |     0.98 KB |
| Friflo_C2 | 5        |     6.125 μs |     0.92 KB |
| Theia_C2  | 10       |     4.629 μs |     1.39 KB |
| Arch_C2   | 10       |    12.021 μs |      1.2 KB |
| Friflo_C2 | 10       |     7.075 μs |     1.16 KB |
| Theia_C2  | 25       |     8.521 μs |     3.59 KB |
| Arch_C2   | 25       |    20.875 μs |     1.59 KB |
| Friflo_C2 | 25       |     9.540 μs |     1.58 KB |
| Theia_C2  | 50       |    12.993 μs |     6.59 KB |
| Arch_C2   | 50       |    36.127 μs |     2.09 KB |
| Friflo_C2 | 50       |    13.214 μs |     2.38 KB |
| Theia_C2  | 100      |    21.860 μs |    12.03 KB |
| Arch_C2   | 100      |    62.631 μs |     3.61 KB |
| Friflo_C2 | 100      |    20.194 μs |     3.92 KB |
| Theia_C2  | 200      |    41.413 μs |    22.91 KB |
| Arch_C2   | 200      |    81.586 μs |     6.91 KB |
| Friflo_C2 | 200      |    35.379 μs |     6.97 KB |
| Theia_C2  | 400      |    77.037 μs |    44.66 KB |
| Arch_C2   | 400      |   143.392 μs |    17.29 KB |
| Friflo_C2 | 400      |    67.114 μs |    13.02 KB |
| Theia_C2  | 800      |   181.750 μs |    88.16 KB |
| Arch_C2   | 800      |   315.506 μs |    33.31 KB |
| Friflo_C2 | 800      |   168.131 μs |    25.06 KB |
| Theia_C2  | 1600     |   241.331 μs |   175.48 KB |
| Arch_C2   | 1600     |   470.223 μs |    65.66 KB |
| Friflo_C2 | 1600     |   252.938 μs |    49.44 KB |
| Theia_C2  | 3200     |   410.681 μs |   365.88 KB |
| Arch_C2   | 3200     |   906.344 μs |   130.34 KB |
| Friflo_C2 | 3200     |   408.036 μs |    98.14 KB |
| Theia_C2  | 6400     |   579.106 μs |   730.16 KB |
| Arch_C2   | 6400     | 1,731.585 μs |   258.37 KB |
| Friflo_C2 | 6400     |   757.447 μs |   194.19 KB |
| Theia_C2  | 16000    | 1,347.775 μs |  1757.88 KB |
| Arch_C2   | 16000    | 4,745.973 μs |   514.11 KB |
| Friflo_C2 | 16000    | 1,487.131 μs |   385.95 KB |
| Theia_C2  | 32000    | 1,333.231 μs |  3514.21 KB |
| Arch_C2   | 32000    | 2,828.217 μs |  1026.46 KB |
| Friflo_C2 | 32000    |   865.233 μs |   770.33 KB |
| Theia_C2  | 64000    | 2,723.194 μs |  7025.55 KB |
| Arch_C2   | 64000    | 5,685.164 μs |  2050.44 KB |
| Friflo_C2 | 64000    | 1,662.929 μs |  1537.72 KB |
| Theia_C2  | 100000   | 4,245.367 μs | 11424.55 KB |
| Arch_C2   | 100000   | 8,924.060 μs |  4097.85 KB |
| Friflo_C2 | 100000   | 2,593.779 μs |  3074.38 KB |
