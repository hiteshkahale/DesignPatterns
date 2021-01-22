using System;

namespace DesignPatterns.Template
{
	public class TransferMoneyTask : Task
	{
		protected override void DoExecute()
		{
			Console.WriteLine("Transferring money");
		}
	}
}
