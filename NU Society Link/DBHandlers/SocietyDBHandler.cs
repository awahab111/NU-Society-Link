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
    }

}