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
        public Order(string id,string customer,string type ,string installationLocation, DaylightTime time)
        {
            Id = id;
            Customer = customer;
            Type = type;
            InstallationAdress = installationLocation;
            Time = time;
        }

        [StringLength(50)]
        [Key]
        public string Id { get; set; }

        [StringLength(100)]
        public string Customer { get; set; }

        [StringLength(10)]
        public string Type { get; set; }

        [StringLength(100)]
        public string InstallationAdress { get; set; }

        public DaylightTime Time { get; set; }

        [NotMapped]
        public virtual ICollection<Priceing>? Prices { get; set; }
    }
}
