using DesignPatterns.Memento;
using DesignPatterns.State;
using System;

namespace DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			// ExecuteMemento();
			ExecuteState();
			Console.ReadLine();
		}

		#region Memento Design Pattern

		private static void ExecuteMemento()
		{
			var editor = new Editor();
			var history = new History();

			editor.SetContent("a");
			history.Push(editor.CreateState());

			editor.SetContent("b");
			history.Push(editor.CreateState());

			editor.SetContent("c");
			// Undo to previous state
			editor.Restore(history.Pop());

			Console.WriteLine(editor.Content);
		}

		#endregion

		#region State Design Pattern

		private static void ExecuteState()
		{
			var canvas = new Canvas();
			//canvas.SetCurrentTool(new BrushTool());
			canvas.SetCurrentTool(new Eraser());
			canvas.MouseDown();
			canvas.MouseUp();
		}

		#endregion
	}
}