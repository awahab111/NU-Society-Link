using Microsoft.VisualBasic.ApplicationServices;
using NU_Society_Link.DBHandlers;
using NU_Society_Link.Models;
using NU_Society_Link.Presenter;
using NU_Society_Link.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace NU_Society_Link.Presenters
{
    public class CurrentEventsPresenter
    {

        private MainView parentView;
        private CurrentEvents _view;
        private Models.User _user;



        private StudentsDBHandler student_db = new StudentsDBHandler();
        private SocietyMembersDBHandler societyMembersDBHandler = new SocietyMembersDBHandler();
        private SocietyDBHandler societyDBHandler;

        private EventsDBHandler eventsDBHandler = new EventsDBHandler();

        private DataTable dt;


        public CurrentEventsPresenter(CurrentEvents view,Models.User u, MainView p)
        {
            _user = u;
            _view = view;
            parentView = p;

            societyDBHandler = new SocietyDBHandler();
            _view.SearchEvents += OnSearchEvents; 
            DisplayCurrentEvents();
        }

        private void OnSelectedEvent(object? sender, EventArgs e)
        {
            this._view.SelectedEvent -= OnSelectedEvent;
            int index = _view.GetSelectedItemData();
            Debug.WriteLine(index);
            if (index >= 0)
            {
                string title = dt.Rows[index].Field<string>("Title");
                string type = dt.Rows[index].Field<string>("Type");
                string venue = dt.Rows[index].Field<string>("Venue");
                Event ev = eventsDBHandler.GetEvent(title, type, venue);

                EventInformationView eventDetailsView = new EventInformationView();
                EventInformationPresenter eventDetailsPresenter = new EventInformationPresenter(eventDetailsView, _user, parentView, _view, ev);
                this._view.SelectedEvent += OnSelectedEvent;
            }
        }
        private void OnSearchEvents(object? sender, EventArgs e)
        {
            DataTable dt = DisplayCurrentEvents();
            dt.DefaultView.RowFilter = string.Format("Title LIKE '%{0}%' OR TYPE LIKE '%{0}%'", _view.SearchQuery);
            _view.PopulateGridView(dt);
        }

        private DataTable DisplayCurrentEvents()
        {
            Student std = student_db.GetStudent((_user.Id).ToString());
            SocietyMember member = societyMembersDBHandler.GetMember(std);

            List<Event> events = societyDBHandler.GetCurrentEvents(member.SocietyId);
            DataTable dt = ConvertEventsToDataTable(events);
            _view.PopulateGridView(dt);
            this._view.SelectedEvent += OnSelectedEvent;
            return dt;
        }

        // Utility method to convert list of events to DataTable
        private DataTable ConvertEventsToDataTable(List<Event> events)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Date Time", typeof(DateTime));
            dt.Columns.Add("Venue", typeof(string));

            foreach (var ev in events)
            {
                dt.Rows.Add(ev.Event_title, ev.Event_type,
                    ev.start_time, ev.venue_name);
            }
            this.dt = dt;

            return dt;
        }

        internal void Dispose()
        {
            _view.Delete();
        }

    }
}
