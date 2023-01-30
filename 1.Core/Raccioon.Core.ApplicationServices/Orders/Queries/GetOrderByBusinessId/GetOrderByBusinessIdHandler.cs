using Raccioon.Core.Contracts.Orders.Queries;
using Raccioon.Core.Contracts.Orders.Queries.GetOrderByBusinessId;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Utilities;

namespace Raccioon.Core.ApplicationServices.Orders.Queries.GetOrderByBusinessId
{
    public class GetOrderByBusinessIdHandler : QueryHandler<GetOrderByBusinessIdQuery, GetOrderQueryDto>
    {
        private readonly IOrderQueryRepository _orderQueryRepository;

        public GetOrderByBusinessIdHandler(ZaminServices zaminServices, IOrderQueryRepository orderQueryRepository)
            : base(zaminServices)
        {
            _orderQueryRepository = orderQueryRepository;
        }

        public override async Task<QueryResult<GetOrderQueryDto>> Handle(GetOrderByBusinessIdQuery query)
        {
            var order = await _orderQueryRepository.Execute(query);
            return Result(order);
        }
    }
}
