using System;

namespace DesignPatterns.Strategy
{
	public class PngCompressor : ICompressor
	{
		public void Compress()
		{
			Console.WriteLine("Compressing using PNG."); ;
		}
	}
}
