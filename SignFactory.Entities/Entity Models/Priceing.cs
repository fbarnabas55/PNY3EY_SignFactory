using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Entities.Entity_Models
{
    public class Priceing
    {
        public Priceing(string id, string orderId, string signId, double price)
        {
            Id = id;
            OrderId = orderId;
            Price = price;
        }

        [StringLength(50)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [StringLength(50)]
        public string OrderId { get; set; }
        
        [StringLength(50)]
        public double Price { get; set; }
    }
}
