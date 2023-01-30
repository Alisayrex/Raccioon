using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace Raccioon.Core.Contracts.Orders.Commands.CleanOrderFromItems
{
    public class CleanOrderFromItemsCommand:ICommand<Guid>
    {
        public int OrderId { get; set; }
    }
}
