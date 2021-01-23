using System;

namespace DesignPatterns.ChainOfResponsibility
{
	public class Logger : Handler
	{
		public Logger(Handler next) : base(next) { }

		public override bool CanHandle(HttpRequest httpRequest)
		{
			Console.WriteLine("Logger");
			return true;
		}
	}
}
