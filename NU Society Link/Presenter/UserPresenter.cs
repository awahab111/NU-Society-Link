using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.Models;
using NU_Society_Link.View;
using NU_Society_Link.DBHandlers;
using System.Diagnostics;

namespace NU_Society_Link.Presenter
{
    public class UserPresenter
    {
        private UserLoginView view;
        private UserDBHandler model;

        public event EventHandler? LoginSuccess;

        public UserPresenter(UserLoginView view, UserDBHandler model)
        {
            this.view = view;
            this.model = model;
            this.view.Login += GetUser;
            this.view.Show();
        }

        void OnLoginSuccess()
        {
            LoginSuccess?.Invoke(this, EventArgs.Empty);
        }


        private void GetUser(object? sender, EventArgs e)
        {
            User currentuser =  model.GetUser(this.view.Username, this.view.Password);
            Debug.WriteLine("GetUser method called");
            if (currentuser == null)
            {
                this.view.LoginSuccess = "Login Failed!";
                return;
            }   
            else
            {
                this.view.LoginSuccess = "Login Success!";
                // ShowMainView();
                OnLoginSuccess();
            }    
        
        }

        
    }
}
