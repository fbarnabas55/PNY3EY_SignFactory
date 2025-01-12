using Microsoft.AspNetCore.Mvc;
using SignFactory.Data;
using SignFactory.Entities.Entity_Models;

namespace SignFactory.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        SignFactoryDbContext cxt;

        public OrderController(SignFactoryDbContext cxt)
        {
            this.cxt = cxt;
        }

        [HttpPost]
        public void addOrder(Order order)
        {
            cxt.Orders.Add(order);
            cxt.SaveChanges();
        }
    }
}
