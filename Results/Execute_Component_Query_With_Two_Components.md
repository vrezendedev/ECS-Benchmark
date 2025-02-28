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
| Theia_C2   | 1        |   0.8533 μs |   0.39 KB |
| Arch_C2    | 1        |   2.0375 μs |   0.73 KB |
| Fennecs_C2 | 1        |   3.4929 μs |    0.7 KB |
| Friflo_C3  | 1        |   0.8857 μs |   0.39 KB |
| Theia_C2   | 5        |   1.4625 μs |   0.39 KB |
| Arch_C2    | 5        |   4.0133 μs |   0.73 KB |
| Fennecs_C2 | 5        |  10.6857 μs |    0.4 KB |
| Friflo_C3  | 5        |   3.5562 μs |   0.45 KB |
| Theia_C2   | 10       |   1.6187 μs |   0.39 KB |
| Arch_C2    | 10       |   4.1688 μs |   0.73 KB |
| Fennecs_C2 | 10       |  10.7188 μs |   0.45 KB |
| Friflo_C3  | 10       |   3.7437 μs |   0.45 KB |
| Theia_C2   | 25       |   1.8571 μs |   0.39 KB |
| Arch_C2    | 25       |   4.4933 μs |   0.73 KB |
| Fennecs_C2 | 25       |  11.2500 μs |    0.4 KB |
| Friflo_C3  | 25       |   4.1000 μs |   0.45 KB |
| Theia_C2   | 50       |   2.2267 μs |   0.39 KB |
| Arch_C2    | 50       |   5.2313 μs |   0.73 KB |
| Fennecs_C2 | 50       |  11.6000 μs |   0.73 KB |
| Friflo_C3  | 50       |   4.6133 μs |   0.45 KB |
| Theia_C2   | 100      |   2.9562 μs |   0.39 KB |
| Arch_C2    | 100      |   6.0438 μs |   0.73 KB |
| Fennecs_C2 | 100      |  12.5733 μs |   0.73 KB |
| Friflo_C3  | 100      |   5.7313 μs |   0.45 KB |
| Theia_C2   | 200      |   4.4143 μs |   0.39 KB |
| Arch_C2    | 200      |   7.8875 μs |   0.73 KB |
| Fennecs_C2 | 200      |  14.2857 μs |   0.73 KB |
| Friflo_C3  | 200      |   7.7750 μs |   0.45 KB |
| Theia_C2   | 400      |   8.4857 μs |   0.39 KB |
| Arch_C2    | 400      |  14.1500 μs |   0.73 KB |
| Fennecs_C2 | 400      |  21.0625 μs |   0.73 KB |
| Friflo_C3  | 400      |  14.3385 μs |   0.45 KB |
| Theia_C2   | 800      |  16.6438 μs |   0.11 KB |
| Arch_C2    | 800      |  22.5786 μs |   0.73 KB |
| Fennecs_C2 | 800      |  23.9000 μs |   0.73 KB |
| Friflo_C3  | 800      |  23.5063 μs |   0.45 KB |
| Theia_C2   | 1600     |  21.5571 μs |   0.11 KB |
| Arch_C2    | 1600     |  29.8000 μs |   0.73 KB |
| Fennecs_C2 | 1600     |  37.0071 μs |   0.73 KB |
| Friflo_C3  | 1600     |  31.4214 μs |   0.16 KB |
| Theia_C2   | 3200     |  22.9133 μs |   1.38 KB |
| Arch_C2    | 3200     |  31.5214 μs |   1.72 KB |
| Fennecs_C2 | 3200     |  63.5067 μs |   1.71 KB |
| Friflo_C3  | 3200     |  34.0615 μs |   1.43 KB |
| Theia_C2   | 6400     |  26.1187 μs |   1.38 KB |
| Arch_C2    | 6400     |  36.6133 μs |   1.72 KB |
| Fennecs_C2 | 6400     | 112.7857 μs |   1.71 KB |
| Friflo_C3  | 6400     |  39.7467 μs |   1.43 KB |
| Theia_C2   | 16000    |  31.3125 μs |   1.38 KB |
| Arch_C2    | 16000    |  40.2800 μs |   1.44 KB |
| Fennecs_C2 | 16000    | 217.9500 μs |   1.43 KB |
| Friflo_C3  | 16000    |  51.4077 μs |   1.43 KB |
| Theia_C2   | 32000    |  43.5714 μs |   0.39 KB |
| Arch_C2    | 32000    |  55.0312 μs |   1.39 KB |
| Fennecs_C2 | 32000    | 384.2538 μs |   1.71 KB |
| Friflo_C3  | 32000    |  78.6143 μs |   0.82 KB |
| Theia_C2   | 64000    |  69.3133 μs |   1.09 KB |
| Arch_C2    | 64000    |  77.5333 μs |   1.11 KB |
| Fennecs_C2 | 64000    | 284.1000 μs |   1.43 KB |
| Friflo_C3  | 64000    | 127.1333 μs |   1.15 KB |
| Theia_C2   | 100000   |  98.0000 μs |   1.09 KB |
| Arch_C2    | 100000   | 102.8786 μs |   1.72 KB |
| Fennecs_C2 | 100000   | 314.5077 μs |   1.71 KB |
| Friflo_C3  | 100000   | 169.2714 μs |   1.15 KB |
