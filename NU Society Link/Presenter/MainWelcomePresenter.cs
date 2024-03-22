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

        private User user;
        public MainWelcomePresenter(MainWelcomePage view, User u)
        {
            this.view = view;
            user = u;
            GreetUser();
            getNotifications();
            this.view.Show();
        }

        public void getNotifications(){
            NotificationDBHandler dbHandler = new NotificationDBHandler();
            List<Notifications> notifications = dbHandler.GetNotifications((user.Id).ToString());
            view.NotificationsListView.Items.Clear();
            foreach(Notifications notification in notifications){
                if (notification.Seen) continue;
                ListViewItem item = new ListViewItem(new string[] {notification.Message, notification.TimeStamp.ToString()});
                view.NotificationsListView.Items.Add(item);
            }
        }
        

        public void GreetUser(){
            SocietyMembersDBHandler dbHandler = new SocietyMembersDBHandler();
            SocietyMember member = dbHandler.GetMember((user.Id).ToString());

            view.lblGreetingText = "Welcome, " + member.MemberName + "!";
            view.lblPersonalInfoText = "Personal Information";
            view.lblNameText += member.MemberName;
            view.lblEmailText += member.MemberEmail;
            view.lblPhoneText += member.MemberContact;
            view.lblPositionText += member.MemberPosition;
            view.lblBatchText += member.MemberBatch;

        }   

        public void Dispose(){
            view.Dispose();
        }

    }
}
