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

        public void CreateProject(ProjectCreateDto dto)
        {
            var model = dtoProvider.Mapper.Map<Project>(dto);
            repo.Create(model);

        }

        public IEnumerable<ProjectViewDto> GetAllProjects()
        {
            return repo.GetAll().Select(x => dtoProvider.Mapper.Map<ProjectViewDto>(x));
        }

        public void DeleteProject(string id)
        {
            repo.DeleteById(id);
        }
    }
}
