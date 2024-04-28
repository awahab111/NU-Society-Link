using System;
using System.Data.SqlClient;

namespace NU_Society_Link.DBHandlers
{
    public class EventSummaryDBHandler
    {
        private Database db;

        public EventSummaryDBHandler()
        {
            db = Database.GetInstance;
        }

        // Method to check if an event summary already exists for a given event title
        public bool CheckEventSummaryExists(string eventTitle)
        {
            bool eventSummaryExists = false;

            string query = "SELECT COUNT(*) FROM EventSummaries WHERE EventTitle = @EventTitle";

            using (var command = new SqlCommand(query, db.connection))
            {
                command.Parameters.AddWithValue("@EventTitle", eventTitle);

                try
                {
                    db.connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0) { eventSummaryExists = true; }
                    else { eventSummaryExists = false; }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error checking event summary existence: " + ex.Message);
                }
                finally
                {
                    db.connection.Close();
                }
            }

            return eventSummaryExists;
        }


        // Method to save an event summary
        public void SaveEventSummary(string eventTitle, string summary, int numberParticipants)
        {
            // Get the EventId based on the EventTitle
            int eventId = GetEventIdByTitle(eventTitle);

            // If the EventId is found, proceed to save the event summary
            if (eventId != 0)
            {
                string query = @"INSERT INTO EventSummaries (EventId, EventTitle, Summary, NumberParticipants)
                        VALUES (@EventId, @EventTitle, @Summary, @NumberParticipants)";

                using (var command = new SqlCommand(query, db.connection))
                {
                    command.Parameters.AddWithValue("@EventId", eventId);
                    command.Parameters.AddWithValue("@EventTitle", eventTitle);
                    command.Parameters.AddWithValue("@Summary", summary);
                    command.Parameters.AddWithValue("@NumberParticipants", numberParticipants);

                    try
                    {
                        db.connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine("Event summary saved.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error saving event summary: " + ex.Message);
                    }
                    finally
                    {
                        db.connection.Close();
                    }
                }
            }
            else
            {
                Console.WriteLine("Event with title '{0}' not found.", eventTitle);
            }
        }

        // Method to get EventId based on EventTitle
        private int GetEventIdByTitle(string eventTitle)
        {
            int eventId = 0;
            string query = "SELECT Event_id FROM Events WHERE Event_title = @EventTitle";

            using (var command = new SqlCommand(query, db.connection))
            {
                command.Parameters.AddWithValue("@EventTitle", eventTitle);

                try
                {
                    db.connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        eventId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching EventId by title: " + ex.Message);
                }
                finally
                {
                    db.connection.Close();
                }
            }

            return eventId;
        }
    }
}
