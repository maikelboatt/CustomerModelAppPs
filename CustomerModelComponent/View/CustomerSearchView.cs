using CustomerModelComponent.Data;

namespace CustomerModelComponent.View
{
	public class CustomerSearchView
	{
		Customers _customers = null;

		public CustomerSearchView( Customers customers )
		{
			_customers = customers;
		}

		public void RunSearchView()
		{
			Console.Clear();

			Console.WriteLine("Search through customers");
			Console.WriteLine("[F] for FirstName, [L] for LastName, [I] for Item [P] for Premium");
			ConsoleKey consoleKey = Console.ReadKey().Key;

			Console.Clear();

			switch (consoleKey)
			{
				case ConsoleKey.F:
					Console.WriteLine("Enter the name to search");

					string firstName = Console.ReadLine();

					foreach (Customer name in _customers)
					{
						if (name.FirstName != firstName)
						{
							continue;
						}
						else if (name.FirstName == firstName)
						{
							Console.WriteLine(CustomerOutputText.GetCustomerReadHeading(name));

							Console.WriteLine($"Id: {name.Id}");
							Console.WriteLine($"First Name: {name.FirstName}");
							Console.WriteLine($"Last Name: {name.LastName}");
							Console.WriteLine($"Item: {name.Item}");
							Console.WriteLine($"Price: {name.Price}");
							Console.WriteLine($"Material Amount: {name.MaterialAmount}");
							Console.WriteLine($"Premium: {name.IsPremium}");
							Console.WriteLine($"Profit: {name.Profit}");
							Console.WriteLine($"Email: {name.Email}");
						}
						Console.ReadKey();
					}
					break;

				case ConsoleKey.L:
					Console.WriteLine("Enter the name to search");

					string lastName = Console.ReadLine();

					foreach (Customer name in _customers)
					{
						if (name.LastName != lastName)
						{
							continue;
						}
						else if (name.LastName == lastName)
						{
							Console.WriteLine(CustomerOutputText.GetCustomerReadHeading(name));

							Console.WriteLine($"Id: {name.Id}");
							Console.WriteLine($"First Name: {name.FirstName}");
							Console.WriteLine($"Last Name: {name.LastName}");
							Console.WriteLine($"Item: {name.Item}");
							Console.WriteLine($"Price: {name.Price}");
							Console.WriteLine($"Material Amount: {name.MaterialAmount}");
							Console.WriteLine($"Premium: {name.IsPremium}");
							Console.WriteLine($"Profit: {name.Profit}");
							Console.WriteLine($"Email: {name.Email}");
						}
						Console.ReadKey();
					}
					break;

				case ConsoleKey.I:
					Console.WriteLine("Enter the name to search");

					string item = Console.ReadLine();

					foreach (Customer name in _customers)
					{
						if (name.Item != item)
						{
							continue;
						}
						else if (name.Item == item)
						{
							Console.WriteLine(CustomerOutputText.GetCustomerReadHeading(name));

							Console.WriteLine($"Id: {name.Id}");
							Console.WriteLine($"First Name: {name.FirstName}");
							Console.WriteLine($"Last Name: {name.LastName}");
							Console.WriteLine($"Item: {name.Item}");
							Console.WriteLine($"Price: {name.Price}");
							Console.WriteLine($"Material Amount: {name.MaterialAmount}");
							Console.WriteLine($"Premium: {name.IsPremium}");
							Console.WriteLine($"Profit: {name.Profit}");
							Console.WriteLine($"Email: {name.Email}");
						}
						Console.ReadKey();
					}
					break;

				case ConsoleKey.P:
					Console.WriteLine("Enter the field to search");

					string premium = Console.ReadLine();

					bool updated = Convert.ToBoolean(premium);
					foreach (Customer name in _customers)
					{
						if (name.IsPremium != updated)
						{
							continue;
						}
						else if (name.IsPremium == updated)
						{
							Console.WriteLine(CustomerOutputText.GetCustomerReadHeading(name));

							Console.WriteLine($"Id: {name.Id}");
							Console.WriteLine($"First Name: {name.FirstName}");
							Console.WriteLine($"Last Name: {name.LastName}");
							Console.WriteLine($"Item: {name.Item}");
							Console.WriteLine($"Price: {name.Price}");
							Console.WriteLine($"Material Amount: {name.MaterialAmount}");
							Console.WriteLine($"Premium: {name.IsPremium}");
							Console.WriteLine($"Profit: {name.Profit}");
							Console.WriteLine($"Email: {name.Email}");
						}
						Console.ReadKey();
					}
					break;
			}
		}
	}
}
