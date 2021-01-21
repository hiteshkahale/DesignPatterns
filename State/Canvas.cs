namespace DesignPatterns.State
{
	public class Canvas
	{
		public ITool CurrentTool { get; private set; }

		public void SetCurrentTool(ITool tool)
		{
			CurrentTool = tool;
		}

		public void MouseDown()
		{
			CurrentTool?.MouseDown();
		}

		public void MouseUp()
		{
			CurrentTool?.MouseUp();
		}
	}
}
