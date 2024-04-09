
using System.Diagnostics;

namespace NU_Society_Link.DBHandlers
{
    public class TaskDBHandler
    {
        Database db; 

        public TaskDBHandler()
        {
            db = Database.GetInstance;
        }


        public bool AddTask(int EventId, string AssignedTo, string Description, DateTime DueDate)
        {
            try
            {
                string query = "INSERT INTO Tasks (EventId, assignedTo, Description, DueDate, IsCompleted) VALUES (@eventId, @assignedTo, @description, @dueDate, @isCompleted)";
                using (var command = db.connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@eventId", EventId);
                    command.Parameters.AddWithValue("@assignedTo", AssignedTo);
                    command.Parameters.AddWithValue("@description", Description);
                    command.Parameters.AddWithValue("@dueDate", DueDate);
                    command.Parameters.AddWithValue("@isCompleted", 0);
                    Debug.WriteLine("Executing query: " + query);
                    command.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g. log the error or throw a custom exception
                Console.WriteLine("An error occurred while adding the task: " + ex.Message);
                return false;
            }
        }
    }
}
