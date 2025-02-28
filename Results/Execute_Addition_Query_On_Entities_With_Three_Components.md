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
| Theia_C3          | 1        |      4.769 μs |      0.8 KB |
| Theia_C3_Optional | 1        |      2.947 μs |     0.55 KB |
| Arch_C3           | 1        |     15.350 μs |    26.27 KB |
| Friflo_C3         | 1        |      8.569 μs |    12.69 KB |
| Theia_C3          | 5        |      7.100 μs |     1.17 KB |
| Theia_C3_Optional | 5        |      5.219 μs |     0.92 KB |
| Arch_C3           | 5        |     20.907 μs |    26.53 KB |
| Friflo_C3         | 5        |     11.633 μs |    12.88 KB |
| Theia_C3          | 10       |      9.057 μs |     1.64 KB |
| Theia_C3_Optional | 10       |      7.100 μs |     1.39 KB |
| Arch_C3           | 10       |     25.936 μs |    26.96 KB |
| Friflo_C3         | 10       |     14.769 μs |    15.05 KB |
| Theia_C3          | 25       |     15.969 μs |     4.13 KB |
| Theia_C3_Optional | 25       |     13.560 μs |     3.88 KB |
| Arch_C3           | 25       |     39.680 μs |    27.78 KB |
| Friflo_C3         | 25       |     22.893 μs |    19.38 KB |
| Theia_C3          | 50       |     24.717 μs |     6.84 KB |
| Theia_C3_Optional | 50       |     22.587 μs |     6.59 KB |
| Arch_C3           | 50       |     62.900 μs |    29.32 KB |
| Friflo_C3         | 50       |     36.847 μs |    27.93 KB |
| Theia_C3          | 100      |     43.919 μs |    12.28 KB |
| Theia_C3_Optional | 100      |     40.188 μs |    12.03 KB |
| Arch_C3           | 100      |    113.112 μs |    32.34 KB |
| Friflo_C3         | 100      |     65.287 μs |    46.16 KB |
| Theia_C3          | 200      |     84.131 μs |    23.16 KB |
| Theia_C3_Optional | 200      |     74.533 μs |    22.91 KB |
| Arch_C3           | 200      |    192.064 μs |     38.3 KB |
| Friflo_C3         | 200      |    119.812 μs |    82.67 KB |
| Theia_C3          | 400      |    182.381 μs |    44.91 KB |
| Theia_C3_Optional | 400      |    159.475 μs |    44.66 KB |
| Arch_C3           | 400      |    374.181 μs |    50.15 KB |
| Friflo_C3         | 400      |    246.363 μs |   138.72 KB |
| Theia_C3          | 800      |    334.300 μs |    88.41 KB |
| Theia_C3_Optional | 800      |    320.606 μs |    88.16 KB |
| Arch_C3           | 800      |    628.493 μs |   114.64 KB |
| Friflo_C3         | 800      |    429.700 μs |   288.88 KB |
| Theia_C3          | 1600     |    568.554 μs |   191.92 KB |
| Theia_C3_Optional | 1600     |    524.800 μs |   272.38 KB |
| Arch_C3           | 1600     |  1,459.320 μs |   185.31 KB |
| Friflo_C3         | 1600     |    727.000 μs |   591.14 KB |
| Theia_C3          | 3200     |  1,030.420 μs |   406.98 KB |
| Theia_C3_Optional | 3200     |    787.673 μs |   574.77 KB |
| Arch_C3           | 3200     |  2,321.675 μs |    336.6 KB |
| Friflo_C3         | 3200     |  1,167.638 μs |  1199.09 KB |
| Theia_C3          | 6400     |  2,277.967 μs |   819.45 KB |
| Theia_C3_Optional | 6400     |  1,428.175 μs |  1163.52 KB |
| Arch_C3           | 6400     |  1,602.081 μs |   670.91 KB |
| Friflo_C3         | 6400     |  1,602.256 μs |  2419.74 KB |
| Theia_C3          | 16000    |  1,280.867 μs |   2010.8 KB |
| Theia_C3_Optional | 16000    |  1,166.679 μs |  2706.27 KB |
| Arch_C3           | 16000    |  3,877.787 μs |  1506.91 KB |
| Friflo_C3         | 16000    |  1,616.100 μs |  4873.84 KB |
| Theia_C3          | 32000    |  2,448.387 μs |  4027.74 KB |
| Theia_C3_Optional | 32000    |  2,336.193 μs |  5427.21 KB |
| Arch_C3           | 32000    |  7,774.238 μs |  3034.63 KB |
| Friflo_C3         | 32000    |  3,132.975 μs |  9808.69 KB |
| Theia_C3          | 64000    |  4,905.010 μs |  8045.91 KB |
| Theia_C3_Optional | 64000    |  4,744.938 μs |  10853.1 KB |
| Arch_C3           | 64000    | 15,611.144 μs |  6176.57 KB |
| Friflo_C3         | 64000    |  4,436.017 μs | 19729.88 KB |
| Theia_C3          | 100000   |  7,559.620 μs | 12898.33 KB |
| Theia_C3_Optional | 100000   |  7,294.007 μs | 18522.45 KB |
| Arch_C3           | 100000   | 24,356.556 μs | 11142.77 KB |
| Friflo_C3         | 100000   |  7,696.092 μs |  39680.8 KB |
