```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5555/22H2/2022Update)
AMD Ryzen 5 5600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  Job-XJEJRV : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=16  UnrollFactor=1  

```
| Method    | Entities | Mean         | Allocated  |
|---------- |--------- |-------------:|-----------:|
| Theia_C3  | 1        |     2.440 μs |    0.55 KB |
| Arch_C3   | 1        |     6.369 μs |    0.87 KB |
| Friflo_C3 | 1        |     5.029 μs |    0.78 KB |
| Theia_C3  | 5        |     3.879 μs |    0.92 KB |
| Arch_C3   | 5        |     9.373 μs |    0.98 KB |
| Friflo_C3 | 5        |     6.187 μs |    0.92 KB |
| Theia_C3  | 10       |     5.031 μs |    1.39 KB |
| Arch_C3   | 10       |    12.669 μs |     1.2 KB |
| Friflo_C3 | 10       |     7.320 μs |    0.88 KB |
| Theia_C3  | 25       |     9.393 μs |    3.88 KB |
| Arch_C3   | 25       |    21.256 μs |    1.31 KB |
| Friflo_C3 | 25       |     9.938 μs |     1.3 KB |
| Theia_C3  | 50       |    14.167 μs |    6.59 KB |
| Arch_C3   | 50       |    36.500 μs |    2.37 KB |
| Friflo_C3 | 50       |    14.219 μs |    2.38 KB |
| Theia_C3  | 100      |    24.812 μs |   12.03 KB |
| Arch_C3   | 100      |    64.807 μs |    3.89 KB |
| Friflo_C3 | 100      |    22.550 μs |    3.92 KB |
| Theia_C3  | 200      |    45.727 μs |   22.91 KB |
| Arch_C3   | 200      |    85.323 μs |    6.91 KB |
| Friflo_C3 | 200      |    39.288 μs |    6.97 KB |
| Theia_C3  | 400      |    98.013 μs |   44.66 KB |
| Arch_C3   | 400      |   164.894 μs |   17.29 KB |
| Friflo_C3 | 400      |    81.667 μs |   13.02 KB |
| Theia_C3  | 800      |   175.800 μs |   87.88 KB |
| Arch_C3   | 800      |   287.020 μs |   33.31 KB |
| Friflo_C3 | 800      |   155.473 μs |   25.06 KB |
| Theia_C3  | 1600     |   297.133 μs |  175.48 KB |
| Arch_C3   | 1600     |   494.753 μs |   65.66 KB |
| Friflo_C3 | 1600     |   275.093 μs |   49.44 KB |
| Theia_C3  | 3200     |   406.329 μs |  366.16 KB |
| Arch_C3   | 3200     |   901.500 μs |  130.34 KB |
| Friflo_C3 | 3200     |   443.913 μs |   98.14 KB |
| Theia_C3  | 6400     |   808.467 μs |  729.88 KB |
| Arch_C3   | 6400     | 1,996.112 μs |  258.37 KB |
| Friflo_C3 | 6400     | 1,007.900 μs |  194.19 KB |
| Theia_C3  | 16000    |   781.913 μs | 1757.84 KB |
| Arch_C3   | 16000    | 3,119.094 μs |  514.11 KB |
| Friflo_C3 | 16000    | 1,943.963 μs |  385.95 KB |
| Theia_C3  | 32000    | 1,542.883 μs | 3513.55 KB |
| Arch_C3   | 32000    | 2,967.825 μs | 1025.43 KB |
| Friflo_C3 | 32000    |   887.871 μs |  770.28 KB |
| Theia_C3  | 64000    | 3,097.012 μs | 7026.16 KB |
| Arch_C3   | 64000    | 6,064.593 μs | 2050.48 KB |
| Friflo_C3 | 64000    | 1,713.657 μs | 1538.38 KB |
| Theia_C3  | 100000   | 4,923.527 μs | 11423.9 KB |
| Arch_C3   | 100000   | 9,189.473 μs | 4098.46 KB |
| Friflo_C3 | 100000   | 2,711.664 μs | 3074.09 KB |
