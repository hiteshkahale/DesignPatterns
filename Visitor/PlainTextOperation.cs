using System;

namespace DesignPatterns.Visitor
{
	public class PlainTextOperation : IOperation
	{
		public void Apply(HeadingNode heading)
		{
			Console.WriteLine("Text Heading");
		}

		public void Apply(AnchorNode anchor)
		{
			Console.WriteLine("Text Anchor");
		}
	}
}
