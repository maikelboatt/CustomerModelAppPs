using CustomerModelComponent.Data;

namespace CustomerModelComponent.View
{
	public static class CustomerOutputText
	{
		public static string GetColumnHeadings()
		{

			string Id = "Id";
			string FirstName = "FirstName";
			string LastName = "LastName";
			string Item = "Item";
			string Price = "Price";
			string MaterialAmount = "Material";
			string IsPremium = "Premium";
			string Profit = "Profit";
			string Email = "Email";

			string heading = $"{Id.PadRight(6)}\t{FirstName.PadRight(15)}\t{LastName.PadRight(15)}\t{Item.PadRight(15)}\t{Price,-7}\t{MaterialAmount.PadRight(15)}\t{IsPremium.PadRight(6)}\t{Profit.PadRight(6)}\t{Email.PadRight(15)}\n";
			heading += $"{new string('_', 6)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 7)}\t{new string('_', 15)}\t{new string('_', 6)}\t{new string('_', 6)}\t{new string('_', 15)}";

			return $"{heading}";
		}

		public static string GetApplicationHeading()
		{
			string heading = "Nessa Coutures Customer Entry Application\n";
			string underline = GetUnderlineForHeading(heading);
			return $"{heading}{underline}\n\n";
		}

		private static string GetUnderlineForHeading( string heading )
		{
			return new string('_', heading.Length - 1);
		}

		public static string GetInstructions()
		{
			return "[C] Create, [R] Read, [U] Update, [D] Delete, [T] Search. Press any other key to end session";

		}

		public static string GetCreateHeading()
		{
			string heading = "Add Customer\n";
			string underline = GetUnderlineForHeading(heading);
			return $"{heading}{underline}\n";
		}

		public static string GetCustomerReadHeading( Customer customer )
		{
			string heading = $"Customer details for {customer.FirstName} {customer.LastName} Id: {customer.Id}\n";
			string underline = GetUnderlineForHeading(heading);
			return $"{heading}{underline}\n";
		}

		public static string GetNotFoundMessage( int id )
		{
			return $"Could not find employee with Id({id}). Please press any key to return to the main view...";
		}

		public static string GetUpdateHeading( Customer customer )
		{
			string heading = $"Update Employee Details for {customer.FirstName} {customer.LastName} Id: {customer.Id}\n";
			string underline = GetUnderlineForHeading(heading);

			return $"{heading}{underline}\n\n";
		}

		public static string GetUpdateViewAdditionalInstructions( Customer customer )
		{
			return "Note a blank field will leave relevant field unmodified\n";
		}

		public static string GetDeleteMemo( int id )
		{
			return $"Are you sure you want to delete customer with Id ({id}) (Y/N)";
		}

	}
}
