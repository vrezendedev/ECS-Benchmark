```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5555/22H2/2022Update)
AMD Ryzen 5 5600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  Job-XJEJRV : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=16  UnrollFactor=1  

```
| Method    | Entities | Mean          | Allocated   |
|---------- |--------- |--------------:|------------:|
| Theia_C3  | 1        |      4.053 μs |     0.73 KB |
| Arch_C3   | 1        |     13.467 μs |    25.87 KB |
| Friflo_C3 | 1        |      7.047 μs |    12.57 KB |
| Theia_C3  | 5        |      6.221 μs |     1.11 KB |
| Arch_C3   | 5        |     18.357 μs |    26.13 KB |
| Friflo_C3 | 5        |     11.500 μs |    12.76 KB |
| Theia_C3  | 10       |      8.073 μs |     1.58 KB |
| Arch_C3   | 10       |     23.200 μs |    26.55 KB |
| Friflo_C3 | 10       |     12.647 μs |    14.94 KB |
| Theia_C3  | 25       |     14.573 μs |     4.06 KB |
| Arch_C3   | 25       |     35.853 μs |    27.38 KB |
| Friflo_C3 | 25       |     20.386 μs |    19.26 KB |
| Theia_C3  | 50       |     24.600 μs |     6.78 KB |
| Arch_C3   | 50       |     57.520 μs |    28.91 KB |
| Friflo_C3 | 50       |     32.860 μs |    28.09 KB |
| Theia_C3  | 100      |     42.240 μs |    12.22 KB |
| Arch_C3   | 100      |     99.280 μs |    31.93 KB |
| Friflo_C3 | 100      |     61.453 μs |    46.04 KB |
| Theia_C3  | 200      |     89.662 μs |    23.09 KB |
| Arch_C3   | 200      |    183.631 μs |    37.89 KB |
| Friflo_C3 | 200      |    108.187 μs |    82.55 KB |
| Theia_C3  | 400      |    204.173 μs |    44.84 KB |
| Arch_C3   | 400      |    356.833 μs |    49.74 KB |
| Friflo_C3 | 400      |    227.181 μs |   138.27 KB |
| Theia_C3  | 800      |    325.646 μs |    88.34 KB |
| Arch_C3   | 800      |    685.480 μs |   114.23 KB |
| Friflo_C3 | 800      |    364.881 μs |   288.77 KB |
| Theia_C3  | 1600     |    561.113 μs |   191.86 KB |
| Arch_C3   | 1600     |  1,370.531 μs |   184.91 KB |
| Friflo_C3 | 1600     |    651.492 μs |   591.02 KB |
| Theia_C3  | 3200     |    922.933 μs |   406.91 KB |
| Arch_C3   | 3200     |  2,050.060 μs |    336.2 KB |
| Friflo_C3 | 3200     |  1,043.073 μs |  1198.98 KB |
| Theia_C3  | 6400     |  2,209.300 μs |   819.66 KB |
| Arch_C3   | 6400     |  1,607.719 μs |    670.5 KB |
| Friflo_C3 | 6400     |  1,559.381 μs |  2419.63 KB |
| Theia_C3  | 16000    |  1,169.469 μs |  2010.41 KB |
| Arch_C3   | 16000    |  3,959.833 μs |  1506.84 KB |
| Friflo_C3 | 16000    |  2,831.381 μs |  4873.73 KB |
| Theia_C3  | 32000    |  4,919.387 μs |  4027.35 KB |
| Arch_C3   | 32000    |  7,777.271 μs |  3032.86 KB |
| Friflo_C3 | 32000    |  2,337.844 μs |  9808.29 KB |
| Theia_C3  | 64000    |  4,800.740 μs |  8044.91 KB |
| Arch_C3   | 64000    | 15,564.160 μs |  6176.16 KB |
| Friflo_C3 | 64000    |  4,214.258 μs | 19729.72 KB |
| Theia_C3  | 100000   |  7,516.536 μs | 12898.59 KB |
| Arch_C3   | 100000   | 24,448.612 μs | 11142.37 KB |
| Friflo_C3 | 100000   |  7,577.154 μs | 39680.73 KB |
