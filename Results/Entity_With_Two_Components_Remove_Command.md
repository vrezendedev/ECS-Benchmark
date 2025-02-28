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
| Theia_C2  | 1        |      3.577 μs |     0.68 KB |
| Arch_C2   | 1        |     15.269 μs |    49.65 KB |
| Friflo_C2 | 1        |      5.120 μs |     1.65 KB |
| Theia_C2  | 5        |      5.338 μs |     1.05 KB |
| Arch_C2   | 5        |     18.980 μs |    49.91 KB |
| Friflo_C2 | 5        |      7.593 μs |     1.84 KB |
| Theia_C2  | 10       |      6.587 μs |     1.52 KB |
| Arch_C2   | 10       |     23.000 μs |    50.29 KB |
| Friflo_C2 | 10       |      9.857 μs |     4.02 KB |
| Theia_C2  | 25       |     11.640 μs |     4.01 KB |
| Arch_C2   | 25       |     35.429 μs |    51.22 KB |
| Friflo_C2 | 25       |     16.033 μs |     8.05 KB |
| Theia_C2  | 50       |     17.553 μs |     6.73 KB |
| Arch_C2   | 50       |     57.869 μs |    52.87 KB |
| Friflo_C2 | 50       |     26.246 μs |    17.17 KB |
| Theia_C2  | 100      |     30.243 μs |    12.16 KB |
| Arch_C2   | 100      |     89.864 μs |    56.15 KB |
| Friflo_C2 | 100      |     45.636 μs |    35.12 KB |
| Theia_C2  | 200      |     53.980 μs |    23.04 KB |
| Arch_C2   | 200      |    168.160 μs |    62.69 KB |
| Friflo_C2 | 200      |     86.943 μs |    71.63 KB |
| Theia_C2  | 400      |    108.371 μs |    44.79 KB |
| Arch_C2   | 400      |    314.579 μs |    75.74 KB |
| Friflo_C2 | 400      |    169.619 μs |   127.68 KB |
| Theia_C2  | 800      |    261.119 μs |    88.29 KB |
| Arch_C2   | 800      |    645.260 μs |   101.83 KB |
| Friflo_C2 | 800      |    391.312 μs |   265.77 KB |
| Theia_C2  | 1600     |    361.257 μs |   175.62 KB |
| Arch_C2   | 1600     |  1,114.900 μs |   202.38 KB |
| Friflo_C2 | 1600     |    494.244 μs |   543.96 KB |
| Theia_C2  | 3200     |    705.419 μs |   374.09 KB |
| Arch_C2   | 3200     |  2,348.787 μs |   339.21 KB |
| Friflo_C2 | 3200     |    960.225 μs |  1103.84 KB |
| Theia_C2  | 6400     |  1,162.463 μs |   754.53 KB |
| Arch_C2   | 6400     |  3,355.229 μs |   628.88 KB |
| Friflo_C2 | 6400     |  1,085.325 μs |  2228.42 KB |
| Theia_C2  | 16000    |  3,308.756 μs |  1814.56 KB |
| Arch_C2   | 16000    |  9,226.069 μs |   1510.7 KB |
| Friflo_C2 | 16000    |  1,971.717 μs |  4490.41 KB |
| Theia_C2  | 32000    |  3,578.431 μs |  3635.14 KB |
| Arch_C2   | 32000    |  6,791.343 μs |  2983.77 KB |
| Friflo_C2 | 32000    |  2,492.181 μs |  9040.95 KB |
| Theia_C2  | 64000    |  3,600.967 μs |  7276.11 KB |
| Arch_C2   | 64000    | 13,651.800 μs |  6006.64 KB |
| Friflo_C2 | 64000    |  4,468.725 μs | 18194.02 KB |
| Theia_C2  | 100000   |  5,776.220 μs | 11691.78 KB |
| Arch_C2   | 100000   | 21,328.394 μs | 10188.99 KB |
| Friflo_C2 | 100000   |  7,926.062 μs | 36608.92 KB |
