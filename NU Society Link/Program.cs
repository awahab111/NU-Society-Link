using NU_Society_Link.View;
using NU_Society_Link.DBHandlers;
using NU_Society_Link.Models;
using NU_Society_Link.Presenter;
using System.Diagnostics;
using System.Configuration;


namespace NU_Society_Link
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database db = Database.GetInstance;
            if (db.connection.State == System.Data.ConnectionState.Open){
                Debug.WriteLine("Database connection established");
            }
            else{
                Debug.WriteLine("Database connection failed");
            }

            MainLoginRegister view = new MainLoginRegister();
            UserDBHandler model = new UserDBHandler();
            new MainLoginRegisterPresenter(view);
            
            Application.Run((Form)view);
            
        }
    }
}