using SignFactory.Data;
using SignFactory.Entities.Dtos.Order;
using SignFactory.Entities.Dtos.SignProject;
using SignFactory.Entities.Entity_Models;
using SignFactory.Logic.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Logic.Logic
{
    public class SignProjectLogic
    {
        Repository<Project> repo;
        DtoProvider dtoProvider;
        public SignProjectLogic(Repository<Project> repo, DtoProvider dtoProvider)
        {
            this.repo = repo;
            this.dtoProvider = dtoProvider;
        }

        public void CreateProject(ProjectCreateDto dto,PackageDemand packageDemand)
        {
            var model = dtoProvider.Mapper.Map<Project>(dto);
            model.PackageDemand = packageDemand;
            repo.Create(model);

        }

        public IEnumerable<ProjectFullViewDto> GetAllProjects()
        {
            return repo.GetAll().Select(x => dtoProvider.Mapper.Map<ProjectFullViewDto>(x));
        }

        public void DeleteProject(string id)
        {
            repo.DeleteById(id);
        }

        public ProjectShortViewDto GetProjectByID(string id)
        {
            var model = repo.FindById(id);
            return dtoProvider.Mapper.Map<ProjectShortViewDto>(model);
        }
    }
}
