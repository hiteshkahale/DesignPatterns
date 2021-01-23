using System;

namespace DesignPatterns.Adapter
{
	public class VividFilter : IFilter
	{
		public void Apply(Image image)
		{
			Console.WriteLine("Applying Vivid Filter.");
		}
	}
}
