using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NU_Society_Link.Models
{
    public class Event
    {
        public int Event_id { get; set; }
        public int Society_id { get; set; }
        public string HeadId { get; set; }
        public string Event_type { get; set; }
        public string Event_title { get; set; }
        

        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }

        public int expected_participants { get; set; }
        public string venue_name { get; set; }
        public string Event_description { get; set; }
        public string Event_Requirements { get; set; }

        public Event(int Event_id ,int Society_id,string id, string Event_type, string Event_title, DateTime start_time, DateTime end_time, int expected_participants, string venue_name, string Event_description, string Event_Requirements)
        {
            this.Event_id = Event_id;
            this.Society_id = Society_id;
            this.HeadId = id;
            this.Event_type = Event_type;
            this.Event_title = Event_title;
            this.start_time = start_time;
            this.end_time = end_time;
            this.expected_participants = expected_participants;
            this.venue_name = venue_name;
            this.Event_description = Event_description;
            this.Event_Requirements = Event_Requirements;
        }

        public Event()
        {
        }





        // title, description, date, time, location (physical/virtual), and capacity to effectively plan and promote the event.

    }
}
