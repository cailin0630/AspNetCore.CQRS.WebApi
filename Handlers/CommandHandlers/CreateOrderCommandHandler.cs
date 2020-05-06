using AspNetCore.CQRS.Demo.Events;
using AspNetCore.CQRS.Demo.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCore.CQRS.Demo.Handlers.CommandHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderRequestModel, string>
    {
        private readonly IMediator _mediator;

        public CreateOrderCommandHandler(IMediator mediator)
        {
            this._mediator = mediator;
        }
        public Task<string> Handle(CreateOrderRequestModel request, CancellationToken cancellationToken)
        {
            //do something...
            _mediator.Publish(new OrderCreatedEvent(request.UserId), cancellationToken);
            return Task.FromResult(request.UserId);
        }
    }
}
