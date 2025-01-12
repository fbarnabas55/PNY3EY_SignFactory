using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using SignFactory.Entities.Helpers;
using System.Globalization;

namespace SignFactory.Entities.Entity_Models
{
    public class Order : IIdEntity
    {
        public Order(string id,string customer,string installationLocation, DateTime time)
        {
            Id = id;
            Customer = customer;
            InstallationAdress = installationLocation;
            Time = time;
            Types = new List<SignType>();
            Employees = new HashSet<Employee>();
        }
        public Order()
        {
            Types = new List<SignType>();
            Employees = new HashSet<Employee>();

        }

        [StringLength(50)]
        [Key]
        [Required]
        public string Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Customer { get; set; }

        [StringLength(200)]
        [Required]
        public string InstallationAdress { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [NotMapped]
        public virtual ICollection<SignType>? Types { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }


    }
}
