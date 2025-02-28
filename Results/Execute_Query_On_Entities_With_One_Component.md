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
| Theia_C1   | 1        |   0.8500 μs |   0.39 KB |
| Arch_C1    | 1        |   3.0308 μs |   0.45 KB |
| Fennecs_C1 | 1        |   6.6286 μs |   0.64 KB |
| Friflo_C1  | 1        |   2.5400 μs |   0.45 KB |
| Theia_C1   | 5        |   0.9467 μs |   0.39 KB |
| Arch_C1    | 5        |   3.2667 μs |   0.73 KB |
| Fennecs_C1 | 5        |   6.7643 μs |   0.64 KB |
| Friflo_C1  | 5        |   2.7133 μs |   0.45 KB |
| Theia_C1   | 10       |   1.0562 μs |   0.39 KB |
| Arch_C1    | 10       |   3.4154 μs |   0.73 KB |
| Fennecs_C1 | 10       |   6.8357 μs |   0.64 KB |
| Friflo_C1  | 10       |   2.8875 μs |   0.45 KB |
| Theia_C1   | 25       |   1.1846 μs |   0.39 KB |
| Arch_C1    | 25       |   3.4917 μs |   0.73 KB |
| Fennecs_C1 | 25       |   7.1462 μs |   0.64 KB |
| Friflo_C1  | 25       |   3.0625 μs |   0.45 KB |
| Theia_C1   | 50       |   1.6200 μs |   0.39 KB |
| Arch_C1    | 50       |   3.9333 μs |   0.73 KB |
| Fennecs_C1 | 50       |   7.4733 μs |   0.64 KB |
| Friflo_C1  | 50       |   3.7062 μs |   0.45 KB |
| Theia_C1   | 100      |   2.2625 μs |   0.39 KB |
| Arch_C1    | 100      |   4.8438 μs |   0.73 KB |
| Fennecs_C1 | 100      |   8.2467 μs |   0.64 KB |
| Friflo_C1  | 100      |   4.6000 μs |   0.45 KB |
| Theia_C1   | 200      |   3.6500 μs |   0.39 KB |
| Arch_C1    | 200      |   6.3385 μs |   0.73 KB |
| Fennecs_C1 | 200      |   9.5933 μs |   0.64 KB |
| Friflo_C1  | 200      |   6.5625 μs |   0.45 KB |
| Theia_C1   | 400      |   6.3083 μs |   0.39 KB |
| Arch_C1    | 400      |  10.1500 μs |   0.41 KB |
| Fennecs_C1 | 400      |  12.5692 μs |   0.64 KB |
| Friflo_C1  | 400      |  10.8688 μs |   0.45 KB |
| Theia_C1   | 800      |  14.8800 μs |   0.39 KB |
| Arch_C1    | 800      |  18.6938 μs |   0.73 KB |
| Fennecs_C1 | 800      |  21.3867 μs |   0.64 KB |
| Friflo_C1  | 800      |  20.9438 μs |   0.45 KB |
| Theia_C1   | 1600     |  21.2071 μs |   0.72 KB |
| Arch_C1    | 1600     |  28.7437 μs |   1.06 KB |
| Fennecs_C1 | 1600     |  29.1714 μs |   0.97 KB |
| Friflo_C1  | 1600     |  31.4846 μs |   0.77 KB |
| Theia_C1   | 3200     |  20.3933 μs |   1.38 KB |
| Arch_C1    | 3200     |  25.3200 μs |   1.72 KB |
| Fennecs_C1 | 3200     |  27.6533 μs |   1.63 KB |
| Friflo_C1  | 3200     |  30.0067 μs |   1.15 KB |
| Theia_C1   | 6400     |  22.1000 μs |   1.38 KB |
| Arch_C1    | 6400     |  31.8286 μs |   1.44 KB |
| Fennecs_C1 | 6400     |  33.8600 μs |   1.63 KB |
| Friflo_C1  | 6400     |  33.8133 μs |   1.43 KB |
| Theia_C1   | 16000    |  28.5813 μs |   1.38 KB |
| Arch_C1    | 16000    |  42.6375 μs |   1.72 KB |
| Fennecs_C1 | 16000    |  38.7933 μs |   1.63 KB |
| Friflo_C1  | 16000    |  46.8133 μs |   1.43 KB |
| Theia_C1   | 32000    |  37.2625 μs |   1.09 KB |
| Arch_C1    | 32000    |  51.7812 μs |   1.44 KB |
| Fennecs_C1 | 32000    |  49.5200 μs |   1.34 KB |
| Friflo_C1  | 32000    |  64.3000 μs |   1.15 KB |
| Theia_C1   | 64000    |  57.3643 μs |   1.42 KB |
| Arch_C1    | 64000    |  74.0667 μs |   1.77 KB |
| Fennecs_C1 | 64000    |  68.5333 μs |   1.67 KB |
| Friflo_C1  | 64000    | 102.8357 μs |   1.48 KB |
| Theia_C1   | 100000   |  77.1813 μs |   0.44 KB |
| Arch_C1    | 100000   | 100.5857 μs |   0.45 KB |
| Fennecs_C1 | 100000   |  83.3750 μs |   0.97 KB |
| Friflo_C1  | 100000   | 151.2562 μs |   0.49 KB |
