```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5555/22H2/2022Update)
AMD Ryzen 5 5600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  Job-XJEJRV : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=16  UnrollFactor=1  

```
| Method     | Entities | Mean        | Allocated |
|----------- |--------- |------------:|----------:|
| Theia_C1   | 1        |   0.8933 μs |   0.39 KB |
| Arch_C1    | 1        |   2.0071 μs |   0.73 KB |
| Fennecs_C1 | 1        |   3.0750 μs |   0.63 KB |
| Friflo_C1  | 1        |   0.8714 μs |   0.39 KB |
| Theia_C1   | 5        |   1.4750 μs |   0.39 KB |
| Arch_C1    | 5        |   3.7267 μs |   0.73 KB |
| Fennecs_C1 | 5        |   7.7467 μs |   0.66 KB |
| Friflo_C1  | 5        |   3.2692 μs |   0.45 KB |
| Theia_C1   | 10       |   1.5214 μs |   0.39 KB |
| Arch_C1    | 10       |   3.8563 μs |   0.73 KB |
| Fennecs_C1 | 10       |   7.8143 μs |   0.66 KB |
| Friflo_C1  | 10       |   3.4250 μs |   0.45 KB |
| Theia_C1   | 25       |   1.7625 μs |   0.39 KB |
| Arch_C1    | 25       |   4.2900 μs |   0.73 KB |
| Fennecs_C1 | 25       |   8.0875 μs |   0.66 KB |
| Friflo_C1  | 25       |   3.7467 μs |   0.45 KB |
| Theia_C1   | 50       |   2.0750 μs |   0.39 KB |
| Arch_C1    | 50       |   4.5750 μs |   0.45 KB |
| Fennecs_C1 | 50       |   8.4786 μs |   0.66 KB |
| Friflo_C1  | 50       |   4.3438 μs |   0.45 KB |
| Theia_C1   | 100      |   2.7400 μs |   0.39 KB |
| Arch_C1    | 100      |   5.5187 μs |   0.73 KB |
| Fennecs_C1 | 100      |   9.3200 μs |   0.66 KB |
| Friflo_C1  | 100      |   5.1467 μs |   0.45 KB |
| Theia_C1   | 200      |   4.1800 μs |   0.39 KB |
| Arch_C1    | 200      |   7.2429 μs |   0.73 KB |
| Fennecs_C1 | 200      |  10.8214 μs |   0.66 KB |
| Friflo_C1  | 200      |   7.1250 μs |   0.45 KB |
| Theia_C1   | 400      |   7.3875 μs |   0.39 KB |
| Arch_C1    | 400      |  10.7625 μs |   0.73 KB |
| Fennecs_C1 | 400      |  14.4125 μs |   0.66 KB |
| Friflo_C1  | 400      |  11.1462 μs |   0.16 KB |
| Theia_C1   | 800      |  15.4933 μs |   0.39 KB |
| Arch_C1    | 800      |  19.9857 μs |   0.73 KB |
| Fennecs_C1 | 800      |  22.7533 μs |   0.66 KB |
| Friflo_C1  | 800      |  21.2875 μs |   0.45 KB |
| Theia_C1   | 1600     |  20.1143 μs |   0.39 KB |
| Arch_C1    | 1600     |  28.3067 μs |   0.73 KB |
| Fennecs_C1 | 1600     |  28.0231 μs |   0.66 KB |
| Friflo_C1  | 1600     |  28.7429 μs |   0.16 KB |
| Theia_C1   | 3200     |  20.7615 μs |   1.38 KB |
| Arch_C1    | 3200     |  29.6625 μs |   1.72 KB |
| Fennecs_C1 | 3200     |  31.7714 μs |   1.64 KB |
| Friflo_C1  | 3200     |  30.6500 μs |   1.43 KB |
| Theia_C1   | 6400     |  23.3500 μs |   1.38 KB |
| Arch_C1    | 6400     |  32.8750 μs |   1.72 KB |
| Fennecs_C1 | 6400     |  36.1714 μs |   1.64 KB |
| Friflo_C1  | 6400     |  35.9500 μs |   1.43 KB |
| Theia_C1   | 16000    |  29.1800 μs |   1.09 KB |
| Arch_C1    | 16000    |  40.8625 μs |   1.72 KB |
| Fennecs_C1 | 16000    |  51.1733 μs |   1.64 KB |
| Friflo_C1  | 16000    |  47.7125 μs |    1.1 KB |
| Theia_C1   | 32000    |  40.4062 μs |   1.38 KB |
| Arch_C1    | 32000    |  55.2625 μs |   1.72 KB |
| Fennecs_C1 | 32000    |  50.1812 μs |   1.64 KB |
| Friflo_C1  | 32000    |  70.1312 μs |   1.43 KB |
| Theia_C1   | 64000    |  57.0667 μs |   1.42 KB |
| Arch_C1    | 64000    |  74.5357 μs |   1.72 KB |
| Fennecs_C1 | 64000    |  66.6067 μs |   1.31 KB |
| Friflo_C1  | 64000    | 107.5875 μs |   1.43 KB |
| Theia_C1   | 100000   |  80.6571 μs |   1.09 KB |
| Arch_C1    | 100000   | 104.6067 μs |   1.72 KB |
| Fennecs_C1 | 100000   |  82.9437 μs |   1.64 KB |
| Friflo_C1  | 100000   | 149.0875 μs |   1.76 KB |
