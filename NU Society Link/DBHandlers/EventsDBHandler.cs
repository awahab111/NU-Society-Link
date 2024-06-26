using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.Models;
using System.Data.SqlClient;


namespace NU_Society_Link.DBHandlers
{

    public class EventsDBHandler {
        Database db;
        
        public EventsDBHandler(){
            db = Database.GetInstance;
        }
        
        
        public void SaveEvent(int societyId, string eventType, string eventTitle, DateTime startTime, DateTime endTime, int expectedParticipants, string venueName, string eventDescription, string eventRequirements, string headid)
        {
            string query = @"INSERT INTO Events (Society_id, Event_type, Event_title, Start_time, End_time, Expected_participants, Venue_name, Event_description, Event_requirements, HeadId)
                            VALUES (@societyId, @eventType, @eventTitle, @startTime, @endTime, @expectedParticipants, @venueName, @eventDescription, @eventRequirements, @headid)";

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
                command.Parameters.AddWithValue("@headid", headid);

                command.ExecuteNonQuery();
            }
        }

        public int GetEventID(string EventTitle){
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

        public Event GetEvent(string EventTitle, string EventType, string VenueName){
            string query = "SELECT * FROM  Events WHERE Event_title = @EventTitle AND Event_type = @EventType AND Venue_name = @VenueName";
            using (var command = db.connection.CreateCommand())
            {

                command.Parameters.AddWithValue("@EventTitle", EventTitle);
                command.Parameters.AddWithValue("@EventType", EventType);
                command.Parameters.AddWithValue("@VenueName", VenueName);
                command.CommandText = query;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Debug.WriteLine(reader["Event_id"]);
                        
                        return new Event((int)reader["Event_id"], (int)reader["Society_id"],(string)reader["HeadId"] ,(string)reader["Event_type"], (string)reader["Event_title"], (DateTime)reader["Start_time"], (DateTime)reader["End_time"], 
                            (int)reader["Expected_participants"], (string)reader["Venue_name"], (string)reader["Event_description"], (string)reader["Event_requirements"]);
                    }
                }
            }
            return null;
        }

        
        public List<Event> GetAllEvents()
        {
            List<Event> events = new List<Event>();


            string query = @"SELECT * FROM Events 
                          WHERE Start_time >= GETDATE()";
            
            SqlCommand command = new SqlCommand(query, db.connection);

            try
            {

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Event e = new Event();
                    e.Society_id = Convert.ToInt32(reader["Society_id"]);
                    e.Event_type = reader["Event_type"].ToString();
                    e.Event_title = reader["Event_title"].ToString();
                    e.start_time = Convert.ToDateTime(reader["Start_time"]);
                    e.end_time = Convert.ToDateTime(reader["End_time"]);
                    e.expected_participants = Convert.ToInt32(reader["Expected_participants"]);
                    e.venue_name = reader["Venue_name"].ToString();
                    e.Event_description = reader["Event_description"].ToString();
                    e.Event_Requirements = reader["Event_requirements"].ToString();


                    events.Add(e);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return events;
        }




    }




}