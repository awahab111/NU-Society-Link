﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NU_Society_Link.Models;

namespace NU_Society_Link.DBHandlers
{
    public class NotificationDBHandler
    {
        Database db ;

        public NotificationDBHandler()
        {
            db = Database.GetInstance;
        }

        public void AddNotification(string userId, string message)
        {
            string query = @"INSERT INTO Notifications (UserId, Message, TimeStamp, Seen)
                            VALUES (@userId, @message, @timeStamp, @seen)";
            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@message", message);
                command.Parameters.AddWithValue("@timeStamp", DateTime.Now);
                command.Parameters.AddWithValue("@seen", 0);
                command.ExecuteNonQuery();
            }

        }

        public List<Notifications> GetNotifications(string userId)
        {
            List<Notifications> notifications = new List<Notifications>();
            string query = $"SELECT * FROM Notifications WHERE UserId = '{userId}'";
            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@userId", userId);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var notificationId = reader.GetInt32(0);
                        var message = reader.GetString(2);
                        var timeStamp = reader.GetDateTime(3);
                        var seen = reader.GetBoolean(4);
                        notifications.Add(new Notifications(notificationId, userId, message, timeStamp, seen));
                    }
                }
            }
            return notifications;
        }

        public void ClearNotifications(string v)
        {
            string query = $"UPDATE Notifications SET Seen = 1 WHERE UserId = @UserId";
            using (var command = db.connection.CreateCommand())
            {
                command.CommandText = query;
                command.Parameters.AddWithValue("@UserId", v);
                command.ExecuteNonQuery();
            }
        }
    }
}
