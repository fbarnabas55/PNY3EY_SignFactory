using SignFactory.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Entities.Entity_Models
{
    public class Employee : IIdEntity
    {
        public Employee(string name, string email, int phoneNumber, string department)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Department = department;
            Orders = new HashSet<Order>();
        }
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        [StringLength(20)]
        [Key]
        [Required]
        public string Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [StringLength(200)]
        [Required]
        public string Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [StringLength(100)]
        [Required]
        public string Department { get; set; }
        [NotMapped]
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
