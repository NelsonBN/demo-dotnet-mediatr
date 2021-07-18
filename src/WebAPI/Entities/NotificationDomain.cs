using System;

namespace WebAPI.Entities
{
    public class NotificationDomain
    {
        public Guid Id { get; init; }
        public string Message { get; init; }
        public DateTime DateTime { get; init; }
        public bool Read { get; private set; }

        public NotificationDomain(string message)
        {
            this.Id = Guid.NewGuid();
            this.Message = message;
            this.DateTime = DateTime.UtcNow;
            this.Read = false;
        }
        public void MarkAsRead()
        {
            this.Read = true;
        }
    }
}