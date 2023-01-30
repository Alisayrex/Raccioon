using static Raccioon.Core.Domain.Orders.Entities.OrderState;

namespace Raccioon.Infra.Sql.Queries.Orders.Entities
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Guid BusinessId { get; set; }

        public List<OrderItem> OrderItems { get; set; }
        public long OrderId { get; set; }
    }
}
