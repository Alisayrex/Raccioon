using Raccioon.Core.Contracts.Orders.Commands;
using Raccioon.Core.Contracts.Orders.Commands.DefineOrder;
using Raccioon.Core.Domain.Orders.Entities;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;


namespace Raccioon.Core.ApplicationServices.Orders.Commands.DefineOrder
{
    public class DefineOrderHandler : CommandHandler<DefineOrderCommand, Guid>
    {
        private readonly IOrderCommandRepository _orderCommandRepository;

        public DefineOrderHandler(ZaminServices zaminServices, IOrderCommandRepository orderCommandRepository)
            : base(zaminServices)
        {
            _orderCommandRepository = orderCommandRepository;
        }

        public override async Task<CommandResult<Guid>> Handle(DefineOrderCommand command)
        {
            Order order = new Order(command.title, command.description);
            await _orderCommandRepository.InsertAsync(order);
            await _orderCommandRepository.CommitAsync();
            return Ok(order.BusinessId.Value);
        }

    }
}
