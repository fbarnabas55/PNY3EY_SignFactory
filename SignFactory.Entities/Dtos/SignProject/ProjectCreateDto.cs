using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Entities.Dtos.SignProject
{
    public class ProjectCreateDto
    {
        public required string OrderId { get; set; } = " ";

        public required string ProjectName { get; set; } = " ";

        public required string Description { get; set; } = " ";
        
        public required string InstallationAdress { get; set; } = " ";

        public required int BasePrice { get; set; }

        public required string PackageDemand { get; set; } = " ";
    }
}
