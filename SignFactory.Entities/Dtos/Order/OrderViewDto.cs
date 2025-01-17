using SignFactory.Entities.Dtos.SignProject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Entities.Dtos.Order
{
    public class OrderViewDto
    {
        public string Id { get; set; } = " ";

        public string OrderName { get; set; } = " ";

        public string ProjectManager { get; set; } = " ";

        public DateTime Deadline { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now.Date;

        public IEnumerable<ProjectFullViewDto>? Projects { get; set; }
    }
}
