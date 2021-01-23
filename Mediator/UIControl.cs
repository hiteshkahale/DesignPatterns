using System;

namespace DesignPatterns.Mediator
{
	public abstract class UIControl
	{
		private Action handler;
		public void AddEventHandler(Action handler)
		{
			this.handler = handler;
		}

		protected void NotifyEventHandlers()
		{
			handler?.Invoke();
		}
	}
}
