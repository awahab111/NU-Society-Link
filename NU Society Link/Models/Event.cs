using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NU_Society_Link.Models
{
    public class Event
    {
        public int Society_id { get; set; }
        public string Society_name { get; set; }

        public string Event_type { get; set; }
        public string Event_title { get; set; }
        

        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }

        public int expected_participants { get; set; }

        public string venue_name { get; set; }
        public string Event_description { get; set; }

        public string Event_Requirements { get; set; }





        // title, description, date, time, location (physical/virtual), and capacity to effectively plan and promote the event.

    }
}
