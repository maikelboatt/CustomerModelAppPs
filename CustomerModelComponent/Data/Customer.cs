namespace CustomerModelComponent.Data
{
	public class Customer
	{
		private static int _nextId = 0;
		private int _id = 0;

		private string _firstName = "";
		private string _lastName = "";
		private string _item = "";
		private decimal _price = 0;
		private decimal _materialAmount = 0;
		private bool _isPremium = false;

		public Customer()
		{
			_nextId++;
			_id = _nextId;
		}

		public Customer( string firstName, string lastName, string item, decimal price, decimal materialAmount, bool isPremium )
		{
			_firstName = firstName;
			_lastName = lastName;
			_item = item;
			_price = price;
			_materialAmount = materialAmount;
			_isPremium = isPremium;
		}

		public int Id { get { return _id; } }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Item { get; set; }
		public decimal Price { get; set; }
		public decimal MaterialAmount { get; set; }
		public bool IsPremium { get; set; }

		public decimal Profit => (decimal) Price - MaterialAmount;
		public string Email => EmailGenerator();


		public string EmailGenerator()
		{
			const string domain = "@gmail.com";
			string pre = FirstName[..2];
			pre += LastName;
			return $"{pre}{domain}".ToLower();
		}

		public string GetCustomerInformation()
		{
			string custInfo = $"{Id.ToString().PadRight(6)}\t{FirstName.PadRight(15)}\t{LastName.PadRight(15)}\t{Item.PadRight(15)}\t{Price.ToString().PadRight(7)}\t{MaterialAmount.ToString().PadRight(15)}\t{IsPremium.ToString().PadRight(6)}\t{Profit.ToString().PadRight(6)}\t{Email.PadRight(15)}\t";

			return custInfo;
		}

	}
}
