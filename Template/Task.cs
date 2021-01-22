namespace DesignPatterns.Template
{
	public abstract class Task
	{
		private AuditTrail auditTrail;

		public Task()
		{
			auditTrail = new AuditTrail();
		}

		public void Execute()
		{
			auditTrail.Record();

			DoExecute();
		}

		protected abstract void DoExecute();
	}
}
