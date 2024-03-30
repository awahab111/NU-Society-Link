using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NU_Society_Link.Models
{
    public class Society
    {
        public int societyID;
        public string SocietyName;
        public string SocietyDescription;
        public string SocietyType;
        public string SocietySupervisor;
        public string SocietySupervisorEmail;
        public string President;
        public bool isApproved;
        public string SocietyLogo;
        public Society(int societyID, string societyName, string societyDescription, string societyType, string societySupervisor, string societySupervisorEmail, string President, bool isApproved, string societyLogo)
        {
            this.societyID = societyID;
            this.SocietyName = societyName;
            this.SocietyDescription = societyDescription;
            this.SocietyType = societyType;
            this.SocietySupervisor = societySupervisor;
            this.SocietySupervisorEmail = societySupervisorEmail;
            this.President = President;
            this.isApproved = isApproved;
            this.SocietyLogo = societyLogo;
        }
        
        
    }
}