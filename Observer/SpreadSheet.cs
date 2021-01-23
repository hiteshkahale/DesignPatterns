using System;

namespace DesignPatterns.Observer
{
	public class SpreadSheet : IObserver<int>
	{
		public void Update(int value)
		{
			Console.WriteLine($"SpreadSheet updated - {value}.");
		}
	}
}
