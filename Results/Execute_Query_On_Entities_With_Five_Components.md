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
| Theia_C5   | 1        |   1.493 μs |   0.39 KB |
| Arch_C5    | 1        |   3.683 μs |   0.45 KB |
| Fennecs_C5 | 1        |  12.133 μs |   1.02 KB |
| Friflo_C5  | 1        |   2.985 μs |   0.45 KB |
| Theia_C5   | 5        |   1.587 μs |   0.39 KB |
| Arch_C5    | 5        |   3.780 μs |   0.73 KB |
| Fennecs_C5 | 5        |  12.079 μs |   1.02 KB |
| Friflo_C5  | 5        |   3.240 μs |   0.45 KB |
| Theia_C5   | 10       |   1.744 μs |   0.39 KB |
| Arch_C5    | 10       |   3.969 μs |   0.73 KB |
| Fennecs_C5 | 10       |  12.367 μs |   1.02 KB |
| Friflo_C5  | 10       |   3.483 μs |   0.45 KB |
| Theia_C5   | 25       |   2.027 μs |   0.39 KB |
| Arch_C5    | 25       |   4.357 μs |   0.73 KB |
| Fennecs_C5 | 25       |  12.786 μs |   1.02 KB |
| Friflo_C5  | 25       |   4.008 μs |   0.45 KB |
| Theia_C5   | 50       |   2.619 μs |   0.39 KB |
| Arch_C5    | 50       |   5.047 μs |   0.73 KB |
| Fennecs_C5 | 50       |  13.513 μs |   1.02 KB |
| Friflo_C5  | 50       |   4.567 μs |   0.45 KB |
| Theia_C5   | 100      |   3.675 μs |   0.39 KB |
| Arch_C5    | 100      |   6.243 μs |   0.73 KB |
| Fennecs_C5 | 100      |  14.713 μs |   1.02 KB |
| Friflo_C5  | 100      |   5.747 μs |   0.45 KB |
| Theia_C5   | 200      |   6.881 μs |   0.39 KB |
| Arch_C5    | 200      |  10.006 μs |   0.73 KB |
| Fennecs_C5 | 200      |  18.950 μs |   1.02 KB |
| Friflo_C5  | 200      |   9.719 μs |   0.45 KB |
| Theia_C5   | 400      |  12.631 μs |   0.39 KB |
| Arch_C5    | 400      |  14.719 μs |   0.73 KB |
| Fennecs_C5 | 400      |  22.706 μs |   1.02 KB |
| Friflo_C5  | 400      |  14.387 μs |   0.45 KB |
| Theia_C5   | 800      |  22.964 μs |   0.72 KB |
| Arch_C5    | 800      |  26.700 μs |   1.06 KB |
| Fennecs_C5 | 800      |  31.406 μs |   1.34 KB |
| Friflo_C5  | 800      |  27.581 μs |   0.77 KB |
| Theia_C5   | 1600     |  29.373 μs |   0.72 KB |
| Arch_C5    | 1600     |  35.277 μs |   1.06 KB |
| Fennecs_C5 | 1600     |  46.300 μs |   1.34 KB |
| Friflo_C5  | 1600     |  36.050 μs |   0.77 KB |
| Theia_C5   | 3200     |  32.767 μs |   1.38 KB |
| Arch_C5    | 3200     |  40.471 μs |   1.72 KB |
| Fennecs_C5 | 3200     |  82.200 μs |      2 KB |
| Friflo_C5  | 3200     |  41.787 μs |   1.43 KB |
| Theia_C5   | 6400     |  35.273 μs |   1.09 KB |
| Arch_C5    | 6400     |  43.206 μs |   1.44 KB |
| Fennecs_C5 | 6400     | 146.536 μs |   1.72 KB |
| Friflo_C5  | 6400     |  47.013 μs |   1.15 KB |
| Theia_C5   | 16000    |  54.173 μs |   1.38 KB |
| Arch_C5    | 16000    |  55.875 μs |   1.72 KB |
| Fennecs_C5 | 16000    | 174.486 μs |   1.39 KB |
| Friflo_C5  | 16000    |  74.347 μs |   1.48 KB |
| Theia_C5   | 32000    |  78.180 μs |   1.42 KB |
| Arch_C5    | 32000    |  85.200 μs |   1.77 KB |
| Fennecs_C5 | 32000    | 189.753 μs |   2.05 KB |
| Friflo_C5  | 32000    | 106.014 μs |   1.48 KB |
| Theia_C5   | 64000    | 141.543 μs |   1.42 KB |
| Arch_C5    | 64000    | 145.167 μs |   1.77 KB |
| Fennecs_C5 | 64000    | 247.225 μs |   2.05 KB |
| Friflo_C5  | 64000    | 184.587 μs |   1.48 KB |
| Theia_C5   | 100000   | 205.479 μs |   0.44 KB |
| Arch_C5    | 100000   | 198.313 μs |   1.06 KB |
| Fennecs_C5 | 100000   | 302.181 μs |   2.33 KB |
| Friflo_C5  | 100000   | 269.675 μs |   1.15 KB |
