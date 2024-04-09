using Microsoft.VisualBasic;
using NU_Society_Link.DBHandlers;
using System.Data.SqlClient;

namespace NU_Society_Link.Models
{
    public class SocietyDBHandler
    {
        Database db;
        public SocietyDBHandler()
        {
            db = Database.GetInstance;
        }


        public List<Event> GetCurrentEvents(int societyId)
        {
            List<Event> events = new List<Event>();


            string query = @"SELECT * FROM Events 
                          WHERE Society_id = @SocietyId 
                          AND Start_time <= GETDATE() 
                          AND End_time >= GETDATE()";
            SqlCommand command = new SqlCommand(query, db.connection);
            command.Parameters.AddWithValue("@SocietyId", societyId);

            try
            {

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Event e = new Event();
                    e.Society_id = Convert.ToInt32(reader["Society_id"]);
                    e.Society_name = reader["Society_name"].ToString();
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

        public void SaveSociety(string societyName, string pres, string societyDescription, string societyType, string societySupervisor, string societySupervisorContact, string societySupervisorEmail, string societySupervisorDesignation, string societySupervisorDepartment, string societyLogo)
        {
            string query = @"INSERT INTO Society (SocietyName, SocietyPresident,SocietyDescription, SocietyType, SocietySupervisor, SocietySupervisorContact, SocietySupervisorEmail, SocietySupervisorDesignation, SocietySupervisorDepartment, SocietyLogoBase64)
                            VALUES (@societyName, @pres, @societyDescription, @societyType, @societySupervisor, @societySupervisorContact, @societySupervisorEmail, @societySupervisorDesignation, @societySupervisorDepartment, @societyLogoBase64)";

            using var command = db.connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@societyName", societyName);
            command.Parameters.AddWithValue("@pres", pres);
            command.Parameters.AddWithValue("@societyDescription", societyDescription);
            command.Parameters.AddWithValue("@societyType", societyType);
            command.Parameters.AddWithValue("@societySupervisor", societySupervisor);
            command.Parameters.AddWithValue("@societySupervisorContact", societySupervisorContact);
            command.Parameters.AddWithValue("@societySupervisorEmail", societySupervisorEmail);
            command.Parameters.AddWithValue("@societySupervisorDesignation", societySupervisorDesignation);
            command.Parameters.AddWithValue("@societySupervisorDepartment", societySupervisorDepartment);
            command.Parameters.AddWithValue("@societyLogoBase64", societyLogo);
            command.ExecuteNonQuery();
        }

        public void ApproveSociety(int societyID)
        {
            string query = @"UPDATE Society SET IsApproved = 1 WHERE SocietyID = @societyID";
            using var command = db.connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@societyID", societyID);
            command.ExecuteNonQuery();
        }

        public List<Society> GetSocieties()
        {
            List<Society> societies = new List<Society>();

            string query = @"
                select SocietyId, SocietyPresident, SocietyName, SocietyDescription,
                SocietyType, SocietySupervisor, SocietySupervisorEmail,SocietyLogoBase64, IsApproved from Society ";

            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var societyID = reader.GetInt32(0);
                        var SocietyPresident = reader.GetString(1);
                        var societyName = reader.GetString(2);
                        var societyDescription = reader.GetString(3);
                        var societyType = reader.GetString(4);
                        var societySupervisor = reader.GetString(5);
                        var societySupervisorEmail = reader.GetString(6);
                        var societyLogo = reader.GetString(7);
                        var isApproved = reader.GetBoolean(8);
                        
                        Society society = new Society(societyID, societyName, societyDescription, societyType, societySupervisor, societySupervisorEmail,SocietyPresident , isApproved, societyLogo); // Include SocietyId parameter in constructor
                        societies.Add(society);
                    }
                }
            }
            return societies;
        }

        public Society GetSociety(int societyID)
        {
            string query = @"
                select SocietyId, SocietyPresident, SocietyName, SocietyDescription,
                SocietyType, SocietySupervisor, SocietySupervisorEmail,SocietyLogoBase64, IsApproved from Society 
                WHERE SocietyID = @societyID";
            using var command = db.connection.CreateCommand(); // Simplify using statement
            command.CommandText = query;
            command.Parameters.AddWithValue("@societyID", societyID);
            using var reader = command.ExecuteReader(); // Simplify using statement
            while (reader.Read())
            {
                var SocietyPresident = reader.GetString(1);
                var societyName = reader.GetString(2);
                var societyDescription = reader.GetString(3);
                var societyType = reader.GetString(4);
                var societySupervisor = reader.GetString(5);
                var societySupervisorEmail = reader.GetString(6);
                var societyLogo = reader.GetString(7);
                var isApproved = reader.GetBoolean(8);
                
                Society society = new Society(societyID, societyName, societyDescription, societyType, societySupervisor, societySupervisorEmail,SocietyPresident , isApproved, societyLogo); // Include SocietyId parameter in constructor
                return society;
            }
            return null;
        }

        public Society GetSociety(string name){
            string query = @"
                select SocietyId, SocietyPresident, SocietyName, SocietyDescription,
                SocietyType, SocietySupervisor, SocietySupervisorEmail,SocietyLogoBase64, IsApproved from Society 
                WHERE SocietyName = @name";
            using var command = db.connection.CreateCommand(); // Simplify using statement
            command.CommandText = query;
            command.Parameters.AddWithValue("@name", name);
            using var reader = command.ExecuteReader(); // Simplify using statement
            while (reader.Read())
            {
                var societyID = reader.GetInt32(0);
                var SocietyPresident = reader.GetString(1);
                var societyName = reader.GetString(2);
                var societyDescription = reader.GetString(3);
                var societyType = reader.GetString(4);
                var societySupervisor = reader.GetString(5);
                var societySupervisorEmail = reader.GetString(6);
                var societyLogo = reader.GetString(7);
                var isApproved = reader.GetBoolean(8);
                
                Society society = new Society(societyID, societyName, societyDescription, societyType, societySupervisor, societySupervisorEmail,SocietyPresident , isApproved, societyLogo); // Include SocietyId parameter in constructor
                return society;
            }
            return null;
        }

    }

}