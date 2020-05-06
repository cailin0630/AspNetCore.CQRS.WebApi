using AspNetCore.CQRS.Demo.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCore.CQRS.Demo.Handlers.QueryHandlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdRequestModel, string>
    {
        public Task<string> Handle(GetOrderByIdRequestModel request, CancellationToken cancellationToken)
        {
            //do something
            return Task.FromResult(request.OrderId);
        }
    }
}
