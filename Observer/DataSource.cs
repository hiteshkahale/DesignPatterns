namespace DesignPatterns.Observer
{
	public class DataSource : Observable
	{
		private int _value;

		public int Value
		{
			get => _value;
			set
			{
				_value = value;
				NotifyObservers(_value);
			}
		}
	}
}
