using System;

namespace DesignPatterns.Bridge
{
	public class SamsungTV : IDevice
	{
		public void SetChannel(int number)
		{
			Console.WriteLine($"Samsung - set channel to {number}.");
		}

		public void TurnOff()
		{
			Console.WriteLine("Samsung - Turn Off");
		}

		public void TurnOn()
		{
			Console.WriteLine("Samsung - Turn On");
		}
	}
}
