using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NU_Society_Link.Models;

namespace NU_Society_Link.View
{
    public partial class CurrentEvents : Form
    {
        public event EventHandler? SearchEvents;
        public event EventHandler? SelectedEvent;

        public string SearchQuery => txtSearch.Text;

        public string SetWarning
        {
            set => lblWarning.Text = value;
        }

        private CurrentEvents()
        {
            InitializeComponent();
            btnSearch.Click += delegate { SearchEvents?.DynamicInvoke(this, EventArgs.Empty); };
            dgvEvents.SelectionChanged += delegate { SelectedEvent?.Invoke(this, EventArgs.Empty);};
        }

        private static CurrentEvents? instance;

        public static CurrentEvents GetInstance(Form view)
        {
            if (instance == null)
            {
                instance = new CurrentEvents();
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

        public void PopulateGridView(DataTable events)
        {
            dgvEvents.DataSource = null;
            dgvEvents.Columns.Clear();
            dgvEvents.DataSource = events;
        }

        public int GetSelectedItemData()
        {
            return dgvEvents.CurrentCell?.RowIndex ?? -1;
        }
    }
}
