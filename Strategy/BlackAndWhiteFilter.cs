using System;

namespace DesignPatterns.Strategy
{
	public class BlackAndWhiteFilter : IFilter
	{
		public void Apply()
		{
			Console.WriteLine("Applying Black and White filter.");
		}
	}
}
