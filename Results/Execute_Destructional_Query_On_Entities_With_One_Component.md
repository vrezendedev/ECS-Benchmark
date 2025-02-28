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
| Theia_C1  | 1        |     2.043 μs |     0.55 KB |
| Arch_C1   | 1        |     6.067 μs |     0.87 KB |
| Friflo_C1 | 1        |     4.753 μs |     0.78 KB |
| Theia_C1  | 5        |     3.427 μs |     0.92 KB |
| Arch_C1   | 5        |     8.925 μs |     0.98 KB |
| Friflo_C1 | 5        |     6.269 μs |     0.92 KB |
| Theia_C1  | 10       |     4.173 μs |     1.39 KB |
| Arch_C1   | 10       |    11.920 μs |      1.2 KB |
| Friflo_C1 | 10       |     6.807 μs |     0.88 KB |
| Theia_C1  | 25       |     8.025 μs |     3.88 KB |
| Arch_C1   | 25       |    19.727 μs |     1.59 KB |
| Friflo_C1 | 25       |     9.225 μs |     1.58 KB |
| Theia_C1  | 50       |    12.271 μs |     6.59 KB |
| Arch_C1   | 50       |    35.487 μs |     2.37 KB |
| Friflo_C1 | 50       |    14.213 μs |     2.38 KB |
| Theia_C1  | 100      |    20.820 μs |    12.03 KB |
| Arch_C1   | 100      |    60.706 μs |     3.89 KB |
| Friflo_C1 | 100      |    19.267 μs |     3.92 KB |
| Theia_C1  | 200      |    34.320 μs |    22.91 KB |
| Arch_C1   | 200      |    87.214 μs |     6.91 KB |
| Friflo_C1 | 200      |    34.407 μs |     6.97 KB |
| Theia_C1  | 400      |    66.520 μs |    44.66 KB |
| Arch_C1   | 400      |   140.900 μs |    17.29 KB |
| Friflo_C1 | 400      |    68.556 μs |    13.02 KB |
| Theia_C1  | 800      |   141.467 μs |    88.16 KB |
| Arch_C1   | 800      |   263.640 μs |    33.31 KB |
| Friflo_C1 | 800      |   127.669 μs |    25.06 KB |
| Theia_C1  | 1600     |   238.540 μs |   175.48 KB |
| Arch_C1   | 1600     |   491.962 μs |    65.66 KB |
| Friflo_C1 | 1600     |   259.520 μs |    49.44 KB |
| Theia_C1  | 3200     |   303.843 μs |   366.16 KB |
| Arch_C1   | 3200     |   806.962 μs |   130.34 KB |
| Friflo_C1 | 3200     |   369.820 μs |    98.14 KB |
| Theia_C1  | 6400     |   462.333 μs |   730.16 KB |
| Arch_C1   | 6400     | 1,310.237 μs |   258.37 KB |
| Friflo_C1 | 6400     |   655.662 μs |   194.19 KB |
| Theia_C1  | 16000    |   776.763 μs |  1758.16 KB |
| Arch_C1   | 16000    | 1,407.250 μs |   514.39 KB |
| Friflo_C1 | 16000    |   896.000 μs |   386.23 KB |
| Theia_C1  | 32000    | 1,207.231 μs |  3513.88 KB |
| Arch_C1   | 32000    | 4,707.069 μs |  1026.09 KB |
| Friflo_C1 | 32000    |   917.638 μs |      770 KB |
| Theia_C1  | 64000    | 2,400.227 μs |  7026.16 KB |
| Arch_C1   | 64000    | 5,343.947 μs |   2048.8 KB |
| Friflo_C1 | 64000    | 1,611.160 μs |  1538.33 KB |
| Theia_C1  | 100000   | 3,747.243 μs | 11424.23 KB |
| Arch_C1   | 100000   | 8,377.950 μs |  4097.85 KB |
| Friflo_C1 | 100000   | 2,555.677 μs |  3073.44 KB |
