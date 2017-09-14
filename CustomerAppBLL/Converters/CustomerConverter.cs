using CustomerAppBLL.BusinessObjects;
using CustomerAppDAL.Entities;
using System.Linq;

namespace CustomerAppBLL.Converters
{
	class CustomerConverter
	{

		public CustomerConverter()
		{
		}

		internal Customer Convert(CustomerBO cust)
		{
			if (cust == null) { return null; }
			return new Customer()
			{
				Id = cust.Id,
				FirstName = cust.FirstName,
				LastName = cust.LastName
			};
		}

		internal CustomerBO Convert(Customer cust)
		{
			if (cust == null) { return null; }
			return new CustomerBO()
			{
				Id = cust.Id,
				FirstName = cust.FirstName,
				LastName = cust.LastName
			};
		}
	}
}