namespace DesignPatterns.Command
{
	public class Button
	{
		private ICommand command;

		public Button(ICommand command)
		{
			this.command = command;
		}

		public void Click()
		{
			command.Execute();
		}
	}
}
