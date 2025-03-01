```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5555/22H2/2022Update)
AMD Ryzen 5 5600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  Job-XJEJRV : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=16  UnrollFactor=1  

```
| Method     | Entities | Mean          | Gen0      | Gen1      | Allocated   |
|----------- |--------- |--------------:|----------:|----------:|------------:|
| Theia_C2   | 1        |      3.600 μs |         - |         - |     0.63 KB |
| Arch_C2    | 1        |     13.200 μs |         - |         - |    33.59 KB |
| Fennecs_C2 | 1        |     38.660 μs |         - |         - |      7.7 KB |
| Friflo_C2  | 1        |      3.929 μs |         - |         - |     9.34 KB |
| Theia_C2   | 5        |      5.264 μs |         - |         - |     0.63 KB |
| Arch_C2    | 5        |     15.280 μs |         - |         - |    33.59 KB |
| Fennecs_C2 | 5        |     59.108 μs |         - |         - |     10.6 KB |
| Friflo_C2  | 5        |      4.860 μs |         - |         - |     9.34 KB |
| Theia_C2   | 10       |      6.707 μs |         - |         - |     0.63 KB |
| Arch_C2    | 10       |     23.169 μs |         - |         - |    33.59 KB |
| Fennecs_C2 | 10       |     83.756 μs |         - |         - |    14.08 KB |
| Friflo_C2  | 10       |      5.813 μs |         - |         - |     9.34 KB |
| Theia_C2   | 25       |     12.863 μs |         - |         - |      1.1 KB |
| Arch_C2    | 25       |     31.869 μs |         - |         - |    33.59 KB |
| Fennecs_C2 | 25       |    148.673 μs |         - |         - |    24.51 KB |
| Friflo_C2  | 25       |      7.692 μs |         - |         - |     9.34 KB |
| Theia_C2   | 50       |     18.006 μs |         - |         - |     0.95 KB |
| Arch_C2    | 50       |     44.407 μs |         - |         - |    33.59 KB |
| Fennecs_C2 | 50       |    265.264 μs |         - |         - |    43.14 KB |
| Friflo_C2  | 50       |     11.000 μs |         - |         - |     9.34 KB |
| Theia_C2   | 100      |     31.550 μs |         - |         - |     1.48 KB |
| Arch_C2    | 100      |     77.050 μs |         - |         - |    33.31 KB |
| Fennecs_C2 | 100      |    505.031 μs |         - |         - |    80.16 KB |
| Friflo_C2  | 100      |     18.413 μs |         - |         - |     9.34 KB |
| Theia_C2   | 200      |     64.050 μs |         - |         - |     1.98 KB |
| Arch_C2    | 200      |    141.473 μs |         - |         - |    33.59 KB |
| Fennecs_C2 | 200      |    972.380 μs |         - |         - |   153.91 KB |
| Friflo_C2  | 200      |     36.667 μs |         - |         - |     9.34 KB |
| Theia_C2   | 400      |    119.907 μs |         - |         - |     2.98 KB |
| Arch_C2    | 400      |    289.886 μs |         - |         - |    33.59 KB |
| Fennecs_C2 | 400      |  1,947.356 μs |         - |         - |   294.25 KB |
| Friflo_C2  | 400      |     60.969 μs |         - |         - |     9.34 KB |
| Theia_C2   | 800      |    251.908 μs |         - |         - |     4.98 KB |
| Arch_C2    | 800      |    590.794 μs |         - |         - |    33.59 KB |
| Fennecs_C2 | 800      |  4,043.260 μs |         - |         - |   582.38 KB |
| Friflo_C2  | 800      |    140.725 μs |         - |         - |    25.44 KB |
| Theia_C2   | 1600     |    452.843 μs |         - |         - |    25.45 KB |
| Arch_C2    | 1600     |    830.431 μs |         - |         - |    73.99 KB |
| Fennecs_C2 | 1600     |  4,413.663 μs |         - |         - |  1158.95 KB |
| Friflo_C2  | 1600     |    202.079 μs |         - |         - |    57.86 KB |
| Theia_C2   | 3200     |    895.977 μs |         - |         - |    74.41 KB |
| Arch_C2    | 3200     |  1,079.553 μs |         - |         - |   138.97 KB |
| Fennecs_C2 | 3200     |  5,728.188 μs |         - |         - |  2376.11 KB |
| Friflo_C2  | 3200     |    307.019 μs |         - |         - |   122.61 KB |
| Theia_C2   | 6400     |    459.336 μs |         - |         - |   138.83 KB |
| Arch_C2    | 6400     |  1,442.762 μs |         - |         - |   260.38 KB |
| Fennecs_C2 | 6400     |  4,544.677 μs |         - |         - |  4745.11 KB |
| Friflo_C2  | 6400     |    464.744 μs |         - |         - |    250.7 KB |
| Theia_C2   | 16000    |  4,195.400 μs |         - |         - |   315.81 KB |
| Arch_C2    | 16000    |  3,510.556 μs |         - |         - |   648.91 KB |
| Fennecs_C2 | 16000    |  7,298.127 μs |         - |         - | 11707.83 KB |
| Friflo_C2  | 16000    |    715.606 μs |         - |         - |   506.52 KB |
| Theia_C2   | 32000    |  1,448.525 μs |         - |         - |   639.16 KB |
| Arch_C2    | 32000    |  2,665.821 μs |         - |         - |  1336.59 KB |
| Fennecs_C2 | 32000    | 13,991.406 μs | 1000.0000 | 1000.0000 | 23409.16 KB |
| Friflo_C2  | 32000    |    764.156 μs |         - |         - |  1018.94 KB |
| Theia_C2   | 64000    |  2,899.680 μs |         - |         - |  1267.62 KB |
| Arch_C2    | 64000    |  5,216.207 μs |         - |         - |  2781.99 KB |
| Fennecs_C2 | 64000    | 30,523.000 μs | 2000.0000 | 1000.0000 | 45787.11 KB |
| Friflo_C2  | 64000    |  1,519.043 μs |         - |         - |  2043.31 KB |
| Theia_C2   | 100000   |  4,504.650 μs |         - |         - |  2090.04 KB |
| Arch_C2    | 100000   |  8,290.669 μs |         - |         - |  4568.79 KB |
| Fennecs_C2 | 100000   | 48,064.287 μs | 4000.0000 | 2000.0000 | 74146.08 KB |
| Friflo_C2  | 100000   |  2,439.186 μs |         - |         - |  4091.41 KB |
