﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NU_Society_Link.View
{
    public partial class UserRegisterView : Form
    {

        public event EventHandler? Register;
        public event EventHandler? Login;


        public UserRegisterView()
        {
            InitializeComponent();
            AssociateandRaiseEvents();
        }

        private void AssociateandRaiseEvents()
        {
            btnRegister.Click += delegate { Register?.Invoke(this, EventArgs.Empty); };
            btnLogin.Click += delegate { Login?.Invoke(this, EventArgs.Empty); };
        }



        public string Username { get => txtUsername.Text; set => throw new NotImplementedException(); }
        public string Password { get => txtPassword.Text; set => throw new NotImplementedException(); }
        public string id { get => txtId.Text; set => throw new NotImplementedException(); }

        public string Contact { get => txtContact.Text; set => throw new NotImplementedException(); }

        public string Batch { get => txtBatch.Text; set => throw new NotImplementedException(); }

        public string StudentName { get => txtName.Text; set => throw new NotImplementedException(); }
        public string RegisterSuccess { get=> RegisterFlag.Text; set => RegisterFlag.Text = value; }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private static UserRegisterView? instance;
        public static UserRegisterView GetInstance(Form parentContainer)
        {
            if (instance == null)
            {
                instance = new UserRegisterView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else {
                instance.BringToFront();
            }
            return instance;
        }

    }
}
