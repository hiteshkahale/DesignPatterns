using System;

namespace DesignPatterns.Facade
{
	public class NotificationServer
	{
		public Connection Connect(string ipAddress)
		{
			return new Connection();
		}

		public AuthToken Authenticate(string appId, string key)
		{
			return new AuthToken();
		}

		public void Send(AuthToken token, Message message, string target)
		{
			Console.WriteLine($"Send message {message.Content}");
		}
	}
}
