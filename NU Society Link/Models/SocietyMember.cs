using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NU_Society_Link.Models
{
    public class SocietyMember : Student
    {
        public new string RollNum { get; set; }
        public int SocietyId { get; set; }
        public string MemberPosition { get; set; }
        public string SocietyName { get; set; }

        public SocietyMember(string rollNum, int societyId, string memberName, string memberEmail, string memberContact, string memberPosition, string memberBatch)
            : base(rollNum,memberName, memberEmail, memberContact, memberBatch)
        {
            SocietyId = societyId;
            MemberPosition = memberPosition;
        }

        public SocietyMember(int societyId, Student student, string memberPosition, string sname)
            : base(student.RollNum,student.Name, student.Email, student.Contact, student.Batch)
        {
            SocietyId = societyId;
            SocietyName = sname;
            MemberPosition = memberPosition;
        }
    }
}
