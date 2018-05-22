namespace BenchmarkDotNet.UnsafeListx64
{
	sealed class SourceArray : Source<Poco[]>
	{
		public static SourceArray Default { get; } = new SourceArray();

		public SourceArray() : this(new Poco[Count.Default]) {}

		public SourceArray(Poco[] instance) : base(instance)
		{
			for (var i = 0; i < instance.Length; ++i)
			{
				instance[i] = Program.CreatePoco(i);
			}
		}
	}
}