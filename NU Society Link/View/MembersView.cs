using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NU_Society_Link.Models;

namespace NU_Society_Link.View
{
    public partial class MembersView : Form
    {

        public event EventHandler? SearchMembers;

        public event EventHandler? AddMember;

        public string SearchQuery => txtSearch.Text;

        public string SetWarning
        {
            set => lblWarning.Text = value;
        }

        private MembersView()
        {
            InitializeComponent();
            btnSearch.Click += delegate { SearchMembers?.DynamicInvoke(this, EventArgs.Empty); };
            btnAddMember.Click += delegate { AddMember?.DynamicInvoke(this, EventArgs.Empty); };
            
        }

        private static MembersView? instance;

        public static MembersView GetInstance(MainView view)
        {
            if (instance == null)
            {
                instance = new MembersView();
                instance.MdiParent = view;
                instance.Dock = DockStyle.Fill;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Show();
            }
            return instance;
        }

        public void Delete()
        {
            this.Dispose();
            instance = null;
            this.Close();
        }

        public void PopulateGridView(DataTable members)
        {
            dgvMembers.DataSource = null;
            dgvMembers.Columns.Clear();
            dgvMembers.DataSource = members;
        }

    }
}
