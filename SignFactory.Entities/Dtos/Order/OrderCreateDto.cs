﻿using SignFactory.Entities.Dtos.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Entities.Dtos.Order
{
    public class OrderCreateDto
    {
        public string Id { get; set; } = " ";

        public string OrderName { get; set; } = " ";

        public string ProjectManager { get; set; } = " ";

        public DateTime Deadline { get; set; }
    }
}
