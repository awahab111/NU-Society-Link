using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.Models;
using NU_Society_Link.View;
using NU_Society_Link.DBHandlers;
using System.Diagnostics.Eventing.Reader;

namespace NU_Society_Link.Presenter
{
    public class AssignTaskPresenter
    {
        AssignTaskView view;
        
        TaskDBHandler taskDBHandler;

        SocietyMember member;

        public AssignTaskPresenter(AssignTaskView view, SocietyMember m)
        {
            this.member = m;
            this.view = view;
            taskDBHandler = new TaskDBHandler();
            this.view.AssignTask += AddTask;
            this.view.Show();
        }

        public void AddTask(object? sender, EventArgs e)
        {
            string taskDescription = view.taskDescription;
            DateTime taskDeadline = view.dueDate;
            string taskAssignee = view.taskAssingee;

            EventsDBHandler eventDBHandler = new EventsDBHandler();
            int eventid = eventDBHandler.GetEvent(view.eventTitle);


            if (!string.IsNullOrEmpty(taskDescription) && !string.IsNullOrEmpty(taskAssignee))
            {
                if (eventid == 0)
                {
                    view.Flag.ForeColor = System.Drawing.Color.Red;
                    view.Flag.Text = "Event not found. Please enter a valid event title.";
                    return;
                }
                var flag = taskDBHandler.AddTask(eventid,taskAssignee, taskDescription, taskDeadline);
                if (flag )
                {
                    NotificationDBHandler notificationDBHandler = new NotificationDBHandler();
                    string message = "You have been assigned a task for the event " + view.eventTitle;
                    DateTime date = taskDeadline;
                    notificationDBHandler.AddNotification(taskAssignee, message);


                    view.Flag.ForeColor = System.Drawing.Color.Green;
                    view.Flag.Text = "Task Assigned Successfully";
                }
                else
                {
                    view.Flag.ForeColor = System.Drawing.Color.Red;
                    view.Flag.Text = "An Error Occurred. Please try again.";
                }
            }
        }
    }
}
