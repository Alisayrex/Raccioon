using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace Raccioon.Core.Contracts.Orders.Commands.DefineOrder
{
    public class DefineOrderCommand:ICommand<Guid>
    {
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
    }
}
