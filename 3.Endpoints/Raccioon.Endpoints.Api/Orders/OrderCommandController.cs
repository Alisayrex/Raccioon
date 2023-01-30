using Microsoft.AspNetCore.Mvc;
using Raccioon.Core.Contracts.Orders.Commands.CleanOrderFromItems;
using Raccioon.Core.Contracts.Orders.Commands.DefineOrder;
using Zamin.EndPoints.Web.Controllers;

namespace Raccioon.Endpoints.Api.Orders
{
    [Route("api/[controller]/[action]")]
    public class OrderCommandController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> DefineOrder([FromBody] DefineOrderCommand command)
            => await Create<DefineOrderCommand, Guid>(command);

        [HttpPost]
        public async Task<IActionResult> CleanOrderFromItems([FromBody] CleanOrderFromItemsCommand command)
            =>await Edit<CleanOrderFromItemsCommand, Guid>(command);

    }
}
