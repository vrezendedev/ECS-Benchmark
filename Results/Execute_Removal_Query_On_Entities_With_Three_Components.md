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
| Theia_C3          | 1        |      4.486 μs |     0.77 KB |
| Theia_C3_Optional | 1        |      2.900 μs |     0.55 KB |
| Arch_C3           | 1        |     15.829 μs |       34 KB |
| Friflo_C3         | 1        |      7.087 μs |     1.77 KB |
| Theia_C3          | 5        |      6.450 μs |     1.14 KB |
| Theia_C3_Optional | 5        |      5.050 μs |     0.92 KB |
| Arch_C3           | 5        |     20.533 μs |    34.29 KB |
| Friflo_C3         | 5        |      9.847 μs |     1.95 KB |
| Theia_C3          | 10       |      7.919 μs |     1.61 KB |
| Theia_C3_Optional | 10       |      6.760 μs |     1.39 KB |
| Arch_C3           | 10       |     25.733 μs |    34.71 KB |
| Friflo_C3         | 10       |     12.620 μs |      3.8 KB |
| Theia_C3          | 25       |     13.507 μs |     4.09 KB |
| Theia_C3_Optional | 25       |     13.093 μs |     3.88 KB |
| Arch_C3           | 25       |     38.986 μs |    35.76 KB |
| Friflo_C3         | 25       |     20.250 μs |     8.17 KB |
| Theia_C3          | 50       |     20.831 μs |     6.81 KB |
| Theia_C3_Optional | 50       |     21.806 μs |     6.59 KB |
| Arch_C3           | 50       |     60.331 μs |     37.6 KB |
| Friflo_C3         | 50       |     32.507 μs |    17.29 KB |
| Theia_C3          | 100      |     36.220 μs |    12.25 KB |
| Theia_C3_Optional | 100      |     36.119 μs |    12.03 KB |
| Arch_C3           | 100      |    113.400 μs |    41.27 KB |
| Friflo_C3         | 100      |     55.256 μs |    35.23 KB |
| Theia_C3          | 200      |     70.481 μs |    23.13 KB |
| Theia_C3_Optional | 200      |     69.044 μs |    22.91 KB |
| Arch_C3           | 200      |    227.173 μs |    48.31 KB |
| Friflo_C3         | 200      |    102.840 μs |    71.75 KB |
| Theia_C3          | 400      |    163.556 μs |    44.88 KB |
| Theia_C3_Optional | 400      |    162.887 μs |    44.66 KB |
| Arch_C3           | 400      |    440.807 μs |    63.21 KB |
| Friflo_C3         | 400      |    222.412 μs |    127.8 KB |
| Theia_C3          | 800      |    271.207 μs |    88.38 KB |
| Theia_C3_Optional | 800      |    306.387 μs |    88.16 KB |
| Arch_C3           | 800      |    716.840 μs |    92.42 KB |
| Friflo_C3         | 800      |    426.869 μs |   269.91 KB |
| Theia_C3          | 1600     |    555.653 μs |   191.82 KB |
| Theia_C3_Optional | 1600     |    359.092 μs |    272.3 KB |
| Arch_C3           | 1600     |  1,601.338 μs |   191.19 KB |
| Friflo_C3         | 1600     |    655.344 μs |   556.13 KB |
| Theia_C3          | 3200     |    800.860 μs |   390.62 KB |
| Theia_C3_Optional | 3200     |    672.053 μs |   558.45 KB |
| Arch_C3           | 3200     |  1,627.287 μs |   380.88 KB |
| Friflo_C3         | 3200     |  1,066.969 μs |  1132.03 KB |
| Theia_C3          | 6400     |  1,436.800 μs |   770.85 KB |
| Theia_C3_Optional | 6400     |    837.106 μs |  1114.68 KB |
| Arch_C3           | 6400     |  1,832.300 μs |   719.59 KB |
| Friflo_C3         | 6400     |  1,408.656 μs |  2288.63 KB |
| Theia_C3          | 16000    |  1,109.244 μs |  1879.06 KB |
| Theia_C3_Optional | 16000    |  1,930.812 μs |  2575.17 KB |
| Arch_C3           | 16000    |  3,888.244 μs |  1652.49 KB |
| Friflo_C3         | 16000    |  1,458.513 μs |  4614.69 KB |
| Theia_C3          | 32000    |  2,277.588 μs |  3765.57 KB |
| Theia_C3_Optional | 32000    |  2,497.069 μs |  5165.02 KB |
| Arch_C3           | 32000    |  7,795.854 μs |  3337.73 KB |
| Friflo_C3         | 32000    |  3,007.721 μs |  9292.88 KB |
| Theia_C3          | 64000    |  4,395.587 μs |   7521.3 KB |
| Theia_C3_Optional | 64000    |  4,211.771 μs | 10329.13 KB |
| Arch_C3           | 64000    | 15,795.025 μs |  6760.63 KB |
| Friflo_C3         | 64000    |  4,176.200 μs | 18702.59 KB |
| Theia_C3          | 100000   |  6,775.514 μs |  12100.3 KB |
| Theia_C3_Optional | 100000   |  6,686.585 μs | 17724.13 KB |
| Arch_C3           | 100000   | 24,573.233 μs | 11425.82 KB |
| Friflo_C3         | 100000   |  7,698.606 μs | 37629.51 KB |
