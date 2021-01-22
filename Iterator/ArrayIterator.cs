using System.Collections;

namespace DesignPatterns.Iterator
{
	public class ArrayIterator : IIterator<string>
	{
		private ArrayList arrayList;
		private int index;

		public ArrayIterator(ArrayList arrayList)
		{
			this.arrayList = arrayList;
		}

		public string Current()
		{
			return arrayList[index] as string;
		}

		public bool HasNext()
		{
			return index < arrayList.Count;
		}

		public void Next()
		{
			index++;
		}
	}
}
