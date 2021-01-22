using System;

namespace DesignPatterns.Template
{
	public class GenerateReportTask : Task
	{
		protected override void DoExecute()
		{
			Console.WriteLine("Generate Report");
		}
	}
}
