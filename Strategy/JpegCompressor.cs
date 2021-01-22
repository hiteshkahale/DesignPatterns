using System;

namespace DesignPatterns.Strategy
{
	public class JpegCompressor : ICompressor
	{
		public void Compress()
		{
			Console.WriteLine("Compressing using JPEG .");
		}
	}
}
