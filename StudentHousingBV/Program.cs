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
            Application.Run(new forms.StudentPanel());
            // Application.Run(new forms.ReportForm());
        }
    }
}