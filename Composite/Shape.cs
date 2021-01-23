using System;

namespace DesignPatterns.Composite
{
	public class Shape : IComponent
	{
		public void Render()
		{
			Console.WriteLine("Render Shape");
		}
	}
}
