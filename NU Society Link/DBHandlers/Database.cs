﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace NU_Society_Link.DBHandlers
{
    public sealed class Database{
        private static Database? instance = null;
        private static readonly object padlock = new object();

        public SqlConnection connection;


        private Database(){
            // Add your code here to initialize the database


            string connectionString = "Server=DESKTOP-2J2DEI1;Database=SMS;Integrated Security=True;";

            

            connection = new SqlConnection(connectionString);
                connection.Open();
        }

        public static Database GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Database();
                    }
                    return instance;
                }
            }
        }

        // Database methods go here
    }
}
