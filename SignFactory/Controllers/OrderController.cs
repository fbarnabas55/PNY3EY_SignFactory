using Microsoft.AspNetCore.Mvc;
using SignFactory.Data;
using SignFactory.Entities.Dtos.Order;
using SignFactory.Entities.Entity_Models;

namespace SignFactory.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        Repository<Order> repo;

        //SignFactoryDbContext ctx;

        public OrderController(Repository<Order> repo)
        {
            this.repo = repo;
        }

        [HttpPost]
        public void AddOrder(OrderCreateDto dto)
        {
            var o = new Order(dto.OrderId, dto.Customer,dto.InstallationAdress);
            repo.Create(o);
        }
    }
}
