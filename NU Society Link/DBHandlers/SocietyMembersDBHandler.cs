using NU_Society_Link;
using NU_Society_Link.Models;

namespace NU_Society_Link.DBHandlers
{
    public class SocietyMembersDBHandler
    {
        Database db;
        public SocietyMembersDBHandler()
        {
            db = Database.GetInstance;
        }

        public List<SocietyMember> GetMembers()
        {
            List<SocietyMember> members = new List<SocietyMember>();
            string query = @"select * from SocietyMembers";
            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rollNum = reader.GetString(0);
                        var societyId = reader.GetInt32(1);
                        var memberName = reader.GetString(2);
                        var memberEmail = reader.GetString(3);
                        var memberContact = reader.GetString(4);
                        var memberPosition = reader.GetString(5);
                        var memberBatch = reader.GetString(6);

                        var member = new SocietyMember(rollNum, societyId, memberName, memberEmail, memberContact, memberPosition, memberBatch);
                        members.Add(member);
                    }
                }
            }
            return members;
        }


        public SocietyMember GetMember(string rollNum)
        {
            string query = @"select * from SocietyMembers where RollNum = @rollNum";
            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@rollNum", rollNum);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var societyId = reader.GetInt32(1);
                        var memberName = reader.GetString(2);
                        var memberEmail = reader.GetString(3);
                        var memberContact = reader.GetString(4);
                        var memberPosition = reader.GetString(5);
                        var memberBatch = reader.GetString(6);

                        var member = new SocietyMember(rollNum, societyId, memberName, memberEmail, memberContact, memberPosition, memberBatch);
                        return member;
                    }
                }
            }
            return null;
        }   



    }




}