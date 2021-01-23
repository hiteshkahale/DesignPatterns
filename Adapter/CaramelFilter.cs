using DesignPatterns.Adapter.Lib;

namespace DesignPatterns.Adapter
{
	public class CaramelFilter : Caramel, IFilter
	{
		public void Apply(Image image)
		{
			Init();
			Render(image);
		}
	}
}
