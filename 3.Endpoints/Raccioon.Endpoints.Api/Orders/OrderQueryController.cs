using Microsoft.AspNetCore.Mvc;
using Raccioon.Core.Contracts.Orders.Queries.GetAllOrderItemsByOrderId;
using Raccioon.Core.Contracts.Orders.Queries.GetOrderByBusinessId;
using Zamin.EndPoints.Web.Controllers;

namespace Raccioon.Endpoints.Api.Orders
{

    [Route("api/[controller]/[action]")]
    public class OrderQueryController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> GetOrderByBusinessId([FromQuery] GetOrderByBusinessIdQuery query)
            => await Query<GetOrderByBusinessIdQuery, GetOrderQueryDto>(query);

        [HttpGet]
        public async Task<IActionResult> GetAllOrderItemsByOrderId([FromQuery] GetAllOrderItemsByOrderIdQuery query)
           => await Query<GetAllOrderItemsByOrderIdQuery, GetOrderItemsListDto>(query);

    }
}
