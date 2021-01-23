using System;

namespace DesignPatterns.Mediator
{
	public class ArticlesDialogBox
	{

		private ListBox articlesListBox = new ListBox();
		private TextBox titleTextBox = new TextBox();
		private Button saveButton = new Button();

		public ArticlesDialogBox()
		{
			articlesListBox.AddEventHandler(ArticleSelected);
			titleTextBox.AddEventHandler(TitleChanged);
		}

		public void SimulateUserInteraction()
		{
			articlesListBox.Selection = "Article 1";
			//titleTextBox.Content = "";
			titleTextBox.Content = "Article 1";
			Console.WriteLine($"TextBox: {titleTextBox.Content}");
			Console.WriteLine($"Button: {saveButton.IsEnabled}");
		}

		private void TitleChanged()
		{
			saveButton.IsEnabled = !string.IsNullOrEmpty(titleTextBox.Content);
		}

		private void ArticleSelected()
		{
			titleTextBox.Content = articlesListBox.Selection;
			saveButton.IsEnabled = true;
		}

	}
}
