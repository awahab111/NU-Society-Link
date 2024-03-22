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

        public void SaveSociety(Society society)
        {
            string query = @"INSERT INTO Society (SocietyName, SocietyDescription, SocietyType, SocietySupervisor, SocietySupervisorContact, SocietySupervisorEmail, SocietySupervisorDesignation, SocietySupervisorDepartment, SocietyLogoBase64)
                            VALUES (@societyName, @societyDescription, @societyType, @societySupervisor, @societySupervisorContact, @societySupervisorEmail, @societySupervisorDesignation, @societySupervisorDepartment, @societyLogoBase64)";

            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@societyName", society.SocietyName);
                command.Parameters.AddWithValue("@societyDescription", society.SocietyDescription);
                command.Parameters.AddWithValue("@societyType", society.SocietyType);
                command.Parameters.AddWithValue("@societySupervisor", society.SocietySupervisor);
                command.Parameters.AddWithValue("@societySupervisorContact", society.SocietySupervisorContact);
                command.Parameters.AddWithValue("@societySupervisorEmail", society.SocietySupervisorEmail);
                command.Parameters.AddWithValue("@societySupervisorDesignation", society.SocietySupervisorDesignation);
                command.Parameters.AddWithValue("@societySupervisorDepartment", society.SocietySupervisorDepartment);
                command.Parameters.AddWithValue("@societyLogoBase64", society.SocietyLogo);
                command.ExecuteNonQuery();
            }
        }

        public void ApproveSociety(int societyID)
        {
            string query = @"UPDATE Society SET IsApproved = 1 WHERE SocietyID = @societyID";
            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@societyID", societyID);
                command.ExecuteNonQuery();
            }
        }

        public List<Society> GetSocieties()
        {
            List<Society> societies = new List<Society>();
            string query = @"SELECT * FROM Society";
            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var societyID = reader.GetInt32(0);
                        var societyName = reader.GetString(1);
                        var societyDescription = reader.GetString(2);
                        var societyType = reader.GetString(3);
                        var societySupervisor = reader.GetString(4);
                        var societySupervisorContact = reader.GetString(5);
                        var societySupervisorEmail = reader.GetString(6);
                        var societySupervisorDesignation = reader.GetString(7);
                        var societySupervisorDepartment = reader.GetString(8);
                        var societyLogo = reader.GetString(9);
                        var isApproved = reader.GetBoolean(10);
                        Society society = new Society(societyLogo, societyName, societyDescription, societyType, societySupervisor, societySupervisorContact, societySupervisorEmail, societySupervisorDesignation, societySupervisorDepartment, isApproved)
                        {
                            SocietyId = societyID
                        };
                        societies.Add(society);
                    }
                }
            }
            return societies;
        }

        public Society GetSociety(int societyID)
        {
            Society society = null;
            string query = @"SELECT * FROM Society WHERE SocietyID = @societyID";
            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@societyID", societyID);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var societyName = reader.GetString(1);
                        var societyDescription = reader.GetString(2);
                        var societyType = reader.GetString(3);
                        var societySupervisor = reader.GetString(4);
                        var societySupervisorContact = reader.GetString(5);
                        var societySupervisorEmail = reader.GetString(6);
                        var societySupervisorDesignation = reader.GetString(7);
                        var societySupervisorDepartment = reader.GetString(8);
                        var societyLogo = reader.GetString(9);
                        var isApproved = reader.GetBoolean(10);
                        society = new Society(societyLogo, societyName, societyDescription, societyType, societySupervisor, societySupervisorContact, societySupervisorEmail, societySupervisorDesignation, societySupervisorDepartment, isApproved)
                        {
                            SocietyId = societyID
                        };
                    }
                }
            }
            return society;
        }

        public Society GetSociety(string name){
            Society society = null;
            string query = @"SELECT * FROM Society WHERE SocietyName = @name";
            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@name", name);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {   
                        var societyID = reader.GetInt32(0);
                        var societyName = reader.GetString(1);
                        var societyDescription = reader.GetString(2);
                        var societyType = reader.GetString(3);
                        var societySupervisor = reader.GetString(4);
                        var societySupervisorContact = reader.GetString(5);
                        var societySupervisorEmail = reader.GetString(6);
                        var societySupervisorDesignation = reader.GetString(7);
                        var societySupervisorDepartment = reader.GetString(8);
                        var societyLogo = reader.GetString(9);
                        var isApproved = reader.GetBoolean(10);
                        society = new Society(societyLogo, societyName, societyDescription, societyType, societySupervisor, societySupervisorContact, societySupervisorEmail, societySupervisorDesignation, societySupervisorDepartment, isApproved);
                        society.SocietyId = societyID;
                    }
                }
            }
            return society;
        }

    }

}