using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignFactory.Data;
using SignFactory.Entities.Dtos.Order;
using SignFactory.Entities.Entity_Models;
using SignFactory.Logic.Logic;

namespace SignFactory.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        OrderLogic logic;

        SignFactoryDbContext ctx;

        public OrderController(OrderLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        //[Authorize]
        public void AddOrder(OrderCreateDto dto)
        {
            logic.CreateOrder(dto);
        }

        [HttpGet]
        //[Authorize(Roles= "Admin")]

        public IEnumerable<OrderFullViewDto> GetAllOrders()
        {
            return logic.GetAllOrders();
        }

        [HttpGet("{id}")]
        //[Authorize]
        public OrderShortViewDto GetOrderByID(string id)
        {
            return logic.GetOrderByID(id);
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "Admin")]

        public void DeleteOrder(string id)
        {
            logic.DeleteOrder(id);
        }

        [HttpPut("{id}")]
        //[Authorize(Roles ="Admin,ProjectManager")]

        public void UpdateOrder(string id, [FromBody] OrderUpdateDto dto)
        {
            logic.UpdateOrder(id, dto);
        }


    }
}
