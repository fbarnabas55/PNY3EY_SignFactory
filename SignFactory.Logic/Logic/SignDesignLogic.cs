using SignFactory.Data;
using SignFactory.Entities.Dtos.Design;
using SignFactory.Entities.Dtos.SignProject;
using SignFactory.Entities.Entity_Models;
using SignFactory.Logic.Helper;

namespace SignFactory.Logic.Logic
{
    public class SignDesignLogic
    {
        Repository<Design> repo;
        DtoProvider dtoProvider;
        public SignDesignLogic(Repository<Design> repo, DtoProvider dtoProvider)
        {
            this.repo = repo;
            this.dtoProvider = dtoProvider;
        }

        public void CreateDesign(DesignCreateDto dto, Lightings lightings, Brightness brightness, Material material)
        {
            var model = dtoProvider.Mapper.Map<Design>(dto);
            model.Lightings = lightings;
            model.Brightness = brightness;
            model.Material = material;
            repo.Create(model);

        }

        public IEnumerable<DesignFullViewDto> GetAllDesigns()
        {
            return repo.GetAll().Select(x => dtoProvider.Mapper.Map<DesignFullViewDto>(x));
        }

        public void DeleteDesign(string id)
        {
            repo.DeleteById(id);
        }

        public DesignShortViewDto GetDesignByID(string id)
        {
            var model = repo.FindById(id);
            return dtoProvider.Mapper.Map<DesignShortViewDto>(model);
        }
    }
}
