using SignFactory.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Entities.Entity_Models
{
    public class Employee : IIdEntity
    {
        public Employee(string name, string email)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Email = email;
            Orders = new HashSet<Order>();

        }
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
