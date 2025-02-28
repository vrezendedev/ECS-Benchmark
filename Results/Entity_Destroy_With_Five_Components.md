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
| Theia_C5   | 1        |     0.6625 μs |    0.39 KB |
| Arch_C5    | 1        |     1.4133 μs |    0.39 KB |
| Fennecs_C5 | 1        |     3.4571 μs |    0.41 KB |
| Friflo_C5  | 1        |     1.3188 μs |    0.43 KB |
| Theia_C5   | 5        |     1.9125 μs |    0.39 KB |
| Arch_C5    | 5        |     2.6867 μs |    0.39 KB |
| Fennecs_C5 | 5        |     7.0538 μs |    0.51 KB |
| Friflo_C5  | 5        |     2.2857 μs |    0.48 KB |
| Theia_C5   | 10       |     2.7933 μs |    0.39 KB |
| Arch_C5    | 10       |     3.9375 μs |    0.39 KB |
| Fennecs_C5 | 10       |    10.9062 μs |    0.63 KB |
| Friflo_C5  | 10       |     3.3062 μs |    0.57 KB |
| Theia_C5   | 25       |     6.5187 μs |    0.87 KB |
| Arch_C5    | 25       |     7.6200 μs |    0.39 KB |
| Fennecs_C5 | 25       |    20.8533 μs |    0.98 KB |
| Friflo_C5  | 25       |     5.6188 μs |    0.72 KB |
| Theia_C5   | 50       |    10.3929 μs |    0.99 KB |
| Arch_C5    | 50       |    13.4533 μs |    0.39 KB |
| Fennecs_C5 | 50       |    37.9562 μs |    1.56 KB |
| Friflo_C5  | 50       |     8.8267 μs |    0.71 KB |
| Theia_C5   | 100      |    20.2063 μs |    1.24 KB |
| Arch_C5    | 100      |    28.3467 μs |    0.39 KB |
| Fennecs_C5 | 100      |    72.5687 μs |    2.73 KB |
| Friflo_C5  | 100      |    16.4438 μs |    1.52 KB |
| Theia_C5   | 200      |    47.2750 μs |    1.74 KB |
| Arch_C5    | 200      |    62.4312 μs |    0.39 KB |
| Fennecs_C5 | 200      |   164.9875 μs |    5.08 KB |
| Friflo_C5  | 200      |    36.9500 μs |    2.54 KB |
| Theia_C5   | 400      |    75.6933 μs |    2.74 KB |
| Arch_C5    | 400      |   100.9643 μs |    4.74 KB |
| Fennecs_C5 | 400      |   277.3400 μs |    9.77 KB |
| Friflo_C5  | 400      |    62.5769 μs |    4.56 KB |
| Theia_C5   | 800      |   168.8313 μs |    5.07 KB |
| Arch_C5    | 800      |   247.8867 μs |    9.07 KB |
| Fennecs_C5 | 800      |   424.3438 μs |   19.47 KB |
| Friflo_C5  | 800      |   125.3500 μs |    8.91 KB |
| Theia_C5   | 1600     |   239.5583 μs |    9.07 KB |
| Arch_C5    | 1600     |   415.6313 μs |   16.79 KB |
| Fennecs_C5 | 1600     |   763.6733 μs |   38.22 KB |
| Friflo_C5  | 1600     |   247.7200 μs |   16.94 KB |
| Theia_C5   | 3200     |   505.7500 μs |   33.75 KB |
| Arch_C5    | 3200     |   353.6000 μs |   33.73 KB |
| Fennecs_C5 | 3200     |   782.8937 μs |   76.38 KB |
| Friflo_C5  | 3200     |   536.1187 μs |   33.62 KB |
| Theia_C5   | 6400     |   285.2133 μs |   65.47 KB |
| Arch_C5    | 6400     |   468.4000 μs |   65.45 KB |
| Fennecs_C5 | 6400     |   994.5187 μs |  151.09 KB |
| Friflo_C5  | 6400     |   132.1533 μs |   65.36 KB |
| Theia_C5   | 16000    | 1,277.0000 μs |   129.8 KB |
| Arch_C5    | 16000    |   929.6187 μs |  129.73 KB |
| Fennecs_C5 | 16000    |   857.5750 μs |   504.4 KB |
| Friflo_C5  | 16000    |   319.6250 μs |  129.66 KB |
| Theia_C5   | 32000    | 1,360.0133 μs |   257.8 KB |
| Arch_C5    | 32000    | 1,490.2125 μs |  257.77 KB |
| Fennecs_C5 | 32000    | 1,781.3857 μs | 1135.47 KB |
| Friflo_C5  | 32000    |   646.7200 μs |  257.73 KB |
| Theia_C5   | 64000    | 2,743.1500 μs |  514.08 KB |
| Arch_C5    | 64000    | 3,000.7812 μs |  513.73 KB |
| Fennecs_C5 | 64000    | 3,588.6143 μs | 2397.45 KB |
| Friflo_C5  | 64000    | 1,276.1500 μs |  513.76 KB |
| Theia_C5   | 100000   | 4,212.6571 μs | 1025.14 KB |
| Arch_C5    | 100000   | 4,639.8333 μs | 1025.73 KB |
| Fennecs_C5 | 100000   | 5,709.4200 μs | 4263.91 KB |
| Friflo_C5  | 100000   | 1,951.0538 μs | 1025.73 KB |
