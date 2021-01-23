using System.Collections.Generic;

namespace DesignPatterns.FlyWeight
{
	public class PointIconFactory
	{
		private Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();

		public PointIcon GetPointIcon(PointType pointType)
		{
			if (icons.ContainsKey(pointType)) return icons[pointType];

			var icon = new PointIcon(pointType, null);
			icons.Add(pointType, icon);
			return icon;
		}
	}
}
