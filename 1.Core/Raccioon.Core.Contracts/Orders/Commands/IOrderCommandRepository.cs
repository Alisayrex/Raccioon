using Raccioon.Core.Domain.Orders.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace Raccioon.Core.Contracts.Orders.Commands
{
    public interface IOrderCommandRepository: ICommandRepository<Order>
    {
      
    }
}
