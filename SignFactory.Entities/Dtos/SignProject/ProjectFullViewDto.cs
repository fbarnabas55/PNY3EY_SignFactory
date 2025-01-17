using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Entities.Dtos.SignProject
{
    public class ProjectFullViewDto
    {
        public Guid Id { get; set; }
        public string OrderId { get; set; } = " ";

        public string ProjectName { get; set; } = " ";

        public string Description { get; set; } = " ";

        public string InstallationAdress { get; set; } = " ";

        public int BasePrice { get; set; }

        public string PackageDemand { get; set; } = " ";
    }
}
