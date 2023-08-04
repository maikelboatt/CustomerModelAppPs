using CustomerModelComponent.Data;
using CustomerModelComponent.View;

namespace CustomerModelAppPs
{
	internal class Program
	{
		static void Main( string[] args )
		{
			bool endApplication = false;

			Customers customers = new();

			CustomerRecordsView customerRecordsView = CustomerObjectFactory.CustomerRecordsViewObject(customers);

			while (!endApplication)
			{
				Console.Clear();

				Console.WriteLine(CustomerOutputText.GetApplicationHeading());

				customerRecordsView.RunRecordsView();

				Console.WriteLine();
				Console.WriteLine();

				Console.WriteLine(CustomerOutputText.GetInstructions());

				ConsoleKey instructionKey = Console.ReadKey().Key;

				switch (instructionKey)
				{
					case ConsoleKey.C:
						CustomerCreateView _customerCreateView = CustomerObjectFactory.CustomerCreateViewObject(customers);
						_customerCreateView.RunCreateView();
						break;

					case ConsoleKey.R:
						CustomerReadView _customerReadView = CustomerObjectFactory.CustomerReadViewObject(customers);
						_customerReadView.RunReadView();
						break;

					case ConsoleKey.U:
						CustomerUpdateView _customerUpdateView = CustomerObjectFactory.CustomerUpdateViewObject(customers);
						_customerUpdateView.RunUpdateView();
						break;

					case ConsoleKey.D:
						CustomerDeleteView _customerDeleteView = CustomerObjectFactory.CustomerDeleteViewObject(customers);
						_customerDeleteView.RunDeleteView();
						break;

					case ConsoleKey.T:
						CustomerSearchView _customerSearchView = CustomerObjectFactory.CustomerSearchViewObject(customers);
						_customerSearchView.RunSearchView();
						break;

					default:
						endApplication = true;
						Console.ReadKey();
						break;
				}

			}
		}
	}
}