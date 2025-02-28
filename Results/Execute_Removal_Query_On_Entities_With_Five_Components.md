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
| Theia_C5          | 1        |      5.000 μs |      0.8 KB |
| Theia_C5_Optional | 1        |      3.256 μs |     0.55 KB |
| Arch_C5           | 1        |     15.227 μs |    26.06 KB |
| Friflo_C5         | 1        |      7.521 μs |     1.77 KB |
| Theia_C5          | 5        |      7.300 μs |     1.17 KB |
| Theia_C5_Optional | 5        |      5.627 μs |     0.92 KB |
| Arch_C5           | 5        |     21.046 μs |    26.41 KB |
| Friflo_C5         | 5        |     10.521 μs |     1.95 KB |
| Theia_C5          | 10       |      9.267 μs |     1.64 KB |
| Theia_C5_Optional | 10       |      7.575 μs |     1.39 KB |
| Arch_C5           | 10       |     27.186 μs |    26.63 KB |
| Friflo_C5         | 10       |     13.847 μs |     4.13 KB |
| Theia_C5          | 25       |     16.280 μs |     3.47 KB |
| Theia_C5_Optional | 25       |     14.529 μs |     3.59 KB |
| Arch_C5           | 25       |     43.547 μs |     28.2 KB |
| Friflo_C5         | 25       |     22.988 μs |     8.45 KB |
| Theia_C5          | 50       |     27.881 μs |     6.84 KB |
| Theia_C5_Optional | 50       |     24.307 μs |     6.59 KB |
| Arch_C5           | 50       |     75.438 μs |    30.43 KB |
| Friflo_C5         | 50       |     37.840 μs |    17.29 KB |
| Theia_C5          | 100      |     51.956 μs |    12.28 KB |
| Theia_C5_Optional | 100      |     44.163 μs |    12.03 KB |
| Arch_C5           | 100      |    147.480 μs |    34.88 KB |
| Friflo_C5         | 100      |     67.060 μs |    35.23 KB |
| Theia_C5          | 200      |    115.606 μs |    23.16 KB |
| Theia_C5_Optional | 200      |     93.688 μs |    22.91 KB |
| Arch_C5           | 200      |    327.344 μs |    43.77 KB |
| Friflo_C5         | 200      |    141.119 μs |    71.75 KB |
| Theia_C5          | 400      |    179.207 μs |    44.91 KB |
| Theia_C5_Optional | 400      |    180.381 μs |    44.66 KB |
| Arch_C5           | 400      |    480.353 μs |    61.51 KB |
| Friflo_C5         | 400      |    196.177 μs |    127.8 KB |
| Theia_C5          | 800      |    345.829 μs |    88.73 KB |
| Theia_C5_Optional | 800      |    375.406 μs |    88.48 KB |
| Arch_C5           | 800      |    959.308 μs |    129.3 KB |
| Friflo_C5         | 800      |    478.307 μs |   278.01 KB |
| Theia_C5          | 1600     |    665.663 μs |   191.92 KB |
| Theia_C5_Optional | 1600     |    551.953 μs |   272.38 KB |
| Arch_C5           | 1600     |  2,496.260 μs |    232.2 KB |
| Friflo_C5         | 1600     |    798.631 μs |   580.22 KB |
| Theia_C5          | 3200     |  1,081.360 μs |   406.98 KB |
| Theia_C5_Optional | 3200     |  1,069.162 μs |   574.77 KB |
| Arch_C5           | 3200     |  3,266.031 μs |      439 KB |
| Friflo_C5         | 3200     |  1,097.356 μs |  1188.17 KB |
| Theia_C5          | 6400     |  2,426.869 μs |   819.45 KB |
| Theia_C5_Optional | 6400     |  2,083.100 μs |   1163.2 KB |
| Arch_C5           | 6400     |  6,667.044 μs |   860.05 KB |
| Friflo_C5         | 6400     |  1,571.694 μs |  2408.54 KB |
| Theia_C5          | 16000    |  4,252.319 μs |  2010.75 KB |
| Theia_C5_Optional | 16000    |  3,162.725 μs |  2706.55 KB |
| Arch_C5           | 16000    | 10,341.200 μs |   2062.7 KB |
| Friflo_C5         | 16000    |  1,216.737 μs |  4862.92 KB |
| Theia_C5          | 32000    |  3,154.153 μs |   4027.3 KB |
| Theia_C5_Optional | 32000    |  2,761.880 μs |  5427.09 KB |
| Arch_C5           | 32000    | 10,088.333 μs |  4144.56 KB |
| Friflo_C5         | 32000    |  2,337.736 μs |  9797.11 KB |
| Theia_C5          | 64000    |  5,963.219 μs |  8044.06 KB |
| Theia_C5_Optional | 64000    |  5,469.644 μs | 10851.58 KB |
| Arch_C5           | 64000    | 20,028.031 μs |  8406.29 KB |
| Friflo_C5         | 64000    |  4,616.583 μs | 19718.91 KB |
| Theia_C5          | 100000   |  9,313.457 μs | 12896.62 KB |
| Theia_C5_Optional | 100000   |  8,581.240 μs | 18519.43 KB |
| Arch_C5           | 100000   | 31,361.380 μs | 14049.27 KB |
| Friflo_C5         | 100000   |  8,740.206 μs | 39670.54 KB |
