using System.Collections.Generic;
using WebAPI.Entities;

namespace WebAPI.Services
{
    public class EventsStorage
    {
        private List<EventDomain> _storage { get; set; }

        public EventsStorage()
        {
            this._storage = new List<EventDomain>();
        }

        public void Add(EventDomain eventDomain)
        {
            this._storage
                .Add(eventDomain);
        }

        public IEnumerable<EventDomain> GetList()
        {
            return this._storage;
        }
    }
}