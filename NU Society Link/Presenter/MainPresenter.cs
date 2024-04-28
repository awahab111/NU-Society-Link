using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.View;
using NU_Society_Link.Models;
using NU_Society_Link.Presenters;

namespace NU_Society_Link.Presenter
{
    public class MainPresenter
    {
        private MainView view;

        private AddSocietyPresenter addSocietyPresenter;
        private MembersPresenter membersPresenter;
        private MainWelcomePresenter mainWelcomePresenter;
        private AddEventPresenter addEventPresenter;
        private CurrentEventsPresenter currentEventsPresenter;
        private ViewTasksPresenter viewTasksPresenter;
        private EventSummaryPresenter eventSummaryPresenter;

        private User user;
        

        public MainPresenter(MainView view, User u)
        {
            this.view = view;
            this.user = u;

            this.view.AddEvent += AddEvents;
            this.view.AddSociety += AddSociety;
            this.view.MembersView += Members;
            this.view.Back += MainWelcome;
            this.view.ViewTasks += ViewTasks;
            this.view.Logout += Logout;
            this.view.CurrentEvents += Current_Events;
            this.view.AddEventSummaries += EventSummary;
            



            MainWelcome(null, EventArgs.Empty);
            this.view.Show();
        }




        public void EventSummary(object? sender, EventArgs e)
        {
            Clear();
            EventSummaries eventSummariesView = EventSummaries.GetInstance(view);
            eventSummaryPresenter = new EventSummaryPresenter(eventSummariesView); // Assign the value directly to the field
            eventSummariesView.BringToFront();
        }

        private void Logout(object? sender, EventArgs e)
        {
            Clear();
            MainLoginRegister mainLoginRegister = new MainLoginRegister();
            MainLoginRegisterPresenter mainLoginRegisterPresenter = new MainLoginRegisterPresenter(mainLoginRegister);
            mainLoginRegister.Show();
            view.Close();
        }

        public void AddEvents(object? sender, EventArgs e)
        {
            Clear(); // Clear any existing views

            AddEvent addEventView = AddEvent.GetInstance(view);

            addEventPresenter = new AddEventPresenter(addEventView, user );

            addEventView.BringToFront();
        }
        public void Current_Events(object? sender, EventArgs e)
        {
            Clear(); // Clear any existing views

            CurrentEvents CurrentEventView = CurrentEvents.GetInstance(view);

            currentEventsPresenter = new CurrentEventsPresenter(CurrentEventView, user, view);

            CurrentEventView.BringToFront();
        }

        public void AddSociety(object? sender, EventArgs e)
        {
            Clear();
            AddSocietyView addSocietyView = AddSocietyView.GetInstance(view);
            addSocietyPresenter = new AddSocietyPresenter(addSocietyView, user); // Assign the variable
            addSocietyView.BringToFront();
        }

        public void Members(object? sender, EventArgs e)
        {
            Clear();
            MembersView membersView = MembersView.GetInstance(view);
            membersPresenter = new MembersPresenter(membersView, user); // Assign the value directly to the field
            membersView.BringToFront();
        }

        public void ViewTasks(object? sender, EventArgs e)
        {
            Clear();
            ViewTasksView tasksviw = new ViewTasksView(view);
            viewTasksPresenter = new ViewTasksPresenter(tasksviw, user); // Assign the value directly to the field
            tasksviw.BringToFront();
        }


        private void MainWelcome(object? sender, EventArgs e){
            Clear();
            MainWelcomePage mainWelcomePage = MainWelcomePage.GetInstance(view);
            mainWelcomePresenter = new MainWelcomePresenter(mainWelcomePage, user, view);
        }
        
        public void Clear(){
            addSocietyPresenter?.Dispose();
            membersPresenter?.Dispose();
            mainWelcomePresenter?.Dispose();
            addEventPresenter?.Dispose();
            viewTasksPresenter?.Dispose();
            currentEventsPresenter?.Dispose();
            eventSummaryPresenter?.Dispose();

            AddEvent.GetInstance(view).Delete();
            AddSocietyView.GetInstance(view).Delete();
            MembersView.GetInstance(view).Delete();
            MainWelcomePage.GetInstance(view).Delete();
            EventSummaries.GetInstance(view).Delete();

        }

    }
}
