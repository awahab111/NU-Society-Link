using System.Diagnostics;
using NU_Society_Link;
using NU_Society_Link.Models;
using NU_Society_Link.Presenter;

namespace NU_Society_Link.DBHandlers
{
    public class SocietyMembersDBHandler
    {
        Database db;
        public SocietyMembersDBHandler()
        {
            db = Database.GetInstance;
        }

        public List<SocietyMember> GetMembers(int societyId)
        {
            List<SocietyMember> members = new List<SocietyMember>();
            string query = @"
                select RollNum, SocietyId, Name, Email, contact, MemberPosition, batch
                from SocietyMembers
                Inner join Students on students.rollnumber = SocietyMembers.RollNum
                where SocietyId = @societyId";
            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@societyId", societyId);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rollNum = reader.GetString(0);
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
            string query = @"
                select  students.rollnumber, SocietyId, Name, Email, contact, MemberPosition, batch
                from SocietyMembers
                right join Students on students.rollnumber = SocietyMembers.RollNum
                where students.rollnumber= @rollNum";

            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@rollNum", rollNum);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int societyId = reader.GetInt32(1);
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


        public SocietyMember GetMember(Student s)
        {
            string query = @"
                select  SocietyName,SocietyMembers.SocietyId, MemberPosition
                from SocietyMembers
                Inner join Society on Society.societyid = SocietyMembers.SocietyId
                where SocietyMembers.rollnum= @rollNums";

            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@rollNums", s.RollNum);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var societyName = reader.GetString(0);
                        var societyId = reader.GetInt32(1);
                        var memberPosition = reader.GetString(2);

                        Debug.WriteLine("Society Name: " + societyName);

                        var member = new SocietyMember(societyId, s, memberPosition, societyName);
                        return member;
                    }
                }
            }
            return null;
        }

        public bool AddMember(string memberPosition, string rollNum, int societyId)
        {
            try
            {
                string query = @"insert into SocietyMembers (RollNum, SocietyId, MemberPosition) values (@rollNum, @societyId, @memberPosition)";
                using (var command = db.connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@rollNum", rollNum);
                    command.Parameters.AddWithValue("@societyId", societyId);
                    command.Parameters.AddWithValue("@memberPosition", memberPosition);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

    }




}