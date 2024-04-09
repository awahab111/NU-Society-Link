using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace NU_Society_Link.Models
{
    public class EventSummary
    {
        public int SummaryId { get; set; } // Corresponds to SummaryId column
        public int EventId { get; set; } // Corresponds to Event_id column
        public string EventTitle { get; set; } // Corresponds to EventTitle column
        public string Summary { get; set; } // Corresponds to Summary column
        public int NumberParticipants { get; set; } // Corresponds to Number_participants column

        // Constructor with parameters
        public EventSummary(int summaryId, int eventId, string eventTitle, string summary, int numberParticipants)
        {
            SummaryId = summaryId;
            EventId = eventId;
            EventTitle = eventTitle;
            Summary = summary;
            NumberParticipants = numberParticipants;
        }
    }
}
