using MediatR;

namespace AspNetCore.CQRS.Demo.Models
{
    public class GetOrderByIdRequestModel : IRequest<string>
    {
        public string OrderId { get; set; }
    }
}
