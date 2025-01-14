using SignFactory.Data;
using SignFactory.Entities.Dtos.Order;
using SignFactory.Entities.Entity_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignFactory.Logic
{
    public class OrderLogic
    {
        Repository<Order> repo;
        public OrderLogic(Repository<Order> repo)
        {
            this.repo = repo;
        }

        public void CreateOrder(OrderCreateDto dto)
        {
            Order o = new Order(dto.OrderId, dto.Customer, dto.InstallationAdress);
            if (repo.GetAll().FirstOrDefault(x => x.Id == o.Id) != null)
            {
                throw new Exception("Order already exists");
            }
            else { repo.Create(o); }

        }

        public IEnumerable<Order> GetAllOrders()
        {
            return repo.GetAll();
        }

        public void DeleteOrder(string id)
        {
            repo.DeleteById(id);
        }
    }
}
