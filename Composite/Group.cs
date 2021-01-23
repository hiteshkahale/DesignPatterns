using System.Collections.Generic;

namespace DesignPatterns.Composite
{
	public class Group : IComponent
	{
		private IList<IComponent> components = new List<IComponent>();

		public void Add(IComponent component)
		{
			components.Add(component);
		}

		public void Render()
		{
			foreach (var c in components)
			{
				c.Render();
			}
		}
	}
}
