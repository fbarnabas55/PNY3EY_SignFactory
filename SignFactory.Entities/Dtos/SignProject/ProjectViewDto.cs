using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Entities.Dtos.SignProject
{
    public class ProjectViewDto
    {
        public Guid Id { get; set; }
        public string OrderId { get; set; } = " ";
        public string ProjectName { get; set; } = " ";

        public string Description { get; set; } = " ";
    }
}
