using System;

namespace WebAPI.Entities
{
    public class EventDomain
    {
        public Guid Id { get; init; }
        public string Message { get; init; }
        public DateTime DateTime { get; init; }

        public EventDomain(string message)
        {
            this.Id = Guid.NewGuid();
            this.Message = message;
            this.DateTime = DateTime.UtcNow;
        }
    }
}