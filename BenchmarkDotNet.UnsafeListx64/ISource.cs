namespace BenchmarkDotNet.UnsafeListx64
{
	public interface ISource<out T>
	{
		T Get();
	}
}