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
| Theia_C4   | 1        |     0.6333 μs |    0.39 KB |
| Arch_C4    | 1        |     1.3733 μs |    0.39 KB |
| Fennecs_C4 | 1        |     3.2313 μs |    0.41 KB |
| Friflo_C4  | 1        |     1.3467 μs |    0.43 KB |
| Theia_C4   | 5        |     1.8375 μs |    0.39 KB |
| Arch_C4    | 5        |     2.6500 μs |    0.39 KB |
| Fennecs_C4 | 5        |     6.4429 μs |    0.51 KB |
| Friflo_C4  | 5        |     2.2875 μs |    0.48 KB |
| Theia_C4   | 10       |     2.6733 μs |    0.39 KB |
| Arch_C4    | 10       |     3.8267 μs |    0.39 KB |
| Fennecs_C4 | 10       |     9.6071 μs |    0.63 KB |
| Friflo_C4  | 10       |     3.1533 μs |    0.57 KB |
| Theia_C4   | 25       |     6.0467 μs |    0.87 KB |
| Arch_C4    | 25       |     7.4500 μs |    0.39 KB |
| Fennecs_C4 | 25       |    17.7312 μs |    0.98 KB |
| Friflo_C4  | 25       |     5.1600 μs |    0.72 KB |
| Theia_C4   | 50       |     9.6583 μs |    0.99 KB |
| Arch_C4    | 50       |    13.5133 μs |    0.39 KB |
| Fennecs_C4 | 50       |    32.6143 μs |    1.56 KB |
| Friflo_C4  | 50       |     8.2188 μs |    0.99 KB |
| Theia_C4   | 100      |    16.7857 μs |    1.24 KB |
| Arch_C4    | 100      |    23.0231 μs |    0.39 KB |
| Fennecs_C4 | 100      |    60.1437 μs |    2.73 KB |
| Friflo_C4  | 100      |    14.7667 μs |    1.52 KB |
| Theia_C4   | 200      |    33.4000 μs |    1.74 KB |
| Arch_C4    | 200      |    49.8000 μs |    0.39 KB |
| Fennecs_C4 | 200      |   121.2375 μs |    5.08 KB |
| Friflo_C4  | 200      |    28.0929 μs |    2.54 KB |
| Theia_C4   | 400      |    64.9800 μs |    2.74 KB |
| Arch_C4    | 400      |    96.1733 μs |    4.74 KB |
| Fennecs_C4 | 400      |   224.6786 μs |    9.77 KB |
| Friflo_C4  | 400      |    59.3250 μs |    4.56 KB |
| Theia_C4   | 800      |   134.9750 μs |    5.07 KB |
| Arch_C4    | 800      |   197.5933 μs |    9.07 KB |
| Fennecs_C4 | 800      |   441.8933 μs |   19.47 KB |
| Friflo_C4  | 800      |   123.5312 μs |    8.91 KB |
| Theia_C4   | 1600     |   223.4786 μs |    9.07 KB |
| Arch_C4    | 1600     |   338.0357 μs |   16.79 KB |
| Fennecs_C4 | 1600     |   536.9000 μs |   38.22 KB |
| Friflo_C4  | 1600     |   228.4375 μs |   16.66 KB |
| Theia_C4   | 3200     |   364.7267 μs |   33.75 KB |
| Arch_C4    | 3200     |   331.6267 μs |   33.73 KB |
| Fennecs_C4 | 3200     |   833.1929 μs |   76.38 KB |
| Friflo_C4  | 3200     |   410.5214 μs |   33.62 KB |
| Theia_C4   | 6400     |   730.3563 μs |   65.47 KB |
| Arch_C4    | 6400     |   598.9625 μs |   65.45 KB |
| Fennecs_C4 | 6400     | 1,365.0733 μs |  151.09 KB |
| Friflo_C4  | 6400     |   970.1933 μs |   65.31 KB |
| Theia_C4   | 16000    |   738.5000 μs |  129.09 KB |
| Arch_C4    | 16000    |   955.3687 μs |  129.77 KB |
| Fennecs_C4 | 16000    | 1,517.9688 μs |  504.45 KB |
| Friflo_C4  | 16000    | 1,450.9688 μs |  129.66 KB |
| Theia_C4   | 32000    | 1,190.1733 μs |   257.8 KB |
| Arch_C4    | 32000    | 1,334.3500 μs |  257.77 KB |
| Fennecs_C4 | 32000    | 1,575.1571 μs | 1135.75 KB |
| Friflo_C4  | 32000    | 2,552.7250 μs |  257.73 KB |
| Theia_C4   | 64000    | 2,367.6687 μs |  514.08 KB |
| Arch_C4    | 64000    | 2,635.1571 μs |  513.77 KB |
| Fennecs_C4 | 64000    | 3,162.5800 μs | 2397.49 KB |
| Friflo_C4  | 64000    | 1,198.8800 μs |  514.04 KB |
| Theia_C4   | 100000   | 3,506.0687 μs | 1025.47 KB |
| Arch_C4    | 100000   | 4,119.1143 μs | 1024.46 KB |
| Fennecs_C4 | 100000   | 5,019.6143 μs | 4264.61 KB |
| Friflo_C4  | 100000   | 1,878.6937 μs | 1025.73 KB |
