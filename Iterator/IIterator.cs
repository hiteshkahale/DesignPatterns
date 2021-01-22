namespace DesignPatterns.Iterator
{
	public interface IIterator<T>
	{
		T Current();
		void Next();
		bool HasNext();
	}
}
