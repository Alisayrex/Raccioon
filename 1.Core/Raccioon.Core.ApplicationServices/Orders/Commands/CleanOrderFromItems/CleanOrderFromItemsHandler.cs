using Raccioon.Core.Contracts.Orders.Commands;
using Raccioon.Core.Contracts.Orders.Commands.CleanOrderFromItems;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace Raccioon.Core.ApplicationServices.Orders.Commands.CleanOrderFromItems
{
    public class CleanOrderFromItemsHandler : CommandHandler<CleanOrderFromItemsCommand, Guid>
    {
        private readonly IOrderCommandRepository _orderCommandRepository;

        public CleanOrderFromItemsHandler(ZaminServices zaminServices,IOrderCommandRepository orderCommandRepository)
            : base(zaminServices)
        {
            _orderCommandRepository = orderCommandRepository;
        }

        public async override Task<CommandResult<Guid>> Handle(CleanOrderFromItemsCommand request)
        {
            var order = _orderCommandRepository.Get(request.OrderId);
            order.DeleteAllItems();
            await _orderCommandRepository.InsertAsync(order);
            await _orderCommandRepository.CommitAsync();
            return Ok(order.BusinessId.Value);

        }
    }
}
