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


            MainWelcome(null, EventArgs.Empty);
            this.view.Show();
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

            // Get the singleton instance of AddEventView
            AddEvent addEventView = AddEvent.GetInstance(view);

            // Create an instance of AddEventPresenter and pass the view and user
            AddEventPresenter addEventPresenter = new AddEventPresenter(addEventView, user );

            // Bring the AddEventView to the front
            addEventView.BringToFront();
        }
        public void Current_Events(object? sender, EventArgs e)
        {
            Clear(); // Clear any existing views

            // Get the singleton instance of AddEventView
            CurrentEvents CurrentEventView = CurrentEvents.GetInstance(view);

            // Create an instance of AddEventPresenter and pass the view and user
            CurrentEventsPresenter addEventPresenter = new CurrentEventsPresenter(CurrentEventView, user);

            // Bring the AddEventView to the front
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
            mainWelcomePresenter = new MainWelcomePresenter(mainWelcomePage, user);
        }
        
        public void Clear(){
            addSocietyPresenter?.Dispose();
            membersPresenter?.Dispose();
            mainWelcomePresenter?.Dispose();
            addEventPresenter?.Dispose();
            viewTasksPresenter?.Dispose();
            
            AddEvent.GetInstance(view).Delete();
            AddSocietyView.GetInstance(view).Delete();
            MembersView.GetInstance(view).Delete();
            MainWelcomePage.GetInstance(view).Delete();

        }

    }
}
