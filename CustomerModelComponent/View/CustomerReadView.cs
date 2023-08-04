using CustomerModelComponent.Data;

namespace CustomerModelComponent.View
{
	public class CustomerReadView
	{
		Customers _customers = null;

		public CustomerReadView( Customers customers )
		{
			_customers = customers;
		}

		public void RunReadView()
		{

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Enter the id of the Customer you wish to view");

			int id = Convert.ToInt32(Console.ReadLine());

			Console.Clear();

			Console.WriteLine(CustomerOutputText.GetApplicationHeading());


			int index = _customers.Find(id);

			if (index != -1)
			{

				Customer customer = _customers[index];

				Console.WriteLine(CustomerOutputText.GetCustomerReadHeading(customer));

				Console.WriteLine($"Id: {customer.Id}");
				Console.WriteLine($"First Name: {customer.FirstName}");
				Console.WriteLine($"Last Name: {customer.LastName}");
				Console.WriteLine($"Item: {customer.Item}");
				Console.WriteLine($"Price: {customer.Price}");
				Console.WriteLine($"Material Amount: {customer.MaterialAmount}");
				Console.WriteLine($"Premium: {customer.IsPremium}");
				Console.WriteLine($"Profit: {customer.Profit}");
				Console.WriteLine($"Email: {customer.Email}");
			}
			else
			{
				Console.WriteLine(CustomerOutputText.GetNotFoundMessage(id));
			}
			Console.ReadKey();


		}
	}

}
