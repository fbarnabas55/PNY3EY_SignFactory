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
        public Order(string id,string customer, string installationLocation, DaylightTime time)
        {
            Id = id;
            Customer = customer;
            InstallationAdress = installationLocation;
            Time = time;
        }

        [StringLength(50)]
        [Key]
        public string Id { get; set; }

        [StringLength(50)]
        public string Customer { get; set; }

        [StringLength(100)]
        public string InstallationAdress { get; set; }

        [StringLength(100)]
        public DaylightTime Time { get; set; }

        [NotMapped]
        public virtual ICollection<Price>? Prices { get; set; }
    }
}
