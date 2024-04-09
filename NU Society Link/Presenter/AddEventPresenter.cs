using System;
using NU_Society_Link.DBHandlers;
using NU_Society_Link.Models;
using NU_Society_Link.View;

namespace NU_Society_Link.Presenter
{
    public class AddEventPresenter
    {
        private AddEvent view;
        private SocietyDBHandler societyDBHandler;
        
        private User user;

        StudentsDBHandler dbHandler = new StudentsDBHandler();
        SocietyMembersDBHandler societyMembersDBHandler = new SocietyMembersDBHandler();

       


        public AddEventPresenter(AddEvent view, User u)
        {
            societyDBHandler = new SocietyDBHandler();
            this.user = u;
            this.view = view;
            this.view.SaveEvent += SaveEvent;
            this.view.Show();
        }

        internal void Dispose()
        {
            view.Dispose();
        }
        public bool IsNullOrEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }


        private void SaveEvent(object? sender, EventArgs e)
        {
            var flag = view.flaglabel;
            var society_name = view.Society_name;
            var eventName = view.Event_title;
            var eventType = view.Event_type;
            var startTime = view.start_time;
            var endTime = view.end_time;
            var expectedParticipants = view.expected_participants;
            var venueName = view.venue_name;
            var eventDescription = view.Event_description;
            var eventRequirements = view.Event_Requirements;

            Student std = dbHandler.GetStudent((user.Id).ToString());
            SocietyMember member = societyMembersDBHandler.GetMember(std);


            if (IsNullOrEmpty(view.Society_name))
            {
                view.flaglabel = "Enter Society Name";
                return;
            }

            if (IsNullOrEmpty(view.Event_title))
            {
                view.flaglabel = "Enter Event Title";
                return;
            }

            if (IsNullOrEmpty(view.Event_type))
            {
                view.flaglabel = "Enter Event Type";
                return;
            }

            // For DateTime fields, you can handle null values if applicable
            if (view.start_time == null)
            {
                view.flaglabel = "Select Start Time";
                return;
            }

            if (view.end_time == null)
            {
                view.flaglabel = "Select End Time";
                return;
            }

            if (IsNullOrEmpty(view.venue_name))
            {
                view.flaglabel = "Enter Venue Name";
                return;
            }

            if (IsNullOrEmpty(view.Event_description))
            {
                view.flaglabel = "Enter Event Description";
                return;
            }

            if (IsNullOrEmpty(view.Event_Requirements))
            {
                view.flaglabel = "Enter Event Requirements";
                return;
            }


            societyDBHandler.SaveEvent(member.SocietyId, society_name, eventType, eventName, startTime, endTime, expectedParticipants, venueName, eventDescription, eventRequirements);

            view.success();
        }
        // TODO: Add methods for additional functionalities as needed

    }
}
