using MediatR;

namespace WebAPI.Commands
{
    public record EventNotification : INotification
    {
        public string Notification { get; init; }
        public EventNotification(string notification)
        {
            this.Notification = notification;
        }
    }
}