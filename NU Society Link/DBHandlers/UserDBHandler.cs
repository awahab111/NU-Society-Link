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

        public void AddUser(int id, string username, string password, string email)
        {
            string query = "INSERT INTO users (RollNumber, username, password, email) VALUES (@id, @username, @password, @email)";
            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);
                command.ExecuteNonQuery();
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
            
            string query = "SELECT * FROM users WHERE username = @username AND password = @password";
            // Add your code here to retrieve the user based on the username

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
                        User user = new User(id, username, password);
                        return user;
                    }
                }
            }
            // Return the user
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
