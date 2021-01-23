using System;

namespace DesignPatterns.FlyWeight
{
	public class PointIcon
	{
		public PointType PointType { get; private set; }
		public Byte[] Icon { get; private set; }

		public PointIcon(PointType pointType, Byte[] icon)
		{
			PointType = pointType;
			Icon = icon;
		}
	}
}
