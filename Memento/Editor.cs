namespace DesignPatterns.Memento
{
	public class Editor
	{
		public string Content { get; private set; }

		public void SetContent(string content)
		{
			Content = content;
		}

		public EditorState CreateState()
		{
			return new EditorState(Content);
		}

		public void Restore(EditorState state)
		{
			Content = state.Content;
		}
	}
}
