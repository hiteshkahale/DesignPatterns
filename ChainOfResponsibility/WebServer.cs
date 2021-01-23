namespace DesignPatterns.ChainOfResponsibility
{
	public class WebServer
	{
		private readonly Handler handler;

		public WebServer(Handler handler)
		{
			this.handler = handler;
		}

		public void Handle(HttpRequest httpRequest)
		{
			handler.Handle(httpRequest);
		}
	}
}
