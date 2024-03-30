using Microsoft.VisualBasic;
using NU_Society_Link.DBHandlers;

namespace NU_Society_Link.Models
{
    public class SocietyDBHandler
    {
        Database db;
        public SocietyDBHandler()
        {
            db = Database.GetInstance;
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