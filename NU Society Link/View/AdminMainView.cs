﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using NU_Society_Link.Models;

namespace NU_Society_Link.View
{
    public partial class AdminMainView : Form
    {
        public AdminMainView()
        {
            InitializeComponent();
            AssociateandraiseEvents();
        }

        void AssociateandraiseEvents()
        {
            ApproveSociety.Click += delegate { ApproveSocietyClick?.Invoke(null, EventArgs.Empty); };
            BackButton.Click += delegate { BackButtonClicked?.Invoke(null, EventArgs.Empty); };
            LogoutButton.Click += delegate { LogoutButtonClicked?.Invoke(null, EventArgs.Empty); };
            EventsButton.Click += delegate { EventsButtonClicked?.Invoke(null, EventArgs.Empty); };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler ApproveSocietyClick;
        public event EventHandler BackButtonClicked;
        public event EventHandler LogoutButtonClicked;
        public event EventHandler EventsButtonClicked;

    }
}
