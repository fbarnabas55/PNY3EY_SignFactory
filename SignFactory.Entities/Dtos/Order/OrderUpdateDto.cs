using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Entities.Dtos.Order
{
    public class OrderUpdateDto
    {
        public string OrderName { get; set; } = " ";

        public string ProjectManager { get; set; } = " ";

        public DateTime Deadline { get; set; }
    }
}
