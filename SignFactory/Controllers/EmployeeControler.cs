using Microsoft.AspNetCore.Mvc;
using SignFactory.Entities.Dtos.Employee;
using SignFactory.Logic.Logic;

namespace SignFactory.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeControler : ControllerBase
    {
        EmployeeLogic logic;

        public EmployeeControler(EmployeeLogic logic)
        {
            this.logic = logic;
        }
        [HttpPost]
        public void AddEmployee(EmployeeCreateDto dto)
        {
            logic.CreateEmployee(dto);
        }
    }
}
