using NU_Society_Link.DBHandlers;
using NU_Society_Link.View;
using System;
using System.Windows.Forms;

namespace NU_Society_Link.Presenter
{
    public class EventSummaryPresenter
    {
        private EventSummaries view;
        private EventSummaryDBHandler eventSummaryDBHandler;

        public EventSummaryPresenter(EventSummaries view)
        {
            this.view = view;
            InitializeEventHandlers();
            eventSummaryDBHandler = new EventSummaryDBHandler();
        }

        private void InitializeEventHandlers()
        {
            view.btnSave.Click += btnSave_Click;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {


            

            string eventTitle = view.GetEventTitle();
            string summary = view.GetSummary();
            int numberParticipants = view.GetNumberParticipants();
            string message = $"{eventTitle} {summary} {numberParticipants}";
           


            if (string.IsNullOrWhiteSpace(eventTitle) || string.IsNullOrWhiteSpace(summary) || numberParticipants < 0)
            {
                MessageBox.Show("Please fill in all fields and provide a valid number of participants.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (eventSummaryDBHandler.CheckEventSummaryExists(eventTitle))
            {
                
                MessageBox.Show("Error: Event summary already exists for this event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

               
                eventSummaryDBHandler.SaveEventSummary(eventTitle, summary, numberParticipants);
                MessageBox.Show ("Event summary saved.");
            }
        }

        public void Dispose()
        {
            
        }
    }
}
