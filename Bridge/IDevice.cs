namespace DesignPatterns.Bridge
{
	public interface IDevice
	{
		void TurnOff();
		void TurnOn();
		void SetChannel(int number);
	}
}
