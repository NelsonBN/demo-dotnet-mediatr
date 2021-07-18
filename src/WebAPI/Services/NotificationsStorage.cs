using System.Collections.Generic;
using System.Linq;
using WebAPI.Entities;

namespace WebAPI.Services
{
    public class NotificationsStorage
    {
        private List<NotificationDomain> _storage { get; set; }

        public NotificationsStorage()
        {
            this._storage = new List<NotificationDomain>();
        }

        public void Add(NotificationDomain notificationDomain)
        {
            this._storage
                .Add(notificationDomain);
        }

        public IEnumerable<NotificationDomain> GetList()
        {
            var list = this._storage.Where(w => w.Read == false);

            var result = new List<NotificationDomain>();
            foreach(var notification in list)
            {
                result.Add(notification);

                notification.MarkAsRead();
            }
            return result;
        }
    }
}