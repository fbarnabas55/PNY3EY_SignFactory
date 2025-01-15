using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SignFactory.Entities.Helpers;

namespace SignFactory.Entities.Entity_Models
{
    public class SignType : IIdEntity
    {
        public SignType(string typeName, int basePrice, string orderId)
        {
            Id = Guid.NewGuid().ToString();
            TypeName = typeName;
            BasePrice = basePrice;
            Orders = new HashSet<Order>();
        }
        public SignType()
        {
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; } 
        
        public int BasePrice { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
