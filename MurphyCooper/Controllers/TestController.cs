using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MurphyCooper.Common;

namespace MurphyCooper
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly IMediator mediator;
        public TestController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Test([FromBody] TestRequest request)
        {
            var response = await mediator.Send<string>(request);
            return Ok(response);
        }
    }
}