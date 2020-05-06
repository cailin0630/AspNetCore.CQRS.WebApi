using MediatR;

namespace AspNetCore.CQRS.Demo.Events
{
    public class OrderCreatedEvent : INotification
    {
        public string UserId { get; set; }

        public OrderCreatedEvent(string orderId)
        {
            this.UserId = orderId;
        }
    }
}
