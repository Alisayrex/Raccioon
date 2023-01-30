using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace Raccioon.Core.Contracts.Orders.Queries.GetOrderByBusinessId
{
    public class GetOrderByBusinessIdQuery:IQuery<GetOrderQueryDto>
    {
        public Guid OrderBusinessId { get; set; }
    }
}
