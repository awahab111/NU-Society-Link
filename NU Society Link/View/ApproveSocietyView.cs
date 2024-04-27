using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NU_Society_Link.Models;

namespace NU_Society_Link.View
{
    public partial class ApproveSocietyView : Form
    {
        public event EventHandler ListViewClick;
        public event EventHandler Reload;

        private ApproveSocietyView()
        {
            InitializeComponent();
            societyListView.SelectedIndexChanged += delegate { ListViewClick?.Invoke(null, EventArgs.Empty); };
        }

        public void getSocieties(List<Society> societies)
        {
            societyListView.Items.Clear();
            foreach (Society society in societies)
            {
                if (society.isApproved) continue;
                ListViewItem item = new ListViewItem(society.societyID.ToString());
                item.SubItems.Add(society.SocietyName);
                item.SubItems.Add(society.SocietySupervisor);
                item.SubItems.Add(society.SocietyDescription);
                societyListView.Items.Add(item);
            }
        }

        public string getSelectedItem()
        {
            if (this.societyListView.SelectedItems.Count == 0)
            {
                return null;
            }
            ListViewItem selectedItem = societyListView.SelectedItems[0];
            string selectedSocietyId = selectedItem.SubItems[0].Text;
            return selectedSocietyId;
        }

        private static ApproveSocietyView instance;

        public static ApproveSocietyView GetInstance(Form parent)
        {
            if (instance == null)
            {
                instance = new ApproveSocietyView();
                instance.MdiParent = parent;
                instance.StartPosition = FormStartPosition.CenterScreen;
                instance.FormBorderStyle = FormBorderStyle.None;
            }
            return instance;
        }

        // Reload the societies
        public void ReloadSocieties()
        {
            Reload?.Invoke(null, EventArgs.Empty);
        }

        public void Delete()
        {
            this.Dispose();
            instance = null;
            this.Close();
        }

    }
}
