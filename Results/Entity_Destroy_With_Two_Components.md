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
| Theia_C2   | 1        |     0.6467 μs |    0.39 KB |
| Arch_C2    | 1        |     1.3733 μs |    0.39 KB |
| Fennecs_C2 | 1        |     2.6437 μs |    0.41 KB |
| Friflo_C2  | 1        |     1.4250 μs |    0.43 KB |
| Theia_C2   | 5        |     1.6733 μs |    0.39 KB |
| Arch_C2    | 5        |     2.3000 μs |    0.39 KB |
| Fennecs_C2 | 5        |     4.7200 μs |    0.51 KB |
| Friflo_C2  | 5        |     2.0643 μs |    0.48 KB |
| Theia_C2   | 10       |     2.2563 μs |    0.39 KB |
| Arch_C2    | 10       |     3.5063 μs |    0.39 KB |
| Fennecs_C2 | 10       |     6.8600 μs |    0.63 KB |
| Friflo_C2  | 10       |     2.8200 μs |    0.57 KB |
| Theia_C2   | 25       |     5.0800 μs |    0.87 KB |
| Arch_C2    | 25       |     6.8000 μs |    0.39 KB |
| Fennecs_C2 | 25       |    12.3688 μs |    0.98 KB |
| Friflo_C2  | 25       |     4.4500 μs |    0.72 KB |
| Theia_C2   | 50       |     8.3500 μs |    0.66 KB |
| Arch_C2    | 50       |    11.7600 μs |    0.39 KB |
| Fennecs_C2 | 50       |    22.2571 μs |    1.56 KB |
| Friflo_C2  | 50       |     7.1667 μs |    0.99 KB |
| Theia_C2   | 100      |    13.5333 μs |    1.24 KB |
| Arch_C2    | 100      |    21.0500 μs |    0.39 KB |
| Fennecs_C2 | 100      |    37.9062 μs |    2.73 KB |
| Friflo_C2  | 100      |    11.5429 μs |    1.23 KB |
| Theia_C2   | 200      |    25.5286 μs |    1.46 KB |
| Arch_C2    | 200      |    42.1500 μs |    0.39 KB |
| Fennecs_C2 | 200      |    74.3000 μs |    5.08 KB |
| Friflo_C2  | 200      |    23.2000 μs |    2.54 KB |
| Theia_C2   | 400      |    49.5063 μs |    2.74 KB |
| Arch_C2    | 400      |    90.3733 μs |    4.74 KB |
| Fennecs_C2 | 400      |   156.0143 μs |    9.77 KB |
| Friflo_C2  | 400      |    48.8250 μs |    4.56 KB |
| Theia_C2   | 800      |   114.5250 μs |    4.74 KB |
| Arch_C2    | 800      |   203.7625 μs |    8.74 KB |
| Fennecs_C2 | 800      |   357.4000 μs |   19.14 KB |
| Friflo_C2  | 800      |   115.8812 μs |    8.59 KB |
| Theia_C2   | 1600     |   159.1733 μs |    9.07 KB |
| Arch_C2    | 1600     |   239.0692 μs |   17.07 KB |
| Fennecs_C2 | 1600     |   588.4929 μs |   38.22 KB |
| Friflo_C2  | 1600     |   187.0077 μs |   16.94 KB |
| Theia_C2   | 3200     |   259.2467 μs |   33.47 KB |
| Arch_C2    | 3200     |   288.2733 μs |   33.73 KB |
| Fennecs_C2 | 3200     |   947.8250 μs |   76.38 KB |
| Friflo_C2  | 3200     |   334.7286 μs |   33.62 KB |
| Theia_C2   | 6400     |   526.7200 μs |   65.75 KB |
| Arch_C2    | 6400     |   392.8600 μs |   65.73 KB |
| Fennecs_C2 | 6400     |   355.6429 μs |  151.38 KB |
| Friflo_C2  | 6400     |   603.0231 μs |   65.64 KB |
| Theia_C2   | 16000    | 1,035.1437 μs |  129.47 KB |
| Arch_C2    | 16000    |   816.3214 μs |  129.45 KB |
| Fennecs_C2 | 16000    | 2,257.1067 μs |  504.12 KB |
| Friflo_C2  | 16000    | 1,318.8688 μs |  129.38 KB |
| Theia_C2   | 32000    |   787.3000 μs |  258.08 KB |
| Arch_C2    | 32000    | 1,097.8937 μs |  257.77 KB |
| Fennecs_C2 | 32000    | 1,149.1125 μs | 1135.47 KB |
| Friflo_C2  | 32000    |   551.9375 μs |  257.73 KB |
| Theia_C2   | 64000    | 1,582.7000 μs |  513.75 KB |
| Arch_C2    | 64000    | 2,089.1154 μs |  512.79 KB |
| Fennecs_C2 | 64000    | 2,412.4571 μs | 2396.13 KB |
| Friflo_C2  | 64000    | 1,070.5769 μs |  512.73 KB |
| Theia_C2   | 100000   | 2,426.2571 μs | 1024.81 KB |
| Arch_C2    | 100000   | 3,290.9714 μs | 1025.12 KB |
| Fennecs_C2 | 100000   | 3,788.6438 μs | 4264.61 KB |
| Friflo_C2  | 100000   | 1,676.6714 μs | 1025.73 KB |
