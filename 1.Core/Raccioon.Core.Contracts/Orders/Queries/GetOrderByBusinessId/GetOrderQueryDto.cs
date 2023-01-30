using static Raccioon.Core.Domain.Orders.Entities.OrderState;

namespace Raccioon.Core.Contracts.Orders.Queries.GetOrderByBusinessId
{
    public class GetOrderQueryDto
    {
        public string Title { get; set; }
        public Guid BusinessId { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
    }
}
