using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using NU_Society_Link.Models;

namespace NU_Society_Link.View
{
    public partial class MainView : Form
    {

        public event EventHandler? AddSociety;

        public event EventHandler? MembersView;

        public MainView()
        {
            InitializeComponent();
            AssociateandRaiseEvents();
        }

        void AssociateandRaiseEvents(){
            AddSocietybtn.Click += delegate { AddSociety?.Invoke(this, EventArgs.Empty); };
            Membersbtn.Click += delegate { MembersView?.Invoke(this, EventArgs.Empty); };
        }
        
        

    }
}
