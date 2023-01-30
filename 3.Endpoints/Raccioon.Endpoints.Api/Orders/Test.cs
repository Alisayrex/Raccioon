using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Raccioon.Core.Contracts.Orders.Commands.DefineOrder;

namespace Raccioon.Endpoints.Api.Orders
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class Test
    {
        [HttpGet]
        public IEnumerable<string> TestMe()
        {

             return new string[] { "value1", "value2" };
        }


    }
}