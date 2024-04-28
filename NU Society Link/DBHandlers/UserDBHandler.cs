using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.Models;
namespace NU_Society_Link.DBHandlers
{
    public class UserDBHandler
    {
        Database db = Database.GetInstance;

        public void AddUser(int id, string username, string password, string name, string batch, string email, string contact)
        {
            try
            {
                string query = "INSERT INTO users (RollNumber, username, password, isadmin) VALUES (@id, @username, @password, @isadmin)";
                using (var command = db.connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@isadmin", 0);
                    command.ExecuteNonQuery();
                }

                StudentsDBHandler studentDBHandler = new StudentsDBHandler();

                studentDBHandler.AddStudent(id, name, batch, email, contact);

            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g. log the error or throw a custom exception
                Console.WriteLine("An error occurred while adding the user: " + ex.Message);
            }
        }

        public void DeleteUser(int id)
        {

        }
        public void UpdateUser(User user)
        {

        }
        public User GetUser(string username, string password)
        {
            string query = "SELECT * FROM users WHERE RollNumber = @username AND password = @password";
            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader.GetString(0));
                        string db_user = reader.GetString(1);
                        string db_pass = reader.GetString(2);
                        bool isadmin = reader.GetBoolean(3);
                        User user = new User(id, username, password, isadmin);
                        return user;
                    }
                }
            }
            // User not found, return null
            return null;
        }
        public List<User> GetAllUsers()
        {
            // Add your code here to retrieve all users

            // Return the list of users
            return new List<User>();
        }

    }
}
