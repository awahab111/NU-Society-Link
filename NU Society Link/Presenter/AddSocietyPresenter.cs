using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.View;
using NU_Society_Link.Models;

namespace NU_Society_Link.Presenter
{
    public class AddSocietyPresenter
    {
        private AddSocietyView view;
        private SocietyDBHandler societyDBHandler;

        public AddSocietyPresenter(AddSocietyView view)
        {
            societyDBHandler = new SocietyDBHandler();
            this.view = view;
            this.view.SaveSociety += SaveSociety;
            this.view.Show();
        }

        internal void Dispose()
        {
            view.Dispose();
        }

        private void SaveSociety(object? sender, EventArgs e)
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

            societyDBHandler.SaveSociety(new Society(logoBase64, societyName, description, type, supervisor, contact, email, designation, department, false));
        }

        // TODO create an admin panel from where the admin can view all the societies and approve them

    }
}
