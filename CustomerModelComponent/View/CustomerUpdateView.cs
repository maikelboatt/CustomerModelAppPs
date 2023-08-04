using CustomerModelComponent.Data;
using System.Globalization;

namespace CustomerModelComponent.View
{
	public class CustomerUpdateView
	{
		Customers _customers = null;

		public CustomerUpdateView( Customers customers )
		{
			_customers = customers;
		}

		public void RunUpdateView()
		{
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Enter the id of the Customer you wish to update");

			int id = Convert.ToInt32(Console.ReadLine());

			Console.Clear();

			Console.WriteLine(CustomerOutputText.GetApplicationHeading());


			int index = _customers.Find(id);

			if (index != -1)
			{
				Customer customer = _customers[index];

				Console.WriteLine(CustomerOutputText.GetUpdateHeading(customer));
				Console.WriteLine(CustomerOutputText.GetUpdateViewAdditionalInstructions(customer));


				Console.Write($"First Name({customer.FirstName}): ");
				string firstName = Console.ReadLine();

				Console.Write($"Last Name({customer.FirstName}): ");
				string lastName = Console.ReadLine();

				Console.Write($"Item ({customer.FirstName}): ");
				string item = Console.ReadLine();

				Console.Write($"Price {customer.FirstName}): ");
				string price = Console.ReadLine();

				Console.Write($"Material Amount({customer.FirstName}): ");
				string materialAmount = Console.ReadLine();

				Console.Write($" Premium({customer.FirstName}): ");
				string premium = Console.ReadLine();

				_customers.Update(customer,
					(String.IsNullOrEmpty(firstName) ? customer.FirstName : firstName),
					(String.IsNullOrEmpty(lastName) ? customer.LastName : lastName),
					(String.IsNullOrEmpty(item) ? customer.Item : item),
					(String.IsNullOrWhiteSpace(price) ? customer.Price : Decimal.Parse(price, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture)),
					(String.IsNullOrWhiteSpace(materialAmount) ? customer.MaterialAmount : Decimal.Parse(materialAmount, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture)),
					(String.IsNullOrEmpty(premium) ? customer.IsPremium : Convert.ToBoolean(premium))
					);

			}
			else
			{
				Console.WriteLine(CustomerOutputText.GetNotFoundMessage(id));
				Console.ReadKey();
			}
		}
	}
}
