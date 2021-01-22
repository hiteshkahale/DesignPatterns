namespace DesignPatterns.Command
{
	public class AddCustomerCommand : ICommand
	{
		private readonly CustomerService customerService;

		public AddCustomerCommand(CustomerService customerService)
		{
			this.customerService = customerService;
		}
		public void Execute()
		{
			customerService.AddCustomer();
		}
	}
}
