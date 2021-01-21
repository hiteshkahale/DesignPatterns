using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Memento
{
	public class History
	{
		private IList<EditorState> states = new List<EditorState>();

		public void Push(EditorState state)
		{
			states.Add(state);
		}

		public EditorState Pop()
		{
			var lastState = states.LastOrDefault();
			if (lastState == null) return null;
			states.Remove(lastState);

			return lastState;
		}
	}
}
