using Raccioon.Core.Domain.Orders.Entities;
using Raccioon.Core.Domain.Orders.ValueObjects;

namespace Raccioon.Core.Contracts.Orders.Queries.GetAllOrderItemsByOrderId
{
    public class GetOrderItemsListDto
    {
        public long OrderId { get; set; }

        public string ProductTitle { get; set; }

        public string Price { get; set; }
        public int Units { get; set; }
        public int CatalogItemId { get; set; }
    }
}
