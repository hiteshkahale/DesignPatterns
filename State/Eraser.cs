using System;

namespace DesignPatterns.State
{
	public class Eraser : ITool
	{
		public void MouseDown()
		{
			Console.WriteLine("Eraser icon");
		}

		public void MouseUp()
		{
			Console.WriteLine("Erase something");
		}
	}
}
