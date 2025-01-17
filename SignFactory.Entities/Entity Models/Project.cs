using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SignFactory.Entities.Helpers;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json.Converters;

namespace SignFactory.Entities.Entity_Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PackageDemand
    {
        Foiled,
        Boxed,
        Stocked
    }
    

    public class Project : IIdEntity
    {
        public Project(string orderId, string projectName, string description, string installationAdress, int basePrice, PackageDemand packageDemand)
        {
            Id = Guid.NewGuid().ToString();
            OrderId = orderId;
            ProjectName = projectName;
            Description = description;
            InstallationAdress = installationAdress;
            BasePrice = basePrice;
            PackageDemand = packageDemand;

        }

        [StringLength(50)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string Id { get; set; }

        [StringLength(30)]
        [Required]
        public string OrderId { get; set; }

        [NotMapped]
        public virtual Order? Order { get; set; }

        [Required]
        [StringLength(100)]
        public string ProjectName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string InstallationAdress { get; set; }

        [Required]
        public int BasePrice { get; set; }

        [Required]
        [JsonConverter(typeof(StringEnumConverter))]

        public PackageDemand PackageDemand { get; set; }

        
    }
}
