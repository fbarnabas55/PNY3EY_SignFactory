

namespace SignFactory.Entities.Dtos.Order
{
    public class OrderCreateDto
    {
        public string Id { get; set; } = " ";

        public string OrderName { get; set; } = " ";

        public string ProjectManager { get; set; } = " ";

        public DateTime Deadline { get; set; }
    }
}
