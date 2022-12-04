using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentHousingBV.models;

namespace StudentHousingBV.controllers
{
    public static class UserManager
    {

        public static void ChangePasswordForUserWith(int id, string password, Database db)
        {

            // open the db and do the query "get all users where user.id = id and change its password"
            //Database db = new Database();
            List<User> users = db.GetUsers();

            // close the db object in the end of the method
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    user.Password = password;
                }
            }
        }

        public static int? GetUserIdWith(string email, string password, Database db)
        {
            List<User> users = db.GetUsers();

            int? foundUser = null;
            foreach (User user in users)
            {
                if (user.EmailAddress == email && PasswordHasher.Verify(password, user.Password))
                {
                    foundUser = user.Id;
                }
            }
            return foundUser;
        }

        public static bool isFirstTimeLoginForUserId(int id, Database db)
        {
            List<User> users = db.GetUsers();
            bool newUser = false;
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    if (user.LastSeenAt == null)
                    {
                        newUser = true;
                    }
                }
            }
            return newUser;
        }

        public static bool IsUserWithIdAdmin(int id, Database db)
        {
            List<User> users = db.GetUsers();
            bool isAdmin = false;
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    isAdmin = user.isAdmin;
                }
            }
            return isAdmin;
        }

        public static void UpdateLastSeenAtForUserId(int id, Database db)
        {
            List<User> users = db.GetUsers();
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    user.LastSeenAt = DateTime.Now;
                }
            }
        }
    }
}
