using Raccioon.Core.Contracts.Orders.Queries.GetAllOrderItemsByOrderId;
using Raccioon.Core.Contracts.Orders.Queries.GetOrderByBusinessId;
using Zamin.Core.Contracts.Data.Queries;

namespace Raccioon.Core.Contracts.Orders.Queries
{
    public interface IOrderQueryRepository:IQueryRepository
    {
        Task<GetOrderQueryDto> Execute(GetOrderByBusinessIdQuery query);

        Task<GetOrderItemsListDto> Execute(GetAllOrderItemsByOrderIdQuery query);
    }
}
