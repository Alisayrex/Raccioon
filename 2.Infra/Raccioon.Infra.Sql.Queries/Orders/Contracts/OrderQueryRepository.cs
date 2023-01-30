using Microsoft.EntityFrameworkCore;
using Raccioon.Core.Contracts.Orders.Queries;
using Raccioon.Core.Contracts.Orders.Queries.GetAllOrderItemsByOrderId;
using Raccioon.Core.Contracts.Orders.Queries.GetOrderByBusinessId;
using Raccioon.Infra.Sql.Queries.Common;
using Zamin.Infra.Data.Sql.Queries;

namespace Raccioon.Infra.Sql.Queries.Orders.Contracts
{
    public class OrderQueryRepository : BaseQueryRepository<OrderQueryDbContext>, IOrderQueryRepository
    {
        public OrderQueryRepository(OrderQueryDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<GetOrderQueryDto> Execute(GetOrderByBusinessIdQuery query)
          => await _dbContext.Orders.Select(c => new GetOrderQueryDto()
          {
              Title = c.Title,
              Description = c.Description,
              OrderDate = c.OrderDate,
              OrderStatus = c.OrderStatus.ToString(),
          }).FirstOrDefaultAsync(c => c.BusinessId.Equals(query.OrderBusinessId));

        public async Task<GetOrderItemsListDto> Execute(GetAllOrderItemsByOrderIdQuery query)
        // => await _dbContext.OrderItems.Select(c=> new GetOrderItemsListDto()

        {
            return null;
        }




} }
