using Microsoft.AspNetCore.Mvc;
using SignFactory.Data;
using SignFactory.Entities.Dtos.Order;
using SignFactory.Entities.Dtos.SignProject;
using SignFactory.Logic.Logic;

namespace SignFactory.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SignProjectController : ControllerBase
    {

        SignProjectLogic logic;

        SignFactoryDbContext ctx;

        public SignProjectController(SignProjectLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        public void AddOrder(ProjectCreateDto dto)
        {
            logic.CreateProject(dto);
        }

        [HttpGet]
        public IEnumerable<ProjectViewDto> GetAllProjects()
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
