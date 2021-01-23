using System.Collections.Generic;

namespace DesignPatterns.Visitor
{
	public class HtmlDocument
	{
		private IList<IHtmlNode> htmlNodes = new List<IHtmlNode>();

		public void Add(IHtmlNode node)
		{
			htmlNodes.Add(node);
		}

		public void Execute(IOperation operation)
		{
			foreach (var node in htmlNodes)
			{
				node.Execute(operation);
			}
		}

	}
}
