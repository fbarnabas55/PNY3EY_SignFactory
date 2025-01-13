using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Entities.Dtos.Order
{
    public class OrderCreateDto
    {
        public string OrderId { get; set; }
        public string Customer { get; set; }
        public string InstallationAdress { get; set; }
    }
}
