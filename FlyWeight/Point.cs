using System;

namespace DesignPatterns.FlyWeight
{
	public class Point
	{
		private int x;
		private int y;
		PointIcon pointIcon;

		public Point(int x, int y, PointIcon icon)
		{
			this.x = x;
			this.y = y;
			pointIcon = icon;
		}

		public void Draw()
		{
			Console.WriteLine($"{pointIcon.PointType} at {x} {y}.");
		}
	}
}
