using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NU_Society_Link.Models
{
    public class Society
    {
        private string societyName;
        private string societyDescription;
        private string societyType;
        private string societySupervisor;
        private string societySupervisorContact;
        private string societySupervisorEmail;
        private string? societySupervisorDesignation;
        private string? societySupervisorDepartment;

        private string societyLogo;

        public Society(string societylogo, string societyName, string societyDescription, string societyType,string societySupervisor, string societySupervisorContact, string societySupervisorEmail, string societySupervisorDesignation, string societySupervisorDepartment)
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
        }

        public string SocietyName { get => societyName; set => societyName = value; }
        public string SocietyDescription { get => societyDescription; set => societyDescription = value; }
        public string SocietyType { get => societyType; set => societyType = value; }
        public string SocietySupervisor { get => societySupervisor; set => societySupervisor = value; }
        public string SocietySupervisorContact { get => societySupervisorContact; set => societySupervisorContact = value; }
        public string SocietySupervisorEmail { get => societySupervisorEmail; set => societySupervisorEmail = value; }
        public string? SocietySupervisorDesignation { get => societySupervisorDesignation; set => societySupervisorDesignation = value; }
        public string? SocietySupervisorDepartment { get => societySupervisorDepartment; set => societySupervisorDepartment = value; }
        public string SocietyLogo { get => societyLogo; set => societyLogo = value; }
    }
}