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
| Theia_C2   | 1        |   0.9400 μs |   0.39 KB |
| Arch_C2    | 1        |   3.2214 μs |   0.73 KB |
| Fennecs_C2 | 1        |   7.8643 μs |   0.71 KB |
| Friflo_C2  | 1        |   2.7533 μs |   0.16 KB |
| Theia_C2   | 5        |   1.0769 μs |   0.11 KB |
| Arch_C2    | 5        |   3.3286 μs |   0.73 KB |
| Fennecs_C2 | 5        |   8.1000 μs |   0.71 KB |
| Friflo_C2  | 5        |   2.8429 μs |   0.45 KB |
| Theia_C2   | 10       |   1.1923 μs |   0.11 KB |
| Arch_C2    | 10       |   3.4667 μs |   0.73 KB |
| Fennecs_C2 | 10       |   8.1400 μs |   0.71 KB |
| Friflo_C2  | 10       |   2.9813 μs |   0.45 KB |
| Theia_C2   | 25       |   1.4200 μs |   0.39 KB |
| Arch_C2    | 25       |   3.7385 μs |   0.73 KB |
| Fennecs_C2 | 25       |   8.3923 μs |   0.71 KB |
| Friflo_C2  | 25       |   3.3750 μs |   0.45 KB |
| Theia_C2   | 50       |   1.8267 μs |   0.39 KB |
| Arch_C2    | 50       |   4.1917 μs |   0.73 KB |
| Fennecs_C2 | 50       |   8.9688 μs |   0.71 KB |
| Friflo_C2  | 50       |   3.8857 μs |   0.45 KB |
| Theia_C2   | 100      |   2.5533 μs |   0.39 KB |
| Arch_C2    | 100      |   5.0467 μs |   0.73 KB |
| Fennecs_C2 | 100      |   9.7400 μs |   0.71 KB |
| Friflo_C2  | 100      |   5.0133 μs |   0.45 KB |
| Theia_C2   | 200      |   4.0643 μs |   0.39 KB |
| Arch_C2    | 200      |   6.8500 μs |   0.73 KB |
| Fennecs_C2 | 200      |  11.3538 μs |   0.71 KB |
| Friflo_C2  | 200      |   7.0000 μs |   0.45 KB |
| Theia_C2   | 400      |   7.6875 μs |   0.39 KB |
| Arch_C2    | 400      |  11.0563 μs |   0.73 KB |
| Fennecs_C2 | 400      |  14.4400 μs |   0.71 KB |
| Friflo_C2  | 400      |  11.2846 μs |   0.45 KB |
| Theia_C2   | 800      |  17.6375 μs |   0.39 KB |
| Arch_C2    | 800      |  23.7437 μs |   0.73 KB |
| Fennecs_C2 | 800      |  23.6125 μs |   0.71 KB |
| Friflo_C2  | 800      |  24.9000 μs |   0.45 KB |
| Theia_C2   | 1600     |  21.0077 μs |   0.72 KB |
| Arch_C2    | 1600     |  26.9786 μs |   1.06 KB |
| Fennecs_C2 | 1600     |  31.8077 μs |   1.04 KB |
| Friflo_C2  | 1600     |  29.3385 μs |   0.77 KB |
| Theia_C2   | 3200     |  22.1500 μs |   1.38 KB |
| Arch_C2    | 3200     |  31.1438 μs |   1.44 KB |
| Fennecs_C2 | 3200     |  57.8571 μs |    1.7 KB |
| Friflo_C2  | 3200     |  33.3857 μs |   1.43 KB |
| Theia_C2   | 6400     |  21.9643 μs |   1.38 KB |
| Arch_C2    | 6400     |  30.9933 μs |   1.72 KB |
| Fennecs_C2 | 6400     | 111.9667 μs |    1.7 KB |
| Friflo_C2  | 6400     |  38.2812 μs |   1.43 KB |
| Theia_C2   | 16000    |  31.5071 μs |   1.09 KB |
| Arch_C2    | 16000    |  40.4533 μs |   1.44 KB |
| Fennecs_C2 | 16000    | 145.3063 μs |   1.41 KB |
| Friflo_C2  | 16000    |  53.5000 μs |   1.15 KB |
| Theia_C2   | 32000    |  42.5625 μs |   1.42 KB |
| Arch_C2    | 32000    |  52.8500 μs |   1.77 KB |
| Fennecs_C2 | 32000    | 143.2067 μs |   1.74 KB |
| Friflo_C2  | 32000    |  73.9062 μs |   1.48 KB |
| Theia_C2   | 64000    |  66.2786 μs |   1.38 KB |
| Arch_C2    | 64000    |  80.6500 μs |   1.72 KB |
| Fennecs_C2 | 64000    | 154.3533 μs |    1.7 KB |
| Friflo_C2  | 64000    | 119.8500 μs |   1.43 KB |
| Theia_C2   | 100000   |  94.7000 μs |   1.38 KB |
| Arch_C2    | 100000   | 105.9000 μs |   1.39 KB |
| Fennecs_C2 | 100000   | 177.2857 μs |    1.7 KB |
| Friflo_C2  | 100000   | 168.4000 μs |   1.15 KB |
