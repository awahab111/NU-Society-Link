using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NU_Society_Link.Models
{
    public class SocietyMember
    {
        public string RollNum { get; set; }
        public int SocietyId { get; set; }
        public string MemberName { get; set; }
        public string MemberEmail { get; set; }
        public string MemberContact { get; set; }
        public string MemberPosition { get; set; }
        public string MemberBatch { get; set; }

        public SocietyMember(string rollNum, int societyId, string memberName, string memberEmail, string memberContact, string memberPosition, string memberBatch)
        {
            RollNum = rollNum;
            SocietyId = societyId;
            MemberName = memberName;
            MemberEmail = memberEmail;
            MemberContact = memberContact;
            MemberPosition = memberPosition;
            MemberBatch = memberBatch;
        }
    }
}
