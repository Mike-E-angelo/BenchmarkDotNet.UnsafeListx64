using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace BenchmarkDotNet.UnsafeListx64
{
	sealed class Program
	{
		static void Main()
		{
			BenchmarkRunner.Run<Benchmarks>(ManualConfig.Create(DefaultConfig.Instance)
			                                            .With(Job.Default.WithUnrollFactor(1).WithInvocationCount(1)));
		}

		public static Poco CreatePoco(int i) => new Poco
		{
			Field1  = i,
			Field2  = i - 1,
			Field3  = i - 2,
			Field4  = i - 3,
			Field5  = i - 4,
			Field6  = i - 5,
			Field7  = i - 6,
			Field8  = i - 7,
			Field9  = i - 7,
			Field10 = i - 6,
			Field11 = i - 5,
			Field12 = i - 4,
			Field13 = i - 3,
			Field14 = i - 2,
			Field15 = i - 1,
			Field16 = i
		};
	}
}