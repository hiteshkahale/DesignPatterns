using System;

namespace DesignPatterns.State
{
	public class SelectionTool : ITool
	{
		public void MouseDown()
		{
			Console.WriteLine("Selection Icon");
		}

		public void MouseUp()
		{
			Console.WriteLine("Draw a dashed rectangle");
		}
	}
}
