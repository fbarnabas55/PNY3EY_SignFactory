using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Entities.Dtos.Employee
{
    public class EmployeeCreateDto
    {
        public string Name { get; set; } = " ";
        public string Email { get; set; } = " ";
        public int PhoneNumber { get; set; }
        public string Department { get; set; } = " ";
    }
}
