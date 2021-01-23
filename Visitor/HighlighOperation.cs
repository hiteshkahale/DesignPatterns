using System;

namespace DesignPatterns.Visitor
{
	public class HighlighOperation : IOperation
	{
		public void Apply(HeadingNode heading)
		{
			Console.WriteLine("Highlight heading");
		}

		public void Apply(AnchorNode anchor)
		{
			Console.WriteLine("Highlight anchor");
		}
	}
}
