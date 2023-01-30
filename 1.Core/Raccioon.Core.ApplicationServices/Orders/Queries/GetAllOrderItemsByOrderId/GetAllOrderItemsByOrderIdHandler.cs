using Raccioon.Core.Contracts.Orders.Queries;
using Raccioon.Core.Contracts.Orders.Queries.GetAllOrderItemsByOrderId;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Utilities;

namespace Raccioon.Core.ApplicationServices.Orders.Queries.GetAllOrderItemsByOrderId
{
    public class GetAllOrderItemsByOrderIdHandler : QueryHandler<GetAllOrderItemsByOrderIdQuery, GetOrderItemsListDto>
    {
        private readonly IOrderQueryRepository _orderQueryRepository;
        public GetAllOrderItemsByOrderIdHandler(ZaminServices zaminServices, IOrderQueryRepository orderQueryRepository)
            : base(zaminServices)
        {

            _orderQueryRepository = orderQueryRepository;
        }

        public override async Task<QueryResult<GetOrderItemsListDto>> Handle(GetAllOrderItemsByOrderIdQuery query)
        {
            var order = await _orderQueryRepository.Execute(query);
            return Result(order);

        }
    }
}
