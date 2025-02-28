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
| Theia_C3   | 1        |     0.6500 μs |    0.39 KB |
| Arch_C3    | 1        |     1.3857 μs |    0.11 KB |
| Fennecs_C3 | 1        |     2.9400 μs |    0.13 KB |
| Friflo_C3  | 1        |     1.2750 μs |    0.43 KB |
| Theia_C3   | 5        |     1.7500 μs |    0.39 KB |
| Arch_C3    | 5        |     2.4562 μs |    0.39 KB |
| Fennecs_C3 | 5        |     5.5929 μs |    0.51 KB |
| Friflo_C3  | 5        |     2.2750 μs |    0.48 KB |
| Theia_C3   | 10       |     2.4533 μs |    0.39 KB |
| Arch_C3    | 10       |     3.6333 μs |    0.39 KB |
| Fennecs_C3 | 10       |     8.3467 μs |    0.63 KB |
| Friflo_C3  | 10       |     2.9071 μs |    0.57 KB |
| Theia_C3   | 25       |     5.5800 μs |    0.87 KB |
| Arch_C3    | 25       |     7.0812 μs |    0.39 KB |
| Fennecs_C3 | 25       |    15.1667 μs |    0.98 KB |
| Friflo_C3  | 25       |     4.8063 μs |    0.44 KB |
| Theia_C3   | 50       |     9.1062 μs |    0.99 KB |
| Arch_C3    | 50       |    12.6867 μs |    0.39 KB |
| Fennecs_C3 | 50       |    27.6733 μs |    1.56 KB |
| Friflo_C3  | 50       |     7.6625 μs |    0.99 KB |
| Theia_C3   | 100      |    14.8923 μs |    1.24 KB |
| Arch_C3    | 100      |    22.7643 μs |    0.39 KB |
| Fennecs_C3 | 100      |    49.9692 μs |    2.73 KB |
| Friflo_C3  | 100      |    13.4933 μs |    1.52 KB |
| Theia_C3   | 200      |    29.8875 μs |    1.74 KB |
| Arch_C3    | 200      |    47.3563 μs |    0.39 KB |
| Fennecs_C3 | 200      |    99.5062 μs |    5.08 KB |
| Friflo_C3  | 200      |    25.6500 μs |    2.54 KB |
| Theia_C3   | 400      |    66.2500 μs |    2.74 KB |
| Arch_C3    | 400      |   107.1688 μs |    4.46 KB |
| Fennecs_C3 | 400      |   194.3923 μs |    9.77 KB |
| Friflo_C3  | 400      |    56.3813 μs |    4.56 KB |
| Theia_C3   | 800      |   113.8000 μs |    4.74 KB |
| Arch_C3    | 800      |   185.1267 μs |    8.74 KB |
| Fennecs_C3 | 800      |   378.7267 μs |   19.14 KB |
| Friflo_C3  | 800      |   106.4231 μs |    8.59 KB |
| Theia_C3   | 1600     |   193.9000 μs |    9.07 KB |
| Arch_C3    | 1600     |   263.5385 μs |   17.07 KB |
| Fennecs_C3 | 1600     |   606.9533 μs |   38.22 KB |
| Friflo_C3  | 1600     |   209.4200 μs |   16.94 KB |
| Theia_C3   | 3200     |   282.9500 μs |   33.75 KB |
| Arch_C3    | 3200     |   410.7733 μs |   33.73 KB |
| Fennecs_C3 | 3200     |   998.0375 μs |   76.38 KB |
| Friflo_C3  | 3200     |   125.0938 μs |   33.62 KB |
| Theia_C3   | 6400     |   626.6143 μs |   65.75 KB |
| Arch_C3    | 6400     |   510.2000 μs |   65.73 KB |
| Fennecs_C3 | 6400     | 1,519.6937 μs |  151.38 KB |
| Friflo_C3  | 6400     |   920.7000 μs |   65.64 KB |
| Theia_C3   | 16000    | 1,193.9500 μs |  129.47 KB |
| Arch_C3    | 16000    |   869.6875 μs |  129.45 KB |
| Fennecs_C3 | 16000    | 1,487.9938 μs |  504.12 KB |
| Friflo_C3  | 16000    |   296.5667 μs |  129.38 KB |
| Theia_C3   | 32000    |   992.0467 μs |  256.11 KB |
| Arch_C3    | 32000    | 1,165.8667 μs |  256.74 KB |
| Fennecs_C3 | 32000    | 1,394.7400 μs | 1135.14 KB |
| Friflo_C3  | 32000    |   588.3571 μs |  257.69 KB |
| Theia_C3   | 64000    | 1,951.9467 μs |   513.8 KB |
| Arch_C3    | 64000    | 2,325.8357 μs |  513.77 KB |
| Fennecs_C3 | 64000    | 2,764.7769 μs | 2397.49 KB |
| Friflo_C3  | 64000    | 1,120.8857 μs |  513.76 KB |
| Theia_C3   | 100000   | 2,990.9967 μs | 1024.81 KB |
| Arch_C3    | 100000   | 3,629.0533 μs | 1025.12 KB |
| Fennecs_C3 | 100000   | 4,387.8438 μs | 4264.94 KB |
| Friflo_C3  | 100000   | 1,839.3133 μs | 1025.73 KB |
