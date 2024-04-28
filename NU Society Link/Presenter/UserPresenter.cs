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

        public event EventHandler? UserLogin;
        public event EventHandler? AdminLogin;


        public UserPresenter(UserLoginView view, UserDBHandler model)
        {
            this.view = view;
            this.model = model;
            this.view.Login += GetUser;
            this.view.Show();
        }

        void OnUserLogin()
        {
            UserLogin?.Invoke(this, EventArgs.Empty);
        }

        
        void OnAdminLogin()
        {
            AdminLogin?.Invoke(this, EventArgs.Empty);
        }


        private void GetUser(object? sender, EventArgs e)
        {
            if (this.view.Username == "" || this.view.Password == "")
            {
                this.view.LoginSuccess = "Login Failed!";
                return;
            }
            if (this.view.Username == "Username" || this.view.Password == "Password")
            {
                this.view.LoginSuccess = "Login Failed!";
                return;
            }
            User currentuser =  model.GetUser(this.view.Username, this.view.Password);
            Debug.WriteLine("GetUser method called");
            if (currentuser == null)
            {
                this.view.LoginSuccess = "Login Failed!";
                return;
            }   
            else if(currentuser.isAdmin == true){
                this.view.LoginSuccess = "Login Success!";
                OnAdminLogin();
            }
            else{
                this.view.LoginSuccess = "Login Success!";
                OnUserLogin();
            }    
        
        }

        
    }
}
