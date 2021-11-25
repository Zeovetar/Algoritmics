Input data:


   X:    Y:
1. 0     0
2. 1     5
3. 2     10

Output data:

Intel Core i7-9700 CPU 3.00GHz, 1 CPU, 8 logical and 8 physical cores
.NET SDK=5.0.401
  [Host]     : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT


|                  Method | AIdx | BIdx |      Mean |     Error |    StdDev |
|------------------------ |----- |----- |----------:|----------:|----------:|
| floatPointDistanceClass |    0 |    0 |  2.107 ns | 0.0345 ns | 0.0306 ns |
|      floatPointDistance |    0 |    0 | 11.937 ns | 0.2073 ns | 0.1939 ns |
|      PointDistanceShort |    0 |    0 |  9.120 ns | 0.1112 ns | 0.0986 ns |
|     PointDistanceDouble |    0 |    0 | 12.243 ns | 0.1301 ns | 0.1217 ns |
| floatPointDistanceClass |    0 |    1 |  1.948 ns | 0.0162 ns | 0.0135 ns |
|      floatPointDistance |    0 |    1 | 12.013 ns | 0.2627 ns | 0.2920 ns |
|      PointDistanceShort |    0 |    1 |  9.190 ns | 0.1557 ns | 0.1381 ns |
|     PointDistanceDouble |    0 |    1 | 13.382 ns | 0.1877 ns | 0.1664 ns |
| floatPointDistanceClass |    0 |    2 |  1.976 ns | 0.0406 ns | 0.0379 ns |
|      floatPointDistance |    0 |    2 | 11.770 ns | 0.1543 ns | 0.1443 ns |
|      PointDistanceShort |    0 |    2 |  9.128 ns | 0.1261 ns | 0.1179 ns |
|     PointDistanceDouble |    0 |    2 | 13.346 ns | 0.1124 ns | 0.1051 ns |
| floatPointDistanceClass |    1 |    0 |  2.106 ns | 0.0562 ns | 0.0526 ns |
|      floatPointDistance |    1 |    0 | 12.001 ns | 0.0705 ns | 0.0659 ns |
|      PointDistanceShort |    1 |    0 |  9.234 ns | 0.0895 ns | 0.0794 ns |
|     PointDistanceDouble |    1 |    0 | 13.530 ns | 0.1521 ns | 0.1348 ns |
| floatPointDistanceClass |    1 |    1 |  2.010 ns | 0.0632 ns | 0.0620 ns |
|      floatPointDistance |    1 |    1 | 11.834 ns | 0.1550 ns | 0.1450 ns |
|      PointDistanceShort |    1 |    1 |  9.121 ns | 0.0832 ns | 0.0738 ns |
|     PointDistanceDouble |    1 |    1 | 12.215 ns | 0.0761 ns | 0.0712 ns |
| floatPointDistanceClass |    1 |    2 |  1.987 ns | 0.0305 ns | 0.0271 ns |
|      floatPointDistance |    1 |    2 | 11.813 ns | 0.1634 ns | 0.1529 ns |
|      PointDistanceShort |    1 |    2 |  9.135 ns | 0.0858 ns | 0.0802 ns |
|     PointDistanceDouble |    1 |    2 | 13.388 ns | 0.1205 ns | 0.1127 ns |
| floatPointDistanceClass |    2 |    0 |  1.985 ns | 0.0440 ns | 0.0411 ns |
|      floatPointDistance |    2 |    0 | 11.801 ns | 0.1216 ns | 0.1138 ns |
|      PointDistanceShort |    2 |    0 |  9.141 ns | 0.1549 ns | 0.1449 ns |
|     PointDistanceDouble |    2 |    0 | 13.380 ns | 0.0976 ns | 0.0913 ns |
| floatPointDistanceClass |    2 |    1 |  1.969 ns | 0.0340 ns | 0.0302 ns |
|      floatPointDistance |    2 |    1 | 11.841 ns | 0.1480 ns | 0.1384 ns |
|      PointDistanceShort |    2 |    1 |  9.159 ns | 0.1047 ns | 0.0928 ns |
|     PointDistanceDouble |    2 |    1 | 13.404 ns | 0.1419 ns | 0.1327 ns |
| floatPointDistanceClass |    2 |    2 |  1.969 ns | 0.0457 ns | 0.0428 ns |
|      floatPointDistance |    2 |    2 | 11.847 ns | 0.1078 ns | 0.1008 ns |
|      PointDistanceShort |    2 |    2 |  9.136 ns | 0.0994 ns | 0.0930 ns |
|     PointDistanceDouble |    2 |    2 | 12.251 ns | 0.1276 ns | 0.1194 ns |