namespace DesignPatterns.Decorator
{
	public class CompressedCloudStream : IStream
	{
		private IStream stream;

		public CompressedCloudStream(IStream stream)
		{
			this.stream = stream;
		}

		public void Write(string data)
		{
			var compressed = Compress(data);
			stream.Write(compressed);
		}

		private string Compress(string data)
		{
			return data.Substring(0, 4);
		}
	}
}
