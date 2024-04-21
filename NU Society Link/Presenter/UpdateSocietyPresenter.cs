using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.View;
using NU_Society_Link.Models;

namespace NU_Society_Link.Presenter
{
    public class UpdateSocietyPresenter
    {
        private UpdateSocietyView view;
        private SocietyDBHandler societyDBHandler;

        private User user;

        public UpdateSocietyPresenter(UpdateSocietyView view, User u)
        {
            societyDBHandler = new SocietyDBHandler();
            this.user = u;
            this.view = view;
            this.view.UpdateSociety += UpdateSociety;
            this.view.Show();
        }

        internal void Dispose()
        {
            view.Dispose();
        }

        private void GetSocietyDetails(object? sender, EventArgs e)
        {
            Society society = societyDBHandler.GetSociety(view.SocietyName);
            view.SocietyName = society.SocietyName;
            view.Description = society.SocietyDescription;
            view.Type = society.SocietyType;
            view.Supervisor = society.SocietySupervisor;
            view.Email = society.SocietySupervisorEmail;
            view.Department = society.President;
            
            byte[] imageBytes = Convert.FromBase64String(society.SocietyLogo);

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                view.setImage(ms);
            }
        }

        private void UpdateSociety(object? sender, EventArgs e)
        {
            

            var logoBase64 = view.GetLogoBase64();
            var societyName = view.SocietyName;
            var description = view.Description;
            var type = view.Type;
            var supervisor = view.Supervisor;
            var contact = view.Contact;
            var email = view.Email;
            var designation = view.Designation;
            var department = view.Department;
            var president = this.user.Id;

            if (string.IsNullOrEmpty(societyName))
            {
                view.flag = "Enter Society Name";
                return;
            }

            if (string.IsNullOrEmpty(description))
            {
                view.flag = "Enter Description";
                return;
            }

            if (string.IsNullOrEmpty(type))
            {
                view.flag = "Enter Type";
                return;
            }

            if (string.IsNullOrEmpty(supervisor))
            {
                view.flag = "Enter Supervisor";
                return;
            }

            if (string.IsNullOrEmpty(contact))
            {
                view.flag = "Enter Contact";
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                view.flag = "Enter Email";
                return;
            }

            if (string.IsNullOrEmpty(designation))
            {
                view.flag = "Enter Designation";
                return;
            }

            if (string.IsNullOrEmpty(department))
            {
                view.flag = "Enter Department";
                return;
            }

            societyDBHandler.SaveSociety(societyName, president.ToString() ,description, type, supervisor, contact, email, designation, department, logoBase64);
            view.success();

        }

        // TODO create an admin panel from where the admin can view all the societies and approve them

    }
}
