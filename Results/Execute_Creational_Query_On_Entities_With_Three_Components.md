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
| Theia_C3  | 1        |      2.800 μs |     0.55 KB |
| Arch_C3   | 1        |      6.515 μs |     0.87 KB |
| Friflo_C3 | 1        |      9.147 μs |     2.21 KB |
| Theia_C3  | 5        |      4.006 μs |     0.96 KB |
| Arch_C3   | 5        |      9.379 μs |     0.98 KB |
| Friflo_C3 | 5        |     12.980 μs |     2.48 KB |
| Theia_C3  | 10       |      5.180 μs |     1.47 KB |
| Arch_C3   | 10       |     12.453 μs |      1.2 KB |
| Friflo_C3 | 10       |     16.900 μs |     5.36 KB |
| Theia_C3  | 25       |      9.206 μs |     3.59 KB |
| Arch_C3   | 25       |     21.029 μs |     1.59 KB |
| Friflo_C3 | 25       |     27.606 μs |       11 KB |
| Theia_C3  | 50       |     14.287 μs |     6.38 KB |
| Arch_C3   | 50       |     33.953 μs |     2.37 KB |
| Friflo_C3 | 50       |     45.425 μs |    22.41 KB |
| Theia_C3  | 100      |     27.229 μs |    11.96 KB |
| Arch_C3   | 100      |     61.200 μs |     3.89 KB |
| Friflo_C3 | 100      |     78.029 μs |    51.45 KB |
| Theia_C3  | 200      |     45.271 μs |    23.12 KB |
| Arch_C3   | 200      |    112.313 μs |     6.91 KB |
| Friflo_C3 | 200      |    152.025 μs |   104.03 KB |
| Theia_C3  | 400      |     94.812 μs |    45.43 KB |
| Arch_C3   | 400      |    217.313 μs |    12.94 KB |
| Friflo_C3 | 400      |    317.656 μs |   208.24 KB |
| Theia_C3  | 800      |    188.993 μs |    106.2 KB |
| Arch_C3   | 800      |    394.386 μs |    57.71 KB |
| Friflo_C3 | 800      |    579.138 μs |   422.38 KB |
| Theia_C3  | 1600     |    293.977 μs |   292.62 KB |
| Arch_C3   | 1600     |    750.600 μs |   113.23 KB |
| Friflo_C3 | 1600     |    892.647 μs |   852.62 KB |
| Theia_C3  | 3200     |    589.581 μs |   567.26 KB |
| Arch_C3   | 3200     |  1,100.933 μs |   226.15 KB |
| Friflo_C3 | 3200     |  1,558.000 μs |  1716.55 KB |
| Theia_C3  | 6400     |    877.377 μs |  1132.68 KB |
| Arch_C3   | 6400     |  2,219.000 μs |   451.57 KB |
| Friflo_C3 | 6400     |  2,491.431 μs |  3449.17 KB |
| Theia_C3  | 16000    |    667.231 μs |  2653.86 KB |
| Arch_C3   | 16000    |  3,370.700 μs |  1033.23 KB |
| Friflo_C3 | 16000    |  1,907.112 μs |   6927.2 KB |
| Theia_C3  | 32000    |  1,261.220 μs |  5289.44 KB |
| Arch_C3   | 32000    |  6,247.938 μs |  2105.14 KB |
| Friflo_C3 | 32000    |  7,743.819 μs | 13908.43 KB |
| Theia_C3  | 64000    |  2,457.813 μs | 10593.11 KB |
| Arch_C3   | 64000    |  6,102.203 μs |  4320.23 KB |
| Friflo_C3 | 64000    |  6,976.471 μs | 27927.24 KB |
| Theia_C3  | 100000   |  3,955.931 μs | 17889.23 KB |
| Arch_C3   | 100000   |  9,607.433 μs |   7645.4 KB |
| Friflo_C3 | 100000   | 12,728.086 μs | 56069.48 KB |
