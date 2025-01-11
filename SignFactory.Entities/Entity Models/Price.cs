using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Entities.Entity_Models
{
    public class Price
    {
        public Price(string id, string orderId, string signId, double price)
        {
            Id = id;
            OrderId = orderId;
            Price = price;
        }
    }
}
