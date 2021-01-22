using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
	public class BrowseHistory
	{
		//private List<string> urls = new List<string>();
		private ArrayList urls = new ArrayList();

		public void Push(string url)
		{
			//urls.Add(url);
			urls.Add(url);
		}

		public IIterator<string> GetIterator()
		{
			// return new ListIterator(urls);
			return new ArrayIterator(urls);
		}

	}
}
