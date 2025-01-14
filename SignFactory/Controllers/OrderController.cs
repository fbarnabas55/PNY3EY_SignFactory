using Microsoft.AspNetCore.Mvc;
using SignFactory.Data;
using SignFactory.Entities.Dtos.Order;
using SignFactory.Entities.Entity_Models;
using SignFactory.Logic;

namespace SignFactory.Endpoint.Controllers
{
    [Route("[controller]")]
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

        [HttpGet]
        public IEnumerable<Order> GetAllOrders()
        {
            return logic.GetAllOrders();
        }

        [HttpDelete("{id}")]
        public void DeleteOrder(string id)
        {
            logic.DeleteOrder(id);
        }

        [HttpPut("{id}")]
        public void UpdateOrder(string id, [FromBody] OrderUpdateDto dto)
        {
            logic.UpdateOrder(id, dto);
        }


    }
}
