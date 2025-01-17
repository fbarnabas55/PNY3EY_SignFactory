using SignFactory.Data;
using SignFactory.Entities.Dtos.Order;
using SignFactory.Entities.Entity_Models;
using SignFactory.Logic.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Logic.Logic
{
    public class OrderLogic
    {
        Repository<Order> repo;
        DtoProvider dtoProvider;
        public OrderLogic(Repository<Order> repo, DtoProvider dtoProvider)
        {
            this.repo = repo;
            this.dtoProvider = dtoProvider;
        }

        public void CreateOrder(OrderCreateDto dto)
        {
            Order o = dtoProvider.Mapper.Map<Order>(dto);

            if (repo.GetAll().FirstOrDefault(x => x.Id == o.Id) == null)
            {
                repo.Create(o);
            }
            else { throw new Exception("Order already exists"); }

        }

        public IEnumerable<OrderViewDto> GetAllOrders()
        {
            return repo.GetAll().Select(x =>dtoProvider.Mapper.Map<OrderViewDto>(x));
        }

        public void DeleteOrder(string id)
        {
            repo.DeleteById(id);
        }

        public void UpdateOrder(string id, OrderUpdateDto dto)
        {
            var old = repo.FindById(id);
            dtoProvider.Mapper.Map(dto, old);
            repo.Update(old);
        }

        public OrderViewDto GetOrderByID(string id)
        {
            var model = repo.FindById(id);
            return dtoProvider.Mapper.Map<OrderViewDto>(model);
        }
    }
}
