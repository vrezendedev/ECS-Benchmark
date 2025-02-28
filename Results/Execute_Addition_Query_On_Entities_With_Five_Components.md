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
| Theia_C5          | 1        |      5.350 μs |     0.84 KB |
| Theia_C5_Optional | 1        |      3.347 μs |     0.55 KB |
| Arch_C5           | 1        |     16.507 μs |    26.44 KB |
| Friflo_C5         | 1        |      9.531 μs |    16.74 KB |
| Theia_C5          | 5        |      7.969 μs |     0.93 KB |
| Theia_C5_Optional | 5        |      5.733 μs |     0.92 KB |
| Arch_C5           | 5        |     21.440 μs |    26.29 KB |
| Friflo_C5         | 5        |     12.947 μs |    16.93 KB |
| Theia_C5          | 10       |     10.421 μs |      1.4 KB |
| Theia_C5_Optional | 10       |      7.919 μs |     1.39 KB |
| Arch_C5           | 10       |     27.606 μs |    26.95 KB |
| Friflo_C5         | 10       |     16.519 μs |    19.11 KB |
| Theia_C5          | 25       |     18.675 μs |     4.16 KB |
| Theia_C5_Optional | 25       |     15.062 μs |     3.88 KB |
| Arch_C5           | 25       |     43.307 μs |     27.4 KB |
| Friflo_C5         | 25       |     26.313 μs |    23.43 KB |
| Theia_C5          | 50       |     33.638 μs |     6.88 KB |
| Theia_C5_Optional | 50       |     25.080 μs |     6.59 KB |
| Arch_C5           | 50       |     68.847 μs |    29.03 KB |
| Friflo_C5         | 50       |     43.047 μs |    32.27 KB |
| Theia_C5          | 100      |     63.756 μs |    12.32 KB |
| Theia_C5_Optional | 100      |     47.131 μs |    12.03 KB |
| Arch_C5           | 100      |    122.215 μs |    31.67 KB |
| Friflo_C5         | 100      |     76.456 μs |    50.21 KB |
| Theia_C5          | 200      |    129.812 μs |     23.2 KB |
| Theia_C5_Optional | 200      |    104.050 μs |    22.91 KB |
| Arch_C5           | 200      |    253.273 μs |    36.88 KB |
| Friflo_C5         | 200      |    159.900 μs |    86.73 KB |
| Theia_C5          | 400      |    214.500 μs |    44.95 KB |
| Theia_C5_Optional | 400      |    171.920 μs |    44.66 KB |
| Arch_C5           | 400      |    383.207 μs |    47.23 KB |
| Friflo_C5         | 400      |    260.814 μs |   142.77 KB |
| Theia_C5          | 800      |    419.086 μs |   105.03 KB |
| Theia_C5_Optional | 800      |    402.762 μs |   104.74 KB |
| Arch_C5           | 800      |    818.014 μs |   100.27 KB |
| Friflo_C5         | 800      |    542.208 μs |   301.31 KB |
| Theia_C5          | 1600     |    761.771 μs |   208.29 KB |
| Theia_C5_Optional | 1600     |    571.943 μs |    288.7 KB |
| Arch_C5           | 1600     |  1,898.129 μs |   189.55 KB |
| Friflo_C5         | 1600     |    448.157 μs |   619.29 KB |
| Theia_C5          | 3200     |  1,360.113 μs |   439.74 KB |
| Theia_C5_Optional | 3200     |  1,140.537 μs |    607.5 KB |
| Arch_C5           | 3200     |  2,552.200 μs |   353.16 KB |
| Friflo_C5         | 3200     |  1,188.231 μs |  1259.29 KB |
| Theia_C5          | 6400     |  3,091.157 μs |   868.75 KB |
| Theia_C5_Optional | 6400     |  2,235.287 μs |  1212.51 KB |
| Arch_C5           | 6400     |  6,323.156 μs |   672.17 KB |
| Friflo_C5         | 6400     |  1,051.169 μs |   2543.7 KB |
| Theia_C5          | 16000    |  3,181.650 μs |  2141.86 KB |
| Theia_C5_Optional | 16000    |  1,396.042 μs |  2837.29 KB |
| Arch_C5           | 16000    |  4,678.163 μs |  1737.59 KB |
| Friflo_C5         | 16000    |  1,499.836 μs |  5126.41 KB |
| Theia_C5          | 32000    |  3,177.708 μs |  4273.95 KB |
| Theia_C5_Optional | 32000    |  2,812.538 μs |   5673.7 KB |
| Arch_C5           | 32000    |  9,293.956 μs |     3546 KB |
| Friflo_C5         | 32000    |  2,665.808 μs | 10316.74 KB |
| Theia_C5          | 64000    |  6,147.027 μs |  8553.91 KB |
| Theia_C5_Optional | 64000    |  5,552.906 μs | 11361.38 KB |
| Arch_C5           | 64000    | 18,678.207 μs |  7265.73 KB |
| Friflo_C5         | 64000    |  5,762.769 μs | 20750.22 KB |
| Theia_C5          | 100000   |  9,759.519 μs | 13691.63 KB |
| Theia_C5_Optional | 100000   |  8,895.106 μs | 19314.13 KB |
| Arch_C5           | 100000   | 29,698.193 μs | 11348.69 KB |
| Friflo_C5         | 100000   | 10,589.400 μs | 41725.56 KB |
