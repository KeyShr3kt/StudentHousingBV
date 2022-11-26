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
        private List<User> users;
        public Database() {
            User user1 = new User(1, "User1", "User1", "user1@abv.bg", "password", "0111", false);
            User user2 = new User(1, "User2", "User2", "user2@abv.bg", "password", "0111", false);
            User user3 = new User(1, "User3", "User3", "user3@abv.bg", "password", "0111", false);
            this.users = new List<User>() { user1, user2, user3 };
        }
        public List<User> GetUsers()
        {
            return this.users;
        }

        public User? getUserWithLogin(string email, string password)
        {
            User? foundUser = null;
            foreach (User user in this.users)
            {
                if (user.GetEmailAddress() == email && SecurePassword.Verify(password, user.GetPassword()))
                {
                    foundUser = user;
                }
            }
            return foundUser;
        }

        public void ChangePasswordForUserWith(int id, string password)
        {
            foreach (User user in this.users)
            {
                if (user.GetId() == id)
                {
                    user.SetPassword(password);
                }
            }
        }
    }
}
