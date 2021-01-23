using System;

namespace DesignPatterns.Bridge
{
	public class SonyTV : IDevice
	{
		public void SetChannel(int number)
		{
			Console.WriteLine($"Sony - set channel to {number}.");
		}

		public void TurnOff()
		{
			Console.WriteLine("Sony - Turn Off");
		}

		public void TurnOn()
		{
			Console.WriteLine("Sony - Turn On");
		}
	}
}
