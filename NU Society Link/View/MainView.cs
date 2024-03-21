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

namespace NU_Society_Link.View
{
    public partial class MainView : Form
    {

        public event EventHandler? AddSociety;


        public MainView()
        {
            InitializeComponent();
            AssociateandRaiseEvents();
        }

        void AssociateandRaiseEvents(){
            AddSocietybtn.Click += delegate { AddSociety?.Invoke(this, EventArgs.Empty); };
        }
        
        

    }
}
