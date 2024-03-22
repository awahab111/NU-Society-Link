using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NU_Society_Link.Models
{
    public class Society
    {
        private int societyID;
        private string societyName;
        private string societyDescription;
        private string societyType;
        private string societySupervisor;
        private string societySupervisorContact;
        private string societySupervisorEmail;
        private string? societySupervisorDesignation;
        private string? societySupervisorDepartment;

        private bool isApproved;

        private string societyLogo;

        public Society(string societylogo, string societyName, string societyDescription, string societyType,string societySupervisor, string societySupervisorContact, string societySupervisorEmail, string societySupervisorDesignation, string societySupervisorDepartment, bool isApproved)
        {
            this.societyName = societyName;
            this.societyDescription = societyDescription;
            this.societyType = societyType;
            this.societySupervisor = societySupervisor;
            this.societySupervisorContact = societySupervisorContact;
            this.societySupervisorEmail = societySupervisorEmail;
            this.societySupervisorDesignation = societySupervisorDesignation;
            this.societySupervisorDepartment = societySupervisorDepartment;
            this.societyLogo = societylogo;
            this.isApproved = isApproved;
        }
        
        public int SocietyId { get => societyID; set => societyID = value; }
        public string SocietyName { get => societyName; set => societyName = value; }
        public string SocietyDescription { get => societyDescription; set => societyDescription = value; }
        public string SocietyType { get => societyType; set => societyType = value; }
        public string SocietySupervisor { get => societySupervisor; set => societySupervisor = value; }
        public string SocietySupervisorContact { get => societySupervisorContact; set => societySupervisorContact = value; }
        public string SocietySupervisorEmail { get => societySupervisorEmail; set => societySupervisorEmail = value; }
        public string? SocietySupervisorDesignation { get => societySupervisorDesignation; set => societySupervisorDesignation = value; }
        public string? SocietySupervisorDepartment { get => societySupervisorDepartment; set => societySupervisorDepartment = value; }
        public string SocietyLogo { get => societyLogo; set => societyLogo = value; }
        public bool IsApproved { get => isApproved; set => isApproved = value; }
    }
}