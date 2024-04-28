using System;
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
    public partial class EventSummaries : Form
    {
        public EventSummaries()
        {
            InitializeComponent();
        }

        private static EventSummaries? instance;

        public static EventSummaries GetInstance(Form view)
        {
            if (instance == null)
            {
                instance = new EventSummaries();
                instance.MdiParent = view;
                instance.Dock = DockStyle.Fill;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Show();
            }
            return instance;
        }

        public void Delete()
        {
            if (instance != null)
            {
                instance.Dispose();
                instance = null;
            }
        }


        // Method to set event details in the form controls
        public void SetEventSummary(string eventTitle, string summary, int numberParticipants)
        {
            txtEventTitle.Text = eventTitle;
            txtSummary.Text = summary;
            txtNumberParticipants.Text = numberParticipants.ToString();
        }

        // Method to retrieve event title from the form
        public string GetEventTitle()
        {
            return txtEventTitle.Text;
        }

        // Method to retrieve summary from the form
        public string GetSummary()
        {
            return txtSummary.Text;
        }

        // Method to retrieve number of participants from the form
        public int GetNumberParticipants()
        {
            int numberParticipants;
            if (int.TryParse(txtNumberParticipants.Text, out numberParticipants))
            {
                return numberParticipants;
            }
            else
            {
                // Handle invalid input
                return -1; // or throw an exception
            }
        }
    }
}
