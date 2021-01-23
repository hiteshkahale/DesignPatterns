namespace DesignPatterns.ChainOfResponsibility
{
	public abstract class Handler
	{
		private Handler next;

		public Handler(Handler handler)
		{
			next = handler;
		}

		public void Handle(HttpRequest httpRequest)
		{
			if (!CanHandle(httpRequest)) return;

			next?.Handle(httpRequest);
		}

		public abstract bool CanHandle(HttpRequest httpRequest);
	}
}
