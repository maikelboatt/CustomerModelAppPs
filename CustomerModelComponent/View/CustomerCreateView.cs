using CustomerModelComponent.Data;
using System.Globalization;

namespace CustomerModelComponent.View
{
	public class CustomerCreateView
	{
		Customers _customers = null;

		public CustomerCreateView( Customers customers )
		{
			_customers = customers;
		}

		public void RunCreateView()
		{
			Console.Clear();

			Console.WriteLine(CustomerOutputText.GetApplicationHeading());

			Console.WriteLine();

			Console.WriteLine(CustomerOutputText.GetCreateHeading());

			Console.Write("First Name: ");
			string firstName = Console.ReadLine();

			Console.Write("Last Name: ");
			string lastName = Console.ReadLine();

			Console.Write("Item: ");
			string item = Console.ReadLine();

			Console.Write("Price: ");
			decimal price = decimal.Parse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

			Console.Write("Material: ");
			decimal material = decimal.Parse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

			Console.Write("Premium (true/false): ");
			bool premium = Convert.ToBoolean(Console.ReadLine());

			Console.WriteLine();
			Console.WriteLine("Please press the [S] key to save the new employee record to the system or any other key to cancel.");

			ConsoleKey consoleKey = Console.ReadKey().Key;

			if (consoleKey == ConsoleKey.S)
			{
				_customers.Add(CustomerObjectFactory.CreateNewCustomerObject(firstName, lastName, item, price, material, premium));
			}

		}
	}
}
