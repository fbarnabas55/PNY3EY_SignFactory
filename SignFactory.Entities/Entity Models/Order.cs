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
        public Order(string id, string orderName, string projectManager, DateTime deadline)
        {
            Id = id;
            OrderName = orderName;
            ProjectManager = projectManager;
            Deadline = deadline.Date;
            StartDate = DateTime.Now.Date;
        }
        

        [StringLength(30)]
        [Key]
        [Required]
        public string Id { get; set; }

        [StringLength(100)]
        [Required]
        public string OrderName { get; set; }
        
        [StringLength(100)]
        [Required]
        public string ProjectManager { get; set; }

        [Required]
        public DateTime Deadline { get; set; }

        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now.Date;

        [NotMapped]
        public virtual ICollection<Project>? Projects { get; set; }


    }
}
