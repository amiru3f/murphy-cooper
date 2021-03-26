using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MurphyCooper.Common;

namespace MurphyCooper
{
    public class TestHandler : IRequestHandler<TestRequest, string>
    {
        public async Task<string> Handle(TestRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(1);
            return "Hello " + request.Name;
        }
    }
}