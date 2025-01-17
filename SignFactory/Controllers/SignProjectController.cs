using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SignFactory.Data;
using SignFactory.Entities.Dtos.Order;
using SignFactory.Entities.Dtos.SignProject;
using SignFactory.Entities.Entity_Models;
using SignFactory.Logic.Logic;

namespace SignFactory.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]

    public class SignProjectController : ControllerBase
    {

        SignProjectLogic logic;

        SignFactoryDbContext ctx;

        public SignProjectController(SignProjectLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        public void AddProject(ProjectCreateDto dto)
        {
            logic.CreateProject(dto);
            var demands = Enum.GetNames(typeof(PackageDemand));
            Ok(demands);
        }

        [HttpGet]
        public IEnumerable<ProjectFullViewDto> GetAllProjects()
        {
            return logic.GetAllProjects();
        }

        [HttpDelete("{id}")]

        public void DeleteProject(string id)
        {
            logic.DeleteProject(id);
        }
    }
}
