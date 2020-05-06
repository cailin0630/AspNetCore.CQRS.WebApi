using MediatR;

namespace AspNetCore.CQRS.Demo.Models
{
    public class CreateOrderRequestModel : IRequest<string>
    {
        public string UserId { get; set; }
        public string CardNumber { get; set; }
    }
}
