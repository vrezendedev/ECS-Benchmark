```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5555/22H2/2022Update)
AMD Ryzen 5 5600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  Job-XJEJRV : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=16  UnrollFactor=1  

```
| Method     | Entities | Mean          | Allocated  |
|----------- |--------- |--------------:|-----------:|
| Theia_C1   | 1        |     0.6000 μs |    0.39 KB |
| Arch_C1    | 1        |     1.3375 μs |    0.39 KB |
| Fennecs_C1 | 1        |     2.3467 μs |    0.41 KB |
| Friflo_C1  | 1        |     1.2786 μs |    0.43 KB |
| Theia_C1   | 5        |     1.5267 μs |    0.11 KB |
| Arch_C1    | 5        |     2.2786 μs |    0.39 KB |
| Fennecs_C1 | 5        |     4.0143 μs |    0.51 KB |
| Friflo_C1  | 5        |     2.0312 μs |    0.48 KB |
| Theia_C1   | 10       |     2.0846 μs |    0.11 KB |
| Arch_C1    | 10       |     3.3250 μs |    0.39 KB |
| Fennecs_C1 | 10       |     6.0125 μs |    0.63 KB |
| Friflo_C1  | 10       |     2.6500 μs |    0.57 KB |
| Theia_C1   | 25       |     4.7750 μs |    0.87 KB |
| Arch_C1    | 25       |     6.2600 μs |    0.39 KB |
| Fennecs_C1 | 25       |     9.6286 μs |    0.98 KB |
| Friflo_C1  | 25       |     4.1333 μs |    0.72 KB |
| Theia_C1   | 50       |     7.2333 μs |    0.99 KB |
| Arch_C1    | 50       |    10.8867 μs |    0.39 KB |
| Fennecs_C1 | 50       |    16.6786 μs |    1.56 KB |
| Friflo_C1  | 50       |     6.3688 μs |    0.99 KB |
| Theia_C1   | 100      |    12.3313 μs |    1.24 KB |
| Arch_C1    | 100      |    21.4800 μs |    0.39 KB |
| Fennecs_C1 | 100      |    30.5800 μs |    2.73 KB |
| Friflo_C1  | 100      |    10.9200 μs |    1.52 KB |
| Theia_C1   | 200      |    20.3467 μs |    1.74 KB |
| Arch_C1    | 200      |    41.7313 μs |    0.39 KB |
| Fennecs_C1 | 200      |    55.7500 μs |    5.08 KB |
| Friflo_C1  | 200      |    20.5188 μs |    2.54 KB |
| Theia_C1   | 400      |    41.3813 μs |    2.74 KB |
| Arch_C1    | 400      |    76.9231 μs |    4.74 KB |
| Fennecs_C1 | 400      |   120.2188 μs |    9.77 KB |
| Friflo_C1  | 400      |    41.1385 μs |    4.28 KB |
| Theia_C1   | 800      |    83.4688 μs |    4.74 KB |
| Arch_C1    | 800      |   162.5333 μs |    8.74 KB |
| Fennecs_C1 | 800      |   231.9400 μs |   19.14 KB |
| Friflo_C1  | 800      |    82.0875 μs |    8.59 KB |
| Theia_C1   | 1600     |   161.6400 μs |    9.07 KB |
| Arch_C1    | 1600     |   257.0437 μs |   17.07 KB |
| Fennecs_C1 | 1600     |   497.3800 μs |   38.22 KB |
| Friflo_C1  | 1600     |   187.3400 μs |   16.94 KB |
| Theia_C1   | 3200     |   190.9267 μs |   33.75 KB |
| Arch_C1    | 3200     |   260.3750 μs |   33.73 KB |
| Fennecs_C1 | 3200     |   907.3667 μs |   76.38 KB |
| Friflo_C1  | 3200     |   294.0929 μs |   33.62 KB |
| Theia_C1   | 6400     |   309.6067 μs |   65.75 KB |
| Arch_C1    | 6400     |   349.4643 μs |   65.73 KB |
| Fennecs_C1 | 6400     |   190.3385 μs |  151.38 KB |
| Friflo_C1  | 6400     |   560.6429 μs |   65.64 KB |
| Theia_C1   | 16000    |   568.9625 μs |  129.75 KB |
| Arch_C1    | 16000    |   608.7929 μs |  129.73 KB |
| Fennecs_C1 | 16000    |   481.0143 μs |   504.4 KB |
| Friflo_C1  | 16000    | 1,291.0429 μs |  129.66 KB |
| Theia_C1   | 32000    |   899.1562 μs |  257.47 KB |
| Arch_C1    | 32000    | 1,061.8250 μs |  257.45 KB |
| Fennecs_C1 | 32000    | 1,031.9000 μs | 1135.14 KB |
| Friflo_C1  | 32000    |   517.8400 μs |  257.41 KB |
| Theia_C1   | 64000    | 1,216.8750 μs |  513.75 KB |
| Arch_C1    | 64000    | 1,773.0000 μs |  513.77 KB |
| Fennecs_C1 | 64000    | 2,044.9200 μs | 2397.49 KB |
| Friflo_C1  | 64000    | 1,058.7467 μs |  513.71 KB |
| Theia_C1   | 100000   | 2,529.1125 μs | 1025.47 KB |
| Arch_C1    | 100000   | 3,002.2312 μs | 1025.07 KB |
| Fennecs_C1 | 100000   | 3,241.1867 μs | 4264.28 KB |
| Friflo_C1  | 100000   | 4,428.7563 μs | 1025.08 KB |
