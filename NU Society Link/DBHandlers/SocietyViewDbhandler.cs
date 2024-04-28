using NU_Society_Link.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NU_Society_Link.DBHandlers
{
    public class SocietyViewDbhandler
    {
        Database db;

        public SocietyViewDbhandler()
        {
            db = Database.GetInstance;
        }

        public List<Society> GetAllSocieties()
        {
            List<Society> societies = new List<Society>();

            try
            {
                using (var command = db.connection.CreateCommand())
                {
                    command.CommandText = "SELECT SocietyId, SocietyName, SocietyDescription, SocietyType, SocietySupervisor, SocietySupervisorEmail, SocietyPresident, IsApproved, SocietyLogoBase64 FROM Society";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int societyID = Convert.ToInt32(reader["SocietyId"]);
                            string societyName = reader["SocietyName"].ToString();
                            string societyDescription = reader["SocietyDescription"].ToString();
                            string societyType = reader["SocietyType"].ToString();
                            string societySupervisor = reader["SocietySupervisor"].ToString();
                            string societySupervisorEmail = reader["SocietySupervisorEmail"].ToString();
                            string president = reader["SocietyPresident"].ToString();
                            bool isApproved = Convert.ToBoolean(reader["IsApproved"]);
                            string societyLogo = reader["SocietyLogoBase64"].ToString();

                            Society society = new Society(societyID, societyName, societyDescription, societyType, societySupervisor, societySupervisorEmail, president, isApproved, societyLogo);
                            societies.Add(society);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("Error retrieving societies: " + ex.Message);
            }

            return societies;
        }
    }
}
