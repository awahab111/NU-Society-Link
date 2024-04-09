using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.Models;

namespace NU_Society_Link.DBHandlers
{

    public class EventsDBHandler {
        Database db;
        
        public EventsDBHandler(){
            db = Database.GetInstance;
        }
        
        
        public void SaveEvent(int societyId, string eventType, string eventTitle, DateTime startTime, DateTime endTime, int expectedParticipants, string venueName, string eventDescription, string eventRequirements)
        {
            string query = @"INSERT INTO Events (Society_id, Event_type, Event_title, Start_time, End_time, Expected_participants, Venue_name, Event_description, Event_requirements)
                            VALUES (@societyId, @eventType, @eventTitle, @startTime, @endTime, @expectedParticipants, @venueName, @eventDescription, @eventRequirements)";

            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@societyId", societyId);
                command.Parameters.AddWithValue("@eventType", eventType);
                command.Parameters.AddWithValue("@eventTitle", eventTitle);
                command.Parameters.AddWithValue("@startTime", startTime);
                command.Parameters.AddWithValue("@endTime", endTime);
                command.Parameters.AddWithValue("@expectedParticipants", expectedParticipants);
                command.Parameters.AddWithValue("@venueName", venueName);
                command.Parameters.AddWithValue("@eventDescription", eventDescription);
                command.Parameters.AddWithValue("@eventRequirements", eventRequirements);
                command.ExecuteNonQuery();
            }
        }

        public int GetEvent(string EventTitle){
            string query = "SELECT * FROM  Events WHERE Event_title = @EventTitle";
            using (var command = db.connection.CreateCommand())
            {

                command.Parameters.AddWithValue("@EventTitle", EventTitle);
                command.CommandText = query;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Debug.WriteLine(reader["Event_id"]);
                        return (int)reader["Event_id"];
                    }
                }
            }
            return 0;
        }

        





    }




}