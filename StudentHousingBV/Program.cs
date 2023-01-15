using StudentHousingBV.controllers;
using StudentHousingBV.forms;
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
            Application.Run(new LoginPanel());
            // TODO: tell the user if they're homeless ("SELECT COUNT(*) FROM [ROOM] WHERE [ROOM].[UserId] != NULL" == 0) and not an admin
            // and prevent the user from accessing StudentPanel

        }
    }
}