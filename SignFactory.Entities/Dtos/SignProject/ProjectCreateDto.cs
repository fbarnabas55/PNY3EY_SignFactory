﻿using SignFactory.Entities.Entity_Models;


namespace SignFactory.Entities.Dtos.SignProject
{
    public class ProjectCreateDto
    {
        public required string OrderId { get; set; } = "";

        public required string ProjectName { get; set; } = "";

        public required string Description { get; set; } = "";

        public required string InstallationAdress { get; set; } = "";

        public required int BasePrice { get; set; }

    }
}
