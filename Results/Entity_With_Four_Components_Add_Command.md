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
| Theia_C4  | 1        |      4.121 μs |     0.76 KB |
| Arch_C4   | 1        |     13.443 μs |    25.97 KB |
| Friflo_C4 | 1        |      6.967 μs |    14.55 KB |
| Theia_C4  | 5        |      6.493 μs |     1.13 KB |
| Arch_C4   | 5        |     18.046 μs |     26.1 KB |
| Friflo_C4 | 5        |      9.907 μs |    14.74 KB |
| Theia_C4  | 10       |      8.569 μs |      1.6 KB |
| Arch_C4   | 10       |     23.914 μs |    26.47 KB |
| Friflo_C4 | 10       |     13.280 μs |    16.92 KB |
| Theia_C4  | 25       |     15.921 μs |     4.09 KB |
| Arch_C4   | 25       |     38.300 μs |    27.59 KB |
| Friflo_C4 | 25       |     21.564 μs |    21.24 KB |
| Theia_C4  | 50       |     25.950 μs |      6.8 KB |
| Arch_C4   | 50       |     62.425 μs |    28.92 KB |
| Friflo_C4 | 50       |     36.667 μs |    30.08 KB |
| Theia_C4  | 100      |     50.750 μs |    12.24 KB |
| Arch_C4   | 100      |    107.753 μs |    32.52 KB |
| Friflo_C4 | 100      |     66.120 μs |    48.02 KB |
| Theia_C4  | 200      |    102.840 μs |    23.12 KB |
| Arch_C4   | 200      |    196.206 μs |     38.7 KB |
| Friflo_C4 | 200      |    123.354 μs |    84.54 KB |
| Theia_C4  | 400      |    194.331 μs |    44.87 KB |
| Arch_C4   | 400      |    336.613 μs |    51.83 KB |
| Friflo_C4 | 400      |    236.000 μs |   140.59 KB |
| Theia_C4  | 800      |    355.173 μs |   104.88 KB |
| Arch_C4   | 800      |    754.306 μs |   109.84 KB |
| Friflo_C4 | 800      |    425.720 μs |    295.1 KB |
| Theia_C4  | 1600     |    665.344 μs |   207.79 KB |
| Arch_C4   | 1600     |  1,346.950 μs |   193.13 KB |
| Friflo_C4 | 1600     |    527.847 μs |   605.05 KB |
| Theia_C4  | 3200     |  1,079.675 μs |   423.13 KB |
| Arch_C4   | 3200     |  2,304.336 μs |   376.57 KB |
| Friflo_C4 | 3200     |    770.062 μs |  1229.03 KB |
| Theia_C4  | 6400     |  1,751.694 μs |   851.78 KB |
| Arch_C4   | 6400     |  5,964.050 μs |   735.27 KB |
| Friflo_C4 | 6400     |  1,523.881 μs |  2481.42 KB |
| Theia_C4  | 16000    |  5,155.394 μs |  2075.46 KB |
| Arch_C4   | 16000    |  6,047.719 μs |  1639.98 KB |
| Friflo_C4 | 16000    |  1,798.756 μs |  5000.16 KB |
| Theia_C4  | 32000    |  2,673.887 μs |  4140.57 KB |
| Arch_C4   | 32000    |  8,660.077 μs |  3304.63 KB |
| Friflo_C4 | 32000    |  2,280.157 μs | 10062.41 KB |
| Theia_C4  | 64000    |  5,432.040 μs |  8286.84 KB |
| Arch_C4   | 64000    | 17,203.900 μs |  6749.42 KB |
| Friflo_C4 | 64000    |  4,501.008 μs | 20239.87 KB |
| Theia_C4  | 100000   |  8,643.723 μs | 13292.53 KB |
| Arch_C4   | 100000   | 26,943.356 μs | 12173.52 KB |
| Friflo_C4 | 100000   |  8,388.425 μs | 40703.23 KB |
