using Raccioon.Core.Contracts.Orders.Commands;
using Raccioon.Core.Domain.Orders.Entities;
using Raccioon.Infra.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace Raccioon.Infra.Sql.Commands.Orders.Contracts
{
    public class OrderCommandRepository : BaseCommandRepository<Order, OrderCommandDbContext>,
        IOrderCommandRepository
    {
        public OrderCommandRepository(OrderCommandDbContext dbContext)
            : base(dbContext)
        {

        }

    }
}
