```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5555/22H2/2022Update)
AMD Ryzen 5 5600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  Job-XJEJRV : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=16  UnrollFactor=1  

```
| Method     | Entities | Mean       | Allocated |
|----------- |--------- |-----------:|----------:|
| Theia_C4   | 1        |   1.286 μs |   0.39 KB |
| Arch_C4    | 1        |   3.580 μs |   0.73 KB |
| Fennecs_C4 | 1        |  10.367 μs |    0.9 KB |
| Friflo_C4  | 1        |   3.013 μs |   0.45 KB |
| Theia_C4   | 5        |   1.425 μs |   0.39 KB |
| Arch_C4    | 5        |   3.673 μs |   0.73 KB |
| Fennecs_C4 | 5        |  10.713 μs |    0.9 KB |
| Friflo_C4  | 5        |   3.125 μs |   0.45 KB |
| Theia_C4   | 10       |   1.569 μs |   0.39 KB |
| Arch_C4    | 10       |   3.821 μs |   0.73 KB |
| Fennecs_C4 | 10       |  10.792 μs |    0.9 KB |
| Friflo_C4  | 10       |   3.279 μs |   0.45 KB |
| Theia_C4   | 25       |   1.837 μs |   0.39 KB |
| Arch_C4    | 25       |   4.236 μs |   0.73 KB |
| Fennecs_C4 | 25       |  11.146 μs |    0.9 KB |
| Friflo_C4  | 25       |   3.721 μs |   0.45 KB |
| Theia_C4   | 50       |   2.413 μs |   0.39 KB |
| Arch_C4    | 50       |   4.825 μs |   0.73 KB |
| Fennecs_C4 | 50       |  11.812 μs |    0.9 KB |
| Friflo_C4  | 50       |   4.312 μs |   0.45 KB |
| Theia_C4   | 100      |   3.344 μs |   0.39 KB |
| Arch_C4    | 100      |   6.000 μs |   0.73 KB |
| Fennecs_C4 | 100      |  12.629 μs |    0.9 KB |
| Friflo_C4  | 100      |   5.444 μs |   0.45 KB |
| Theia_C4   | 200      |   5.175 μs |   0.39 KB |
| Arch_C4    | 200      |   8.088 μs |   0.73 KB |
| Fennecs_C4 | 200      |  14.486 μs |   0.62 KB |
| Friflo_C4  | 200      |   7.736 μs |   0.45 KB |
| Theia_C4   | 400      |   9.573 μs |   0.39 KB |
| Arch_C4    | 400      |  12.787 μs |   0.73 KB |
| Fennecs_C4 | 400      |  18.164 μs |    0.9 KB |
| Friflo_C4  | 400      |  13.100 μs |   0.45 KB |
| Theia_C4   | 800      |  20.100 μs |   0.72 KB |
| Arch_C4    | 800      |  24.129 μs |   1.06 KB |
| Fennecs_C4 | 800      |  26.193 μs |   1.23 KB |
| Friflo_C4  | 800      |  24.892 μs |   0.77 KB |
| Theia_C4   | 1600     |  26.793 μs |   0.72 KB |
| Arch_C4    | 1600     |  34.013 μs |   1.06 KB |
| Fennecs_C4 | 1600     |  42.087 μs |   0.95 KB |
| Friflo_C4  | 1600     |  34.600 μs |   0.49 KB |
| Theia_C4   | 3200     |  29.553 μs |   1.38 KB |
| Arch_C4    | 3200     |  35.487 μs |   1.44 KB |
| Fennecs_C4 | 3200     |  72.073 μs |   1.88 KB |
| Friflo_C4  | 3200     |  37.756 μs |   1.43 KB |
| Theia_C4   | 6400     |  35.721 μs |   1.09 KB |
| Arch_C4    | 6400     |  40.940 μs |   1.44 KB |
| Fennecs_C4 | 6400     | 129.113 μs |    1.6 KB |
| Friflo_C4  | 6400     |  46.207 μs |   1.15 KB |
| Theia_C4   | 16000    |  47.875 μs |   1.42 KB |
| Arch_C4    | 16000    |  54.436 μs |   1.77 KB |
| Fennecs_C4 | 16000    | 175.053 μs |   1.93 KB |
| Friflo_C4  | 16000    |  66.807 μs |   1.43 KB |
| Theia_C4   | 32000    |  72.181 μs |   1.38 KB |
| Arch_C4    | 32000    |  75.994 μs |   1.77 KB |
| Fennecs_C4 | 32000    | 167.977 μs |   1.93 KB |
| Friflo_C4  | 32000    |  91.847 μs |   1.48 KB |
| Theia_C4   | 64000    | 116.736 μs |   1.38 KB |
| Arch_C4    | 64000    | 120.080 μs |   1.72 KB |
| Fennecs_C4 | 64000    | 203.307 μs |   1.93 KB |
| Friflo_C4  | 64000    | 153.463 μs |   1.43 KB |
| Theia_C4   | 100000   | 170.673 μs |   1.38 KB |
| Arch_C4    | 100000   | 161.708 μs |   1.44 KB |
| Fennecs_C4 | 100000   | 245.106 μs |   1.55 KB |
| Friflo_C4  | 100000   | 219.421 μs |   0.82 KB |
