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

        private User user;

        public MainPresenter(MainView view, User u)
        {
            this.view = view;
            this.user = u;
            Debug.WriteLine("User" + user.Id);

            this.view.AddSociety += AddSociety;
            this.view.MembersView += Members;
            this.view.Show();
        }

        public void AddSociety(object? sender, EventArgs e)
        {
            Debug.WriteLine("Add Society Clicked");
            AddSocietyView addSocietyView = AddSocietyView.GetInstance(view);
            membersPresenter?.Dispose();
            MembersView.GetInstance(view).Delete();

            addSocietyPresenter = new AddSocietyPresenter(addSocietyView); // Assign the variable
            addSocietyView.BringToFront();
        }

        public void Members(object? sender, EventArgs e)
        {
            Debug.WriteLine("Members Clicked");
            MembersView membersView = MembersView.GetInstance(view);
            addSocietyPresenter?.Dispose();
            AddSocietyView.GetInstance(view).Delete();
                        Debug.WriteLine("User" + user.Id);

            membersPresenter = new MembersPresenter(membersView, user); // Assign the value directly to the field
            membersView.BringToFront();
        }
    }
}
