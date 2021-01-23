using System.Collections.Generic;

namespace DesignPatterns.Observer
{
	public class Observable
	{
		private IList<IObserver<int>> observerList = new List<IObserver<int>>();
		
		public void AddObserver(IObserver<int> observer)
		{
			observerList.Add(observer);
		}

		public void RemoveObserver(IObserver<int> observer)
		{
			observerList.Remove(observer);
		}

		public void NotifyObservers(int value)
		{
			foreach (var o in observerList) o.Update(value);
		}
	}
}
