using System;
using CustomerAppBLL.BusinessObjects;
using CustomerAppDAL.Entities;

namespace CustomerAppBLL.Converters
{
    internal class OrderConverter
    {

		internal Order Convert(OrderBO order)
		{
			if (order == null) { return null; }
			return new Order()
			{
				Id = order.Id,
				DeliveryDate = order.DeliveryDate,
				OrderDate = order.OrderDate,
                CustomerID = order.CustomerID
			};
		}


		internal OrderBO Convert(Order order)
        {
            return new OrderBO()
            {
                Id = order.Id,
                DeliveryDate = order.DeliveryDate,
                OrderDate = order.OrderDate,
                Customer = new CustomerConverter().Convert(order.Customer),
                CustomerID = order.CustomerID
			};
        }
    }
}
