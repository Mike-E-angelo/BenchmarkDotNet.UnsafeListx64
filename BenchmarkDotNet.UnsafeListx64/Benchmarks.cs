using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNet.UnsafeListx64
{
	public class Benchmarks
	{
		UnsafeList<Poco> _unsafe;

		readonly Poco[] _array, _source;

		public Benchmarks() : this(SourceArray.Default, new Poco[Count.Default]) {}

		public Benchmarks(Poco[] source, Poco[] array)
		{
			_source = source;
			_array  = array;
			AssignArray();
		}

		[IterationSetup]
		public void Setup()
		{
			_unsafe = new UnsafeList<Poco>(Count.Default, 18);
			AssignUnsafeList();
			_unsafe._currentIndex = -1;
		}

		[Benchmark]
		public void AssignArray()
		{
			for (var i = 0; i < _array.Length; ++i)
			{
				_array[i] = _source[i];
			}
		}

		[Benchmark]
		public int SumArray()
		{
			var result = 0;
			for (var i = 0; i < _source.Length; ++i)
			{
				var poco = _array[i];
				result += poco.Field1;
				result += poco.Field2;
				result += poco.Field3;
				result += poco.Field4;
				result += poco.Field5;
				result += poco.Field6;
				result += poco.Field7;
				result += poco.Field8;
				result += poco.Field9;
				result += poco.Field10;
				result += poco.Field11;
				result += poco.Field12;
				result += poco.Field13;
				result += poco.Field14;
				result += poco.Field15;
				result += poco.Field16;
			}

			return result;
		}

		[Benchmark]
		public void AssignUnsafeList()
		{
			for (var i = 0; i < _source.Length; i++)
			{
				_unsafe.Add(_source[i]);
			}
		}

		[Benchmark]
		public int SumUnsafeList()
		{
			var result = 0;

			for (var i = 0; i < _source.Length; ++i)
			{
				var poco = _unsafe[i];
				result += poco.Field1;
				result += poco.Field2;
				result += poco.Field3;
				result += poco.Field4;
				result += poco.Field5;
				result += poco.Field6;
				result += poco.Field7;
				result += poco.Field8;
				result += poco.Field9;
				result += poco.Field10;
				result += poco.Field11;
				result += poco.Field12;
				result += poco.Field13;
				result += poco.Field14;
				result += poco.Field15;
				result += poco.Field16;
			}

			return result;
		}
	}
}