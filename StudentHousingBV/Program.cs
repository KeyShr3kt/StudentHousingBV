using StudentHousingBV.controllers;
using StudentHousingBV.models;

namespace StudentHousingBV
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
            // Database db = new Database();
            UserManager um= new controllers.UserManager();
            um.CurrentUserId = 1;
            Application.Run(new forms.AdminForm(um));
            //Application.Run(new forms.LoginPanel(db));
            //Application.Run(new forms.StudentPanel());
            //Application.Run(new forms.ReportForm());
        }
    }
}