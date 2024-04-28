using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.View;
using NU_Society_Link.Models;
using System.Diagnostics;
using NU_Society_Link.Presenters;

namespace NU_Society_Link.Presenter
{
    public class AdminMainPresenter
    {
        private AdminMainView view;
        private SocietyDBHandler societyDBHandler;

        private ApproveSocietyPresenter approveSocietyPresenter;
        private CurrentEventsPresenter currentEventsPresenter;
        

        public AdminMainPresenter(AdminMainView view)
        {
            societyDBHandler = new SocietyDBHandler();
            this.view = view;
            this.view.ApproveSocietyClick += ShowApproveSociety;
            this.view.BackButtonClicked += Back;
            this.view.LogoutButtonClicked += Logout;
            this.view.EventsButtonClicked += ShowEvents;
            this.view.Show();
        }


        private void ShowApproveSociety(object? sender, EventArgs e)
        {
            Debug.WriteLine("Approve Society Clicked");
            ApproveSocietyView approveSocietyView = ApproveSocietyView.GetInstance((Form)view);
            approveSocietyPresenter = new ApproveSocietyPresenter(approveSocietyView, view);
            approveSocietyView.BringToFront();
        }

        private void ShowEvents(object? sender, EventArgs e)
        {
            Debug.WriteLine("Events Clicked");
            Clear();
            CurrentEvents currentEvents = CurrentEvents.GetInstance(view);
            CurrentEventsPresenter currentEventsPresenter = new CurrentEventsPresenter(currentEvents, new User(1,"admin","admin",true ), view);
        }

        private void Back(object? sender, EventArgs e)
        {
            Clear();
        }

        private void Logout(object? sender, EventArgs e)
        {
            Clear();
            MainLoginRegister mainLoginRegister = new MainLoginRegister();
            MainLoginRegisterPresenter mainLoginRegisterPresenter = new MainLoginRegisterPresenter(mainLoginRegister);
            mainLoginRegister.Show();
            view.Close();
        }

        public void Clear()
        {
            approveSocietyPresenter?.Dispose();

            ApproveSocietyView.GetInstance((Form)view).Delete();
        }

    }
}
