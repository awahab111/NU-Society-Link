using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.View;
using NU_Society_Link.Models;

namespace NU_Society_Link.Presenter
{
    public class MainPresenter
    {
        private MainView view;
        private AddSocietyPresenter addSocietyPresenter;
        private MembersPresenter membersPresenter;
        private MainWelcomePresenter mainWelcomePresenter;

        private User user;

        public MainPresenter(MainView view, User u)
        {
            this.view = view;
            this.user = u;

            this.view.AddSociety += AddSociety;
            this.view.MembersView += Members;
            this.view.Back += MainWelcome;
            this.view.Logout += Logout;
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

        public void AddSociety(object? sender, EventArgs e)
        {
            Clear();
            AddSocietyView addSocietyView = AddSocietyView.GetInstance(view);
            addSocietyPresenter = new AddSocietyPresenter(addSocietyView); // Assign the variable
            addSocietyView.BringToFront();
        }

        public void Members(object? sender, EventArgs e)
        {
            Clear();
            MembersView membersView = MembersView.GetInstance(view);
            membersPresenter = new MembersPresenter(membersView, user); // Assign the value directly to the field
            membersView.BringToFront();
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

            AddSocietyView.GetInstance(view).Delete();
            MembersView.GetInstance(view).Delete();
            MainWelcomePage.GetInstance(view).Delete();

        }

    }
}
