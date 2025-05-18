using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SignFactory.Data;
using SignFactory.Entities.Dtos.Design;
using SignFactory.Entities.Dtos.SignProject;
using SignFactory.Entities.Entity_Models;
using SignFactory.Logic.Logic;

namespace SignFactory.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[Authorize(Roles="Admin,Designer")]
    public class SignDesignController
    {
        SignDesignLogic logic;

        SignFactoryDbContext ctx;

        public SignDesignController(SignDesignLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        public void AddDesign(DesignCreateDto dto, Lightings lightings, Brightness brightness, Material material)
        {
            logic.CreateDesign(dto, lightings, brightness, material);
            var light = Enum.GetNames(typeof(Lightings));
            var bright = Enum.GetNames(typeof(Brightness));
            var mat = Enum.GetNames(typeof(Material));

        }

        [HttpGet]
        public IEnumerable<DesignFullViewDto> GetAllDesigns()
        {
            return logic.GetAllDesigns();
        }

        [HttpGet("{id}")]
        public DesignShortViewDto GetDesignID(string id)
        {
            return logic.GetDesignByID(id);
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "Admin")]

        public void DeleteDesign(string id)
        {
            logic.DeleteDesign(id);
        }
    }
}

