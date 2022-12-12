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
            Database db = new Database();
            StudentHousingBV.models.User currentUser = new StudentHousingBV.models.User(1, "Ionut", "Dragomir", "510175@student.fontys.nl", "smthsmthsmth", "+31 633396888", false, 0, 0, DateTime.Now);
            Application.Run(new forms.LoginPanel(currentUser));
            Application.Run(new forms.StudentPanel(currentUser));
            //Application.Run(new forms.ReportForm());
        }
    }
}