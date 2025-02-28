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
| Theia_C5  | 1        |      4.207 μs |     0.77 KB |
| Arch_C5   | 1        |     13.900 μs |    26.03 KB |
| Friflo_C5 | 1        |      7.164 μs |    16.63 KB |
| Theia_C5  | 5        |      6.806 μs |     0.87 KB |
| Arch_C5   | 5        |     18.808 μs |    26.16 KB |
| Friflo_C5 | 5        |     10.614 μs |    16.81 KB |
| Theia_C5  | 10       |      9.100 μs |     1.62 KB |
| Arch_C5   | 10       |     24.620 μs |    26.55 KB |
| Friflo_C5 | 10       |     14.053 μs |    18.99 KB |
| Theia_C5  | 25       |     17.371 μs |      4.1 KB |
| Arch_C5   | 25       |     39.980 μs |    27.27 KB |
| Friflo_C5 | 25       |     23.867 μs |    23.31 KB |
| Theia_C5  | 50       |     30.144 μs |     6.82 KB |
| Arch_C5   | 50       |     62.769 μs |    28.63 KB |
| Friflo_C5 | 50       |     39.487 μs |    32.15 KB |
| Theia_C5  | 100      |     61.900 μs |    12.26 KB |
| Arch_C5   | 100      |    113.044 μs |    31.27 KB |
| Friflo_C5 | 100      |     69.747 μs |    50.09 KB |
| Theia_C5  | 200      |    136.831 μs |    23.13 KB |
| Arch_C5   | 200      |    236.013 μs |    36.48 KB |
| Friflo_C5 | 200      |    155.180 μs |    86.61 KB |
| Theia_C5  | 400      |    170.560 μs |    44.88 KB |
| Arch_C5   | 400      |    354.536 μs |    46.83 KB |
| Friflo_C5 | 400      |    216.320 μs |   142.66 KB |
| Theia_C5  | 800      |    446.656 μs |   104.97 KB |
| Arch_C5   | 800      |    813.207 μs |    99.87 KB |
| Friflo_C5 | 800      |    476.756 μs |    301.2 KB |
| Theia_C5  | 1600     |    645.350 μs |   208.23 KB |
| Arch_C5   | 1600     |  1,310.093 μs |   189.14 KB |
| Friflo_C5 | 1600     |    826.146 μs |   619.17 KB |
| Theia_C5  | 3200     |  1,407.950 μs |   439.68 KB |
| Arch_C5   | 3200     |  2,502.964 μs |   352.76 KB |
| Friflo_C5 | 3200     |  1,129.656 μs |  1259.17 KB |
| Theia_C5  | 6400     |  2,898.360 μs |   868.64 KB |
| Arch_C5   | 6400     |  6,096.725 μs |   671.77 KB |
| Friflo_C5 | 6400     |  1,336.464 μs |  2543.59 KB |
| Theia_C5  | 16000    |  1,631.692 μs |  2142.13 KB |
| Arch_C5   | 16000    |  4,804.567 μs |  1737.18 KB |
| Friflo_C5 | 16000    |  1,928.500 μs |  5126.34 KB |
| Theia_C5  | 32000    |  3,394.960 μs |  4273.88 KB |
| Arch_C5   | 32000    |  9,470.650 μs |  3545.59 KB |
| Friflo_C5 | 32000    |  2,430.736 μs | 10316.63 KB |
| Theia_C5  | 64000    |  6,181.323 μs |  8553.52 KB |
| Arch_C5   | 64000    | 18,917.900 μs |  7264.38 KB |
| Friflo_C5 | 64000    |  4,799.913 μs | 20750.15 KB |
| Theia_C5  | 100000   |  9,676.600 μs |  13690.3 KB |
| Arch_C5   | 100000   | 29,741.640 μs | 11347.02 KB |
| Friflo_C5 | 100000   | 10,190.288 μs | 41725.12 KB |
