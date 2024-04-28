using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.View;
using NU_Society_Link.DBHandlers;
using System.Diagnostics;

namespace NU_Society_Link.Presenter
{
    public class UserRegisterPresenter
    {
        private UserRegisterView view;
        private UserDBHandler model;

        public UserRegisterPresenter(UserRegisterView view, UserDBHandler model)
        {
            this.view = view;
            this.model = model;
            this.view.Register += createUser;
            this.view.Show();
        }

        private void createUser(object? sender, EventArgs e)
        {

            if (this.view.Username == "" || this.view.Password == "" || this.view.StudentName == "" || this.view.Batch == "" || this.view.Contact == "")
            {
                this.view.RegisterSuccess = "Registration Failed!";
                return;
            }
            if (this.view.id.Length >4 || this.view.id.Length < 4){
                this.view.RegisterSuccess = "Incorrect ID!";
                return;
            }
            if(this.view.Username.Length <= 2 || this.view.Username.Length >=17){
                this.view.RegisterSuccess = "Incorrect username length!";
                return;
            }
            if (this.view.Password.Length <= 7 || this.view.Password.Length >= 11)
            {
                this.view.RegisterSuccess = "Password length incorrect!";
                return;
            }
            if (!int.TryParse(this.view.Batch, out int year))
            {
                this.view.RegisterSuccess = "Invalid year format!";
                return;
            }
            if (year < DateTime.Now.Year - 5 || year > DateTime.Now.Year)
            {
                this.view.RegisterSuccess = "Invalid year!";
                return;
            }
            if (this.view.Name.Length <= 2 || this.view.Name.Length >= 33)
            {
                this.view.RegisterSuccess = "Invalid name!";
                return;
            }
            if (this.view.Contact.Length != 11)
            {
                this.view.RegisterSuccess = "Invalid contact!";
                return;
            }
            if (!int.TryParse(this.view.id, out int id))
            {
                this.view.RegisterSuccess = "Invalid ID!";
                return;
            }
            if (this.model.GetUser(this.view.Username, this.view.Password) != null)
            {
                this.view.RegisterSuccess = "User already exists!";
                return;
            }

            model.AddUser(int.Parse(this.view.id), this.view.Username, this.view.Password, this.view.StudentName, this.view.Batch, this.view.id+"@nu.edu.pk", this.view.Contact);
            Debug.WriteLine("User created");
            this.view.Close();
        }
    }
}
