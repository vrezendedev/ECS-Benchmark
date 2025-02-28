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
| Theia_C2          | 1        |      4.271 μs |     0.74 KB |
| Theia_C2_Optional | 1        |      2.720 μs |     0.55 KB |
| Arch_C2           | 1        |     17.600 μs |    50.05 KB |
| Friflo_C2         | 1        |      6.813 μs |     1.77 KB |
| Theia_C2          | 5        |      5.920 μs |     1.12 KB |
| Theia_C2_Optional | 5        |      4.540 μs |     0.92 KB |
| Arch_C2           | 5        |     21.814 μs |    50.31 KB |
| Friflo_C2         | 5        |      9.371 μs |     1.95 KB |
| Theia_C2          | 10       |      7.280 μs |     1.59 KB |
| Theia_C2_Optional | 10       |      6.113 μs |     1.39 KB |
| Arch_C2           | 10       |     26.020 μs |     50.7 KB |
| Friflo_C2         | 10       |     12.138 μs |     3.85 KB |
| Theia_C2          | 25       |     12.213 μs |     4.07 KB |
| Theia_C2_Optional | 25       |     11.881 μs |     3.88 KB |
| Arch_C2           | 25       |     38.250 μs |    51.63 KB |
| Friflo_C2         | 25       |     18.915 μs |     8.45 KB |
| Theia_C2          | 50       |     18.220 μs |     6.79 KB |
| Theia_C2_Optional | 50       |     19.053 μs |     6.59 KB |
| Arch_C2           | 50       |     56.453 μs |    52.99 KB |
| Friflo_C2         | 50       |     30.367 μs |    17.29 KB |
| Theia_C2          | 100      |     31.329 μs |    12.23 KB |
| Theia_C2_Optional | 100      |     34.179 μs |    12.03 KB |
| Arch_C2           | 100      |     93.507 μs |    56.55 KB |
| Friflo_C2         | 100      |     51.140 μs |    35.23 KB |
| Theia_C2          | 200      |     54.454 μs |     23.1 KB |
| Theia_C2_Optional | 200      |     65.360 μs |    22.91 KB |
| Arch_C2           | 200      |    182.547 μs |    63.09 KB |
| Friflo_C2         | 200      |     94.133 μs |    71.75 KB |
| Theia_C2          | 400      |    115.060 μs |    44.85 KB |
| Theia_C2_Optional | 400      |    128.287 μs |    44.66 KB |
| Arch_C2           | 400      |    330.107 μs |    76.15 KB |
| Friflo_C2         | 400      |    189.900 μs |    127.8 KB |
| Theia_C2          | 800      |    269.275 μs |    88.35 KB |
| Theia_C2_Optional | 800      |    292.469 μs |    88.16 KB |
| Arch_C2           | 800      |    684.007 μs |   102.23 KB |
| Friflo_C2         | 800      |    409.663 μs |   265.89 KB |
| Theia_C2          | 1600     |    380.793 μs |   175.68 KB |
| Theia_C2_Optional | 1600     |    374.167 μs |   256.19 KB |
| Arch_C2           | 1600     |  1,050.467 μs |   202.79 KB |
| Friflo_C2         | 1600     |    624.200 μs |   544.08 KB |
| Theia_C2          | 3200     |    779.075 μs |   374.16 KB |
| Theia_C2_Optional | 3200     |    595.781 μs |   542.29 KB |
| Arch_C2           | 3200     |  2,583.600 μs |    339.9 KB |
| Friflo_C2         | 3200     |  1,006.894 μs |  1103.96 KB |
| Theia_C2          | 6400     |  1,255.300 μs |   754.59 KB |
| Theia_C2_Optional | 6400     |    968.860 μs |  1098.45 KB |
| Arch_C2           | 6400     |  1,599.231 μs |   629.29 KB |
| Friflo_C2         | 6400     |    939.547 μs |  2228.54 KB |
| Theia_C2          | 16000    |  2,714.969 μs |  1814.58 KB |
| Theia_C2_Optional | 16000    |  2,472.507 μs |  2510.48 KB |
| Arch_C2           | 16000    |  3,482.950 μs |  1510.45 KB |
| Friflo_C2         | 16000    |  1,732.487 μs |  4490.57 KB |
| Theia_C2          | 32000    |  1,862.088 μs |  3635.53 KB |
| Theia_C2_Optional | 32000    |  1,842.606 μs |   5035.1 KB |
| Arch_C2           | 32000    |  6,780.779 μs |  2984.13 KB |
| Friflo_C2         | 32000    |  1,980.973 μs |  9041.06 KB |
| Theia_C2          | 64000    |  3,615.307 μs |  7275.84 KB |
| Theia_C2_Optional | 64000    |  3,733.014 μs | 10084.35 KB |
| Arch_C2           | 64000    | 13,643.753 μs |  6007.38 KB |
| Friflo_C2         | 64000    |  4,288.544 μs | 18193.16 KB |
| Theia_C2          | 100000   |  5,859.044 μs | 11692.45 KB |
| Theia_C2_Optional | 100000   |  5,871.243 μs | 17316.02 KB |
| Arch_C2           | 100000   | 21,583.529 μs | 10189.12 KB |
| Friflo_C2         | 100000   |  8,086.417 μs | 36609.65 KB |
