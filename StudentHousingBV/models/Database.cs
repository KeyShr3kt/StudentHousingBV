using Microsoft.VisualBasic.ApplicationServices;
using StudentHousingBV.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Database
    {
        private List<User> _users;
        private List<Report> _reports;
        public Database() {
            User user1 = new User(1, "User1", "User1", "user1@abv.bg", "password", "0111", false);
            User user2 = new User(1, "User2", "User2", "user2@abv.bg", "password", "0111", false);
            User user3 = new User(1, "User3", "User3", "user3@abv.bg", "password", "0111", false);
            this._users = new List<User>() { user1, user2, user3 };
        }
        public List<User> GetUsers()
        {
            return this._users;
        }

        public List<Report> GetReports()
        {
            return this._reports;
        }

        public void AppendReport(Report report)
        {
            this._reports.Add(report);
        }

    }
}
