using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SignFactory.Entities.Helpers;

namespace SignFactory.Entities.Entity_Models
{
    public class SignType
    {
        public SignType(string typeName, int basePrice, string orderId)
        {
            Id = Guid.NewGuid().ToString();
            TypeName = typeName;
            BasePrice = basePrice;
            OrderId = orderId;
            Orders = new HashSet<Order>();
        }
        public SignType()
        {
        }

        public string OrderId { get; set; }
        public virtual Order Order { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; } 
        
        public int BasePrice { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
