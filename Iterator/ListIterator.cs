using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Iterator
{
	public class ListIterator : IIterator<string>
	{
		private readonly IList<string> list;
		private int index;

		public ListIterator(IList<string> list)
		{
			this.list = list;
		}

		public string Current()
		{
			return list[index];
		}

		public bool HasNext()
		{
			return (index < list.Count());
		}

		public void Next()
		{
			index++;
		}
	}
}
