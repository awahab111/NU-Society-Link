using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NU_Society_Link.View
{
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
            AssociateandRaiseEvents();
        }

        public int Society_id { get; set; }
        public event EventHandler? SaveEvent;

        private static AddEvent? instance;

        
        

        public string Society_name
        {
            get { return txtSocietyName.Text; }
            set { value = txtSocietyName.Text; }
        }

        public string Event_type { get { return txtEventType.Text; } set { txtEventType.Text = value; } }
        public string Event_title
        {
            get { return txtEventName.Text; }
            set { txtEventName.Text = value; }
        }


        public DateTime start_time
        {
            get { return StartTime.Value; }

            set { StartTime.Value = value; }
        }
        public DateTime end_time
        {
            get { return EndTime.Value; }
            set { EndTime.Value = value; }
        }

        public string expected_participants { get { return txtExpParticipants.Text; } set { txtExpParticipants.Text = value.ToString(); } }

        public string venue_name
        {
            get { return txtVenueName.Text; }
            set { txtVenueName.Text = value; }
        }
        public string Event_description
        {
            get { return txtEventDesc.Text; }
            set { txtEventDesc.Text = value; }
        }

        public string Event_Requirements
        {
            get { return rtbEventReq.Text; }
            set { rtbEventReq.Text = value; }
        }
        public void success()
        {
            flaglbl.ForeColor = Color.Green;
            flaglbl.Text = "Request Sent";
        }

        public string flaglabel {
            get { return flaglbl.Text; }

            set { flaglbl.Text = value; } }


        public static AddEvent GetInstance(Form parentContainer)
        {
            if (instance == null)
            {
                instance = new AddEvent();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }

        void AssociateandRaiseEvents()
        {
            btnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
        }
        public void Delete()
        {
            this.Dispose();
            instance = null;
            this.Close();
        }
    }
}
