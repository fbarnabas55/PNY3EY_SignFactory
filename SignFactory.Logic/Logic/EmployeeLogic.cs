using SignFactory.Data;
using SignFactory.Entities.Dtos.Employee;
using SignFactory.Entities.Entity_Models;
using SignFactory.Logic.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Logic.Logic
{
    public class EmployeeLogic
    {
        Repository<Employee> repo;
        DtoProvider dtoProvider;

        public EmployeeLogic(Repository<Employee> repo, DtoProvider dtoProvider)
        {
            this.repo = repo;
            this.dtoProvider = dtoProvider;
        }

        public void CreateEmployee(EmployeeCreateDto dto)
        {
            Employee e = dtoProvider.Mapper.Map<Employee>(dto);
            if (repo.GetAll().FirstOrDefault(x => x.Id == e.Id) == null)
            {
                repo.Create(e);
            }
            else { throw new Exception("Employee already exists"); }
        }
    }
}
