using System;

namespace DesignPatterns.ChainOfResponsibility
{
	public class Compressor : Handler
	{
		public Compressor(Handler next) : base(next) { }

		public override bool CanHandle(HttpRequest httpRequest)
		{
			Console.WriteLine("Compressor");
			return true;
		}
	}
}
