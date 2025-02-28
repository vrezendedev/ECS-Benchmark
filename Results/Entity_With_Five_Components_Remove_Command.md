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
| Theia_C5  | 1        |      3.840 μs |     0.73 KB |
| Arch_C5   | 1        |     12.715 μs |    25.66 KB |
| Friflo_C5 | 1        |      5.379 μs |     1.65 KB |
| Theia_C5  | 5        |      6.146 μs |     1.11 KB |
| Arch_C5   | 5        |     17.833 μs |    26.01 KB |
| Friflo_C5 | 5        |      8.171 μs |     1.84 KB |
| Theia_C5  | 10       |      8.100 μs |      1.3 KB |
| Arch_C5   | 10       |     23.814 μs |    26.51 KB |
| Friflo_C5 | 10       |     11.256 μs |     4.02 KB |
| Theia_C5  | 25       |     14.700 μs |     4.06 KB |
| Arch_C5   | 25       |     40.269 μs |    27.79 KB |
| Friflo_C5 | 25       |     19.250 μs |     8.34 KB |
| Theia_C5  | 50       |     25.681 μs |     6.78 KB |
| Arch_C5   | 50       |     64.731 μs |    30.02 KB |
| Friflo_C5 | 50       |     33.919 μs |    17.17 KB |
| Theia_C5  | 100      |     51.019 μs |    12.22 KB |
| Arch_C5   | 100      |    145.181 μs |    34.48 KB |
| Friflo_C5 | 100      |     59.640 μs |    35.12 KB |
| Theia_C5  | 200      |    108.956 μs |    23.09 KB |
| Arch_C5   | 200      |    295.793 μs |    43.36 KB |
| Friflo_C5 | 200      |    136.137 μs |    71.63 KB |
| Theia_C5  | 400      |    171.236 μs |    44.56 KB |
| Arch_C5   | 400      |    465.060 μs |     61.1 KB |
| Friflo_C5 | 400      |    209.981 μs |    127.4 KB |
| Theia_C5  | 800      |    381.462 μs |    88.67 KB |
| Arch_C5   | 800      |  1,138.673 μs |   128.89 KB |
| Friflo_C5 | 800      |    410.550 μs |   278.17 KB |
| Theia_C5  | 1600     |    544.925 μs |   191.86 KB |
| Arch_C5   | 1600     |  1,683.527 μs |    231.8 KB |
| Friflo_C5 | 1600     |    751.200 μs |    580.1 KB |
| Theia_C5  | 3200     |  1,229.950 μs |   406.91 KB |
| Arch_C5   | 3200     |  3,274.769 μs |   438.59 KB |
| Friflo_C5 | 3200     |  1,003.306 μs |  1188.05 KB |
| Theia_C5  | 6400     |  2,408.069 μs |   819.38 KB |
| Arch_C5   | 6400     |  4,484.875 μs |   859.64 KB |
| Friflo_C5 | 6400     |    851.875 μs |  2408.42 KB |
| Theia_C5  | 16000    |  3,900.238 μs |  2010.69 KB |
| Arch_C5   | 16000    | 10,597.506 μs |  2062.29 KB |
| Friflo_C5 | 16000    |  1,676.377 μs |  4863.13 KB |
| Theia_C5  | 32000    |  2,987.130 μs |  4027.23 KB |
| Arch_C5   | 32000    | 10,397.593 μs |  4144.16 KB |
| Friflo_C5 | 32000    |  2,655.863 μs |  9797.37 KB |
| Theia_C5  | 64000    |  5,881.519 μs |  8043.39 KB |
| Arch_C5   | 64000    | 20,964.747 μs |  8405.88 KB |
| Friflo_C5 | 64000    |  5,117.279 μs | 19718.84 KB |
| Theia_C5  | 100000   |  9,226.897 μs | 12896.55 KB |
| Arch_C5   | 100000   | 32,788.530 μs |  14050.5 KB |
| Friflo_C5 | 100000   |  9,254.494 μs | 39670.14 KB |
