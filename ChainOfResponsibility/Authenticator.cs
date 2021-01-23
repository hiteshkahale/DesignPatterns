using System;

namespace DesignPatterns.ChainOfResponsibility
{
	public class Authenticator : Handler
	{
		public Authenticator(Handler next) : base(next) { }

		public override bool CanHandle(HttpRequest httpRequest)
		{
			var isValid = httpRequest.UserName == "hitesh" && httpRequest.Password == "abc";
			if (isValid) Console.WriteLine("Authenticated");

			return isValid;
		}
	}
}
