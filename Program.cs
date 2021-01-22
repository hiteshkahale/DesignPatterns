using DesignPatterns.Command;
using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using DesignPatterns.State;
using DesignPatterns.Strategy;
using DesignPatterns.Template;
using System;

namespace DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			// ExecuteMemento();
			// ExecuteState();
			// ExecuteIterator();
			// ExecuteStrategy();
			// ExecuteTemplate();
			ExecuteCommand();
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

		#region Iterator Design Pattern

		private static void ExecuteIterator()
		{
			var history = new BrowseHistory();
			history.Push("www.google.com");
			history.Push("www.facebook.com");
			history.Push("www.twitter.com");
			var iterator = history.GetIterator();

			while (iterator.HasNext())
			{
				Console.WriteLine(iterator.Current());
				iterator.Next();
			}
		}

		#endregion

		#region Strategy Design Pattern

		private static void ExecuteStrategy()
		{
			var imageStorage = new ImageStorage();
			imageStorage.Store("a", new JpegCompressor(), new BlackAndWhiteFilter());
			imageStorage.Store("b", new PngCompressor(), new BlackAndWhiteFilter());
		}

		#endregion

		#region Template Method Desing Pattern

		private static void ExecuteTemplate()
		{
			var generateReport = new GenerateReportTask();
			generateReport.Execute();

			var transferMoney = new TransferMoneyTask();
			transferMoney.Execute();
		}

		#endregion

		#region

		private static void ExecuteCommand()
		{
			var customerService = new CustomerService();
			var addCustomerCommand = new AddCustomerCommand(customerService);
			var button = new Button(addCustomerCommand);

			button.Click();
		}

		#endregion
	}
}