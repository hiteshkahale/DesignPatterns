namespace DesignPatterns.Observer
{
	public interface IObserver<T>
	{
		void Update(T value);
	}
}
