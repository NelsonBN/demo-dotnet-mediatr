using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.Commands;
using WebAPI.Entities;
using WebAPI.Services;

namespace WebAPI.Handlers
{
    public class NotificationHandler : INotificationHandler<EventNotification>
    {
        private readonly NotificationsStorage _storage;

        public NotificationHandler(
            NotificationsStorage storage
        )
        {
            this._storage = storage;
        }

        public Task Handle(EventNotification message, CancellationToken cancellationToken)
        {
            this._storage
                .Add(new NotificationDomain(
                    $"[NOTIFICATION]: {message.Notification}"
                ));

            return Task.CompletedTask;
        }
    }
}