using System.Threading.Tasks;
using Grpc.Core;
using MediatR;
using MurphyCooper.Common;
using static MurphyCooper.Common.Test;

namespace MurphyCooper
{
    public class TestService : TestBase
    {
        private readonly IMediator mediator;
        public TestService(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public override async Task<TestResponse> Hello(TestRequest request, ServerCallContext context)
        {
            TestResponse response = new TestResponse()
            {
                Message = await mediator.Send<string>(request)
            };

            return response;
        }
    }
}