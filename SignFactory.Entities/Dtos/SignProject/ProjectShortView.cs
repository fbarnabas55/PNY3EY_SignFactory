using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json.Converters;
using SignFactory.Entities.Entity_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SignFactory.Entities.Dtos.SignProject
{
    public class ProjectShortView
    {
        public string ProjectName { get; set; } = " ";

        public string Description { get; set; } = " ";

        public string InstallationAdress { get; set; } = " ";

        public int BasePrice { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PackageDemand PackageDemand { get; set; }
    }
}
