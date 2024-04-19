using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NU_Society_Link.Models;

namespace NU_Society_Link.View
{
    public partial class EventInformationView : Form
    {
        public EventInformationView()
        {
            InitializeComponent();
            closeButton.Click += delegate { Close(); };
        }

        public void SetEventDetails(Event e, string headname)
        {
            headtxt.Text = e.HeadId;
            nameheadtxt.Text = headname;

            txtType.Text = e.Event_type;
            venuetxt.Text = e.venue_name;
            eventTitle.Text = e.Event_title;
            reqtxt.Text = e.Event_Requirements;
            desctxt.Text = e.Event_description;
            datestarttxt.Text = e.start_time.ToString("dd MMMM yyyy");
            timetxt.Text = e.start_time.ToString("HH:mm"); 

            TimeSpan duration = e.end_time - e.start_time;

            Durationtxt.Text = duration.ToString();
            parttxt.Text = e.expected_participants.ToString();
        }
    }
}
