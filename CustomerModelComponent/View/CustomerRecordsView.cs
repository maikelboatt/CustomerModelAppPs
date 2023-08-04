using CustomerModelComponent.Data;

namespace CustomerModelComponent.View
{
	public class CustomerRecordsView
	{
		private Customers _customers = null;

		public CustomerRecordsView( Customers customers )
		{
			_customers = customers;
		}

		public void RunRecordsView()
		{
			Console.WriteLine(CustomerOutputText.GetColumnHeadings());
			Console.WriteLine();

			foreach (Customer customer in _customers)
			{
				Console.WriteLine(customer.GetCustomerInformation());

			}

		}
	}
}
