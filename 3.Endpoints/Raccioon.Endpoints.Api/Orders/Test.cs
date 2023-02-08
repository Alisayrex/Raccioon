using Microsoft.AspNetCore.Mvc;

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