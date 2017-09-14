using System;
namespace CustomerAppBLL.BusinessObjects
{
    public class OrderBO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        public int CustomerID { get; set; }
        public CustomerBO Customer { get; set; }
    }
}
