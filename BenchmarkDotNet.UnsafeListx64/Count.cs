namespace BenchmarkDotNet.UnsafeListx64
{
	sealed class Count : Source<int>
	{
		public static Count Default { get; } = new Count();

		Count() : base(1000) {}
	}
}