using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace Raccioon.Core.Contracts.Orders.Queries.GetAllOrderItemsByOrderId
{
    public class GetAllOrderItemsByOrderIdQuery:IQuery<GetOrderItemsListDto>
    {
        public long OrderId { get; set; }
    }
}
