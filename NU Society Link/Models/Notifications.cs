using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NU_Society_Link.Models
{
    public class Notifications
    {
        public int NotificationId { get; set; }
        public string UserId { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Seen { get; set; }

        public Notifications(int notificationId, string userId, string message, DateTime timeStamp, bool seen)
        {
            NotificationId = notificationId;
            UserId = userId;
            Message = message;
            TimeStamp = timeStamp;
            Seen = seen;
        }
    }
}
