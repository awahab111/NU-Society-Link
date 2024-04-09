using Microsoft.VisualBasic.ApplicationServices;
using NU_Society_Link.DBHandlers;
using NU_Society_Link.Models;
using NU_Society_Link.View;
using System;
using System.Collections.Generic;
using System.Data;

namespace NU_Society_Link.Presenters
{
    public class CurrentEventsPresenter
    {
        private CurrentEvents _view;
        private SocietyDBHandler _dbHandler;
        private Models.User _user;


        StudentsDBHandler dbHandler = new StudentsDBHandler();
        SocietyMembersDBHandler societyMembersDBHandler = new SocietyMembersDBHandler();

        public CurrentEventsPresenter(CurrentEvents view,Models.User u)
        {
            _user = u;
            _view = view;
            _dbHandler = new SocietyDBHandler(); // Initialize the database handler
            _view.SearchEvents += OnSearchEvents; // Subscribe to the SearchEvents event
            DisplayCurrentEvents();
        }

        private void OnSearchEvents(object? sender, EventArgs e)
        {
            // This method will be used if you decide to implement search functionality in the future
        }

        private void DisplayCurrentEvents()
        {
            // Call the database function to get current events

            Student std = dbHandler.GetStudent((_user.Id).ToString());
            SocietyMember member = societyMembersDBHandler.GetMember(std);

            List<Event> events = _dbHandler.GetCurrentEvents(member.SocietyId);

            // Populate the grid view in the view with the retrieved events
            _view.PopulateGridView(ConvertEventsToDataTable(events));
        }

        // Utility method to convert list of events to DataTable
        private DataTable ConvertEventsToDataTable(List<Event> events)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Society_id", typeof(int));
            dt.Columns.Add("Society_name", typeof(string));
            dt.Columns.Add("Event_type", typeof(string));
            dt.Columns.Add("Event_title", typeof(string));
            dt.Columns.Add("Start_time", typeof(DateTime));
            dt.Columns.Add("End_time", typeof(DateTime));
            dt.Columns.Add("Expected_participants", typeof(int));
            dt.Columns.Add("Venue_name", typeof(string));
            dt.Columns.Add("Event_description", typeof(string));
            dt.Columns.Add("Event_requirements", typeof(string));

            foreach (var ev in events)
            {
                dt.Rows.Add(ev.Society_id, ev.Society_name, ev.Event_type, ev.Event_title,
                    ev.start_time, ev.end_time, ev.expected_participants, ev.venue_name,
                    ev.Event_description, ev.Event_Requirements);
            }

            return dt;
        }
    }
}
