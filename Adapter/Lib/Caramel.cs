using System;

namespace DesignPatterns.Adapter.Lib
{
	public class Caramel
	{
		public void Init() { }

		public void Render(Image image)
		{
			Console.WriteLine("Applying Caramel.");
		}
	}
}
