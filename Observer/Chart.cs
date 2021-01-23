using System;

namespace DesignPatterns.Observer
{
	public class Chart : IObserver<int>
	{
		public void Update(int value)
		{
			Console.WriteLine($"Char updated - {value}.");
		}
	}
}
