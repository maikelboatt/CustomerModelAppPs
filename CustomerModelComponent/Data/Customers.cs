using System.Collections;

namespace CustomerModelComponent.Data
{
	public class Customers
	{
		ArrayList _customerList = null;


		public Customers()
		{
			_customerList = new ArrayList();
			SeedData();
		}

		public Customer this[int index]
		{
			get { return (Customer) _customerList[index]; }
		}

		public void SeedData()
		{
			this.Add(CustomerObjectFactory.CreateNewCustomerObject("Maikel", "Boatt", "Caftan", 300, 150, true));
			this.Add(CustomerObjectFactory.CreateNewCustomerObject("Sando", "Acquaye", "Maxi", 350, 250, true));
			this.Add(CustomerObjectFactory.CreateNewCustomerObject("Grace", "Andoh-Arthur", "Dress", 150, 50, true));
			this.Add(CustomerObjectFactory.CreateNewCustomerObject("Anne", "Barnes", "Dress", 80, 40, false));
			this.Add(CustomerObjectFactory.CreateNewCustomerObject("Aunty", "Vida", "Dress", 70, 40, false));
		}

		public void Add( Customer customer )
		{
			_customerList.Add(customer);
		}

		public int Find( int id )
		{
			int count = 0;
			foreach (Customer customer in _customerList)
			{
				if (customer.Id == id)
				{
					return count;
				}
				count++;
			}
			return -1;
		}

		public void Update( Customer customer, string firstName, string lastName, string item, decimal price, decimal materialAmount, bool isPremium )
		{
			customer.FirstName = firstName;
			customer.LastName = lastName;
			customer.Item = item;
			customer.Price = price;
			customer.MaterialAmount = materialAmount;
			customer.IsPremium = isPremium;
		}

		public void Delete( int id )
		{
			_customerList.RemoveAt(id);
		}

		public int Count()
		{
			return _customerList.Count;
		}

		public IEnumerator GetEnumerator()
		{
			return _customerList.GetEnumerator();
		}
	}
}
