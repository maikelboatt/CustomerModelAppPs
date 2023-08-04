using CustomerModelComponent.View;

namespace CustomerModelComponent.Data
{
	public static class CustomerObjectFactory
	{

		private static CustomerCreateView _customerCreateView = null;
		private static CustomerReadView _customerReadView = null;
		private static CustomerUpdateView _customerUpdateView = null;
		private static CustomerDeleteView _customerDeleteView = null;
		private static CustomerSearchView _customerSearchView = null;


		public static Customer CreateNewCustomerObject( string firstName, string lastName, string item, decimal price, decimal materialAmount, bool isPremium )
		{
			return new Customer
			{
				FirstName = firstName,
				LastName = lastName,
				Item = item,
				Price = price,
				MaterialAmount = materialAmount,
				IsPremium = isPremium,
			};
		}

		public static CustomerRecordsView CustomerRecordsViewObject( Customers customers )
		{
			return new CustomerRecordsView(customers);
		}

		public static CustomerCreateView CustomerCreateViewObject( Customers customers )
		{
			if (_customerCreateView == null)
			{
				return new CustomerCreateView(customers);
			}
			return _customerCreateView;
		}

		public static CustomerReadView CustomerReadViewObject( Customers customers )
		{
			if (_customerReadView == null)
			{
				return new CustomerReadView(customers);
			}
			return _customerReadView;
		}

		public static CustomerUpdateView CustomerUpdateViewObject( Customers customers )
		{
			if (_customerUpdateView == null)
			{
				return new CustomerUpdateView(customers);
			}
			return _customerUpdateView;
		}

		public static CustomerDeleteView CustomerDeleteViewObject( Customers customers )
		{
			if (_customerDeleteView == null)
			{
				return new CustomerDeleteView(customers);
			}
			return _customerDeleteView;
		}

		public static CustomerSearchView CustomerSearchViewObject( Customers customers )
		{
			if (_customerSearchView == null)
			{
				return new CustomerSearchView(customers);
			}
			return _customerSearchView;
		}
	}
}
