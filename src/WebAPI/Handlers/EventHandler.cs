using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.Commands;
using WebAPI.Entities;
using WebAPI.Services;

namespace WebAPI.Handlers
{
    public class EventHandler : INotificationHandler<EventNotification>
    {
        private readonly EventsStorage _storage;

        public EventHandler(
            EventsStorage storage
        )
        {
            this._storage = storage;
        }

        public Task Handle(EventNotification message, CancellationToken cancellationToken)
        {
            this._storage
                .Add(new EventDomain(
                    $"[EVENT]: {message.Notification}"
                ));

            return Task.CompletedTask;
        }
    }
}