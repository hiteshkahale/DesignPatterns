namespace DesignPatterns.ChainOfResponsibility
{
	public class HttpRequest
	{
		public string UserName { get; private set; }
		public string Password { get; private set; }

		public HttpRequest(string userName, string password)
		{
			UserName = userName;
			Password = password;
		}
	}
}
