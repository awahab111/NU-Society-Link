using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.DBHandlers;
using NU_Society_Link.Models;
using NU_Society_Link.Presenter;
using NU_Society_Link.View;

namespace NU_Society_Link.Presenter
{
    public class EventInformationPresenter
    {
        private MainView parentView;
        private CurrentEvents currentEventsView;
        private EventInformationView eventInformationView;
        private Models.User user;
        private Event eventDetails;

        private StudentsDBHandler student_db = new StudentsDBHandler();

        public EventInformationPresenter(EventInformationView view, Models.User u, MainView p, CurrentEvents c, Event e)
        {
            user = u;
            eventInformationView = view;
            parentView = p;
            currentEventsView = c;
            eventDetails = e;
            
            eventInformationView = view;
            eventInformationView.MdiParent = parentView;
            eventInformationView.Dock = System.Windows.Forms.DockStyle.Fill;
            eventInformationView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;            
        
            eventInformationView.SetEventDetails(e, student_db.GetStudent(e.HeadId).Name);
            eventInformationView.Show();

        }


    }
}
