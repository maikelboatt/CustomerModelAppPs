using CustomerModelComponent.Data;

namespace CustomerModelComponent.View
{
	public class CustomerDeleteView
	{
		Customers _customers = null;

		public CustomerDeleteView( Customers customers )
		{
			_customers = customers;
		}

		public void RunDeleteView()
		{
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Enter the id of the Customer you wish to delete");

			int id = Convert.ToInt32(Console.ReadLine());

			Console.Clear();

			Console.WriteLine(CustomerOutputText.GetApplicationHeading());


			int index = _customers.Find(id);

			if (index != -1)
			{
				Customer customer = _customers[index];

				Console.WriteLine(CustomerOutputText.GetDeleteMemo(id));

				ConsoleKey consoleKey = Console.ReadKey().Key;

				switch (consoleKey)
				{
					case ConsoleKey.Y:
						_customers.Delete(index);
						break;
				}
			}
			else
			{
				Console.Clear();
				Console.WriteLine(CustomerOutputText.GetApplicationHeading());
				Console.WriteLine(CustomerOutputText.GetNotFoundMessage(id));
				Console.ReadKey();
			}
		}

	}
}
