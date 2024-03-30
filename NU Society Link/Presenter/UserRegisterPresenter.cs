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
            model.AddUser(this.view.id, this.view.Username, this.view.Password, this.view.StudentName, this.view.Batch, this.view.Email, this.view.Contact);
            Debug.WriteLine("User created");
            this.view.Close();
        }
    }
}
