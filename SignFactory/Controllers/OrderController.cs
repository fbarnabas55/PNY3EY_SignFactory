using Microsoft.AspNetCore.Mvc;
using SignFactory.Data;
using SignFactory.Entities.Dtos.Order;
using SignFactory.Entities.Entity_Models;
using SignFactory.Logic;

namespace SignFactory.Endpoint.Controllers
{
    [Route("Add [controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        OrderLogic logic;

        //SignFactoryDbContext ctx;

        public OrderController(OrderLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        public void AddOrder(OrderCreateDto dto)
        {
            logic.CreateOrder(dto);
        }
    }
}
