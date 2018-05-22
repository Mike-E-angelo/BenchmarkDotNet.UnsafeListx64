This is based off [the wonderful article/series](https://blog.adamfurmanek.pl/2016/04/30/custom-memory-allocation-in-c-part-2/) by [@furmanekadam](https://twitter.com/furmanekadam) that explores using unsafe code to allocate memory.  This repository features x64 version of this code.  Do NOT try to run this on x86!

[Traditional/Stopwatch Version Here](https://github.com/Mike-EEE/UnsafeListx64)


``` ini

BenchmarkDotNet=v0.10.14.538-nightly, OS=Windows 10.0.17134, VM=Hyper-V
Intel Core i7-4820K CPU 3.70GHz (Haswell), 1 CPU, 8 logical and 8 physical cores
.NET Core SDK=2.1.300-rc1-008673
  [Host]     : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT
  Job-OYGPGM : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|           Method |      Mean |     Error |    StdDev |
|----------------- |----------:|----------:|----------:|
|      AssignArray |  2.724 us | 0.0571 us | 0.0722 us |
|         SumArray |  3.925 us | 0.0000 us | 0.0000 us |
| AssignUnsafeList | 35.120 us | 6.7128 us | 6.8936 us |
|    SumUnsafeList |  5.710 us | 0.1690 us | 0.3453 us |
