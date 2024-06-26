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
    public partial class AddMemberView : Form
    {
        public event EventHandler? AddMember;
        public AddMemberView()
        {
            InitializeComponent();
            btnAddMember.Click += delegate { AddMember?.Invoke(this, EventArgs.Empty); };
        }

        public string GetMemberPosition => txtMemberPosition.Text;
        public string GetRollNum => txtRollNum.Text;

        public string flag
        {
            set
            {
                lblflag.Text = value;
            }
        }

        public Label Flag => lblflag;

    }
}
