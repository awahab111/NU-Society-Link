using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace NU_Society_Link.View
{
    public partial class UserLoginView : Form
    {
        public UserLoginView()
        {
            InitializeComponent();
            AssociateandRaiseEvents();
        }

        private void AssociateandRaiseEvents()
        {
            Loginbtn.Click += delegate { Login?.Invoke(this, EventArgs.Empty); };
            Registerbtn.Click += delegate { Register?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler? Login;
        public event EventHandler? Register;

        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LoginSuccess { get => Loginflag.Text; set => Loginflag.Text = value; }
        public string Username { get => TxtUsername.Text; set => throw new NotImplementedException(); }
        public string Password { get => TxtPassword.Text; set => throw new NotImplementedException(); }

        private static UserLoginView? instance;
        public static UserLoginView GetInstance(Form parentContainer)
        {
            if (instance == null)
            {
                instance = new UserLoginView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else {
                instance.BringToFront();
            }
            return instance;
        }

        public void DeleteInstance()
        {
            instance = null;
        }


    }
}
