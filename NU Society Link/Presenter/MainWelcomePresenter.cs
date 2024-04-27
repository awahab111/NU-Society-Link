using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.DBHandlers;
using NU_Society_Link.Models;
using NU_Society_Link.View;

namespace NU_Society_Link.Presenter
{
    public class MainWelcomePresenter
    {
        private MainWelcomePage view;
        private MainView parent;

        private NotificationDBHandler dbHandler ;

        private User user;
        private SocietyMember mem;
        public MainWelcomePresenter(MainWelcomePage view, User u, MainView p)
        {
            this.view = view;
            user = u;
            parent = p;
            dbHandler = new NotificationDBHandler();
            GreetUser();
            getNotifications();
            this.view.ClearNotifications += (sender, e) => ClearNotifications();
            this.view.Show();
        }

        private void ClearNotifications()
        {
            NotificationDBHandler dbHandler = new NotificationDBHandler();
            dbHandler.ClearNotifications((user.Id).ToString());
            getNotifications();
        }

        public void getNotifications(){
            List<Notifications> notifications = dbHandler.GetNotifications((user.Id).ToString());
            view.NotificationsListView.Items.Clear();
            updateViewNotifications(notifications);
        }

        public void updateViewNotifications(List<Notifications> notifications){
            foreach(Notifications notification in notifications){
                if (notification.Seen) continue;
                ListViewItem item = new ListViewItem(new string[] {notification.Message, notification.TimeStamp.ToString()});
                view.NotificationsListView.Items.Add(item);
            }
        }
        

        public void GreetUser(){
            StudentsDBHandler dbHandler = new StudentsDBHandler();
            SocietyMembersDBHandler societyMembersDBHandler = new SocietyMembersDBHandler();

            Student std = dbHandler.GetStudent((this.user.Id).ToString());
            SocietyMember member = societyMembersDBHandler.GetMember(std);
            mem = member;

            string name, email, contact, batch, position,  societyinfo;

            if (member != null)
            {
                // User is a member
                name = member.Name;
                email = member.Email;
                contact = member.Contact;
                batch = member.Batch;
                position = member.MemberPosition;
                societyinfo =  @"Society Information: " + "\n"+
                               "Society Name: " + member.SocietyName + "\n" +
                               "Position: " + position + "";
            }
            else
            {
                // User is not a member
                name = std.Name;
                email = std.Email;
                contact = std.Contact;
                batch = std.Batch;
                societyinfo = "You are not a member of any society.";
            }

            view.lblGreetingText = "Welcome, " + name + "!";
            view.lblPersonalInfoText = "Personal Information";
            view.lblNameText += name;
            view.lblEmailText += email;
            view.lblPhoneText += contact;
            view.lblBatchText += batch;

            view.societyInfoText = societyinfo;

            if (member == null || member.MemberPosition == null)
            {
                view.btnUpdateSociety.Visible = false;
            }
            else if (member.MemberPosition == "President")
            {
                view.btnUpdateSociety.Visible = true;
                view.btnUpdateSociety.Text = "Update Society";
                this.view.SocietyInfo += UpdateSociety;
            }
            else
            {
                view.btnUpdateSociety.Visible = true;
                view.btnUpdateSociety.Text = "View Society";
                this.view.SocietyInfo += ViewSociety;
            }

 
        }

        private void UpdateSociety(object? sender, EventArgs e)
        {
            SocietyInformationView view = SocietyInformationView.GetInstance(parent);
            SocietyInformationPresenter societyIOnfoPresenter = new SocietyInformationPresenter(view, mem.SocietyId.ToString(),1);
        }

        private void ViewSociety(object? sender, EventArgs e)
        {
            SocietyInformationView view = SocietyInformationView.GetInstance(parent);
            SocietyInformationPresenter societyIOnfoPresenter = new SocietyInformationPresenter(view, mem.SocietyId.ToString(),2);
        }



        public void Dispose(){
            view.Dispose();
        }

    }
}
