using System.Collections.Generic;

namespace DesignPatterns.FlyWeight
{
	public class PointService
	{
		private PointIconFactory factory;

		public PointService(PointIconFactory factory)
		{
			this.factory = factory;
		}

		public IList<Point> GetPoints()
		{
			var points = new List<Point>();
			var point = new Point(1, 2, factory.GetPointIcon(PointType.CAFE));
			points.Add(point);
			return points;
		}

	}
}
