namespace DesignPatterns.Facade
{
	public class Message
	{
		public string Content { get; set; }

		public Message(string message)
		{
			Content = message;
		}
	}
}
