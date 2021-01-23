namespace DesignPatterns.Visitor
{
	public interface IHtmlNode
	{
		void Execute(IOperation operation);
	}
}
