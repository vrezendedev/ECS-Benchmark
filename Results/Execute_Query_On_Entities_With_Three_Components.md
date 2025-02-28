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
| Theia_C3   | 1        |   1.181 μs |   0.39 KB |
| Arch_C3    | 1        |   3.350 μs |   0.73 KB |
| Fennecs_C3 | 1        |   9.173 μs |    0.8 KB |
| Friflo_C3  | 1        |   2.808 μs |   0.45 KB |
| Theia_C3   | 5        |   1.347 μs |   0.39 KB |
| Arch_C3    | 5        |   3.536 μs |   0.73 KB |
| Fennecs_C3 | 5        |   9.369 μs |    0.8 KB |
| Friflo_C3  | 5        |   3.067 μs |   0.45 KB |
| Theia_C3   | 10       |   1.413 μs |   0.39 KB |
| Arch_C3    | 10       |   3.636 μs |   0.73 KB |
| Fennecs_C3 | 10       |   9.400 μs |    0.8 KB |
| Friflo_C3  | 10       |   3.125 μs |   0.45 KB |
| Theia_C3   | 25       |   1.625 μs |   0.39 KB |
| Arch_C3    | 25       |   4.050 μs |   0.73 KB |
| Fennecs_C3 | 25       |   9.662 μs |    0.8 KB |
| Friflo_C3  | 25       |   3.640 μs |   0.45 KB |
| Theia_C3   | 50       |   2.087 μs |   0.39 KB |
| Arch_C3    | 50       |   4.569 μs |   0.73 KB |
| Fennecs_C3 | 50       |  10.323 μs |    0.8 KB |
| Friflo_C3  | 50       |   4.157 μs |   0.45 KB |
| Theia_C3   | 100      |   2.931 μs |   0.39 KB |
| Arch_C3    | 100      |   5.733 μs |   0.73 KB |
| Fennecs_C3 | 100      |  11.236 μs |    0.8 KB |
| Friflo_C3  | 100      |   5.364 μs |   0.45 KB |
| Theia_C3   | 200      |   5.343 μs |   0.39 KB |
| Arch_C3    | 200      |   7.800 μs |   0.73 KB |
| Fennecs_C3 | 200      |  13.292 μs |    0.8 KB |
| Friflo_C3  | 200      |   7.525 μs |   0.45 KB |
| Theia_C3   | 400      |   9.331 μs |   0.39 KB |
| Arch_C3    | 400      |  12.900 μs |   0.73 KB |
| Fennecs_C3 | 400      |  18.531 μs |    0.8 KB |
| Friflo_C3  | 400      |  11.831 μs |   0.45 KB |
| Theia_C3   | 800      |  17.900 μs |   0.39 KB |
| Arch_C3    | 800      |  23.293 μs |   0.73 KB |
| Fennecs_C3 | 800      |  25.406 μs |    0.8 KB |
| Friflo_C3  | 800      |  24.543 μs |   0.16 KB |
| Theia_C3   | 1600     |  24.229 μs |   0.72 KB |
| Arch_C3    | 1600     |  31.736 μs |   1.06 KB |
| Fennecs_C3 | 1600     |  39.400 μs |   1.13 KB |
| Friflo_C3  | 1600     |  31.554 μs |   0.77 KB |
| Theia_C3   | 3200     |  24.975 μs |   1.38 KB |
| Arch_C3    | 3200     |  33.650 μs |   1.72 KB |
| Fennecs_C3 | 3200     |  62.936 μs |    1.5 KB |
| Friflo_C3  | 3200     |  34.229 μs |   1.43 KB |
| Theia_C3   | 6400     |  29.867 μs |   1.38 KB |
| Arch_C3    | 6400     |  39.620 μs |   1.72 KB |
| Fennecs_C3 | 6400     | 130.647 μs |   1.78 KB |
| Friflo_C3  | 6400     |  41.353 μs |   1.43 KB |
| Theia_C3   | 16000    |  36.763 μs |   1.09 KB |
| Arch_C3    | 16000    |  50.680 μs |   1.44 KB |
| Fennecs_C3 | 16000    | 173.987 μs |    1.5 KB |
| Friflo_C3  | 16000    |  55.387 μs |   1.15 KB |
| Theia_C3   | 32000    |  51.825 μs |   1.05 KB |
| Arch_C3    | 32000    |  65.950 μs |   1.11 KB |
| Fennecs_C3 | 32000    | 176.173 μs |   1.78 KB |
| Friflo_C3  | 32000    |  81.019 μs |   0.82 KB |
| Theia_C3   | 64000    |  88.773 μs |   1.38 KB |
| Arch_C3    | 64000    | 101.737 μs |   1.77 KB |
| Fennecs_C3 | 64000    | 176.181 μs |   1.83 KB |
| Friflo_C3  | 64000    | 110.144 μs |   1.48 KB |
| Theia_C3   | 100000   | 121.393 μs |   1.09 KB |
| Arch_C3    | 100000   | 135.200 μs |   1.39 KB |
| Fennecs_C3 | 100000   | 202.483 μs |   1.45 KB |
| Friflo_C3  | 100000   | 197.694 μs |   0.77 KB |
