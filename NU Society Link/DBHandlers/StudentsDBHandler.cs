using NU_Society_Link.Models;
using System.Diagnostics;
namespace NU_Society_Link.DBHandlers
{
    public class StudentsDBHandler
    {
        Database db = Database.GetInstance;

        public void AddStudent(int id, string name, string batch, string email, string contact)
        {
            try
            {
                string query = "INSERT INTO Students (RollNumber, Name, Batch, Email, contact) VALUES (@id, @name, @batch, @email, @contact)";
                using (var command = db.connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@batch", batch);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@contact", contact);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occurred while adding the student: " + ex.Message);
            }
        }

        public void DeleteStudent(int id)
        {
            try
            {
                string query = "DELETE FROM Students WHERE RollNumber = @id";
                using (var command = db.connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g. log the error or throw a custom exception
                Console.WriteLine("An error occurred while deleting the student: " + ex.Message);
            }
        }

        public Student GetStudent(string id)
        {
            try
            {
                string query = "SELECT * FROM Students WHERE RollNumber = @id";
                using (var command = db.connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rollNumber = int.Parse(reader.GetString(0));
                            string name = reader.GetString(1);
                            string batch = reader.GetString(2);
                            string email = reader.GetString(3);
                            string contact = reader.GetString(4);
                            Student student = new Student(rollNumber.ToString(), name, email, contact, batch);
                            return student;
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error occurred while getting the student: " + ex.Message);
                return null; // Add a return statement to handle the exception case
            }
        }

    }
}