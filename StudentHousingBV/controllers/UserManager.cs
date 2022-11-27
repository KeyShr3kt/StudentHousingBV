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
                if (user.GetId() == id)
                {
                    user.SetPassword(password);
                }
            }
        }

        public static int? GetUserIdWith(string email, string password, Database db)
        {
            List<User> users = db.GetUsers();

            int? foundUser = null;
            foreach (User user in users)
            {
                if (user.GetEmailAddress() == email && PasswordHasher.Verify(password, user.GetPassword()))
                {
                    foundUser = user.GetId();
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
                if (user.GetId() == id)
                {
                    if (user.GetLastSeenAt() == null)
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
                if (user.GetId() == id)
                {
                    isAdmin = user.GetIsAdmin();
                }
            }
            return isAdmin;
        }

        public static void UpdateLastSeenAtForUserId(int id, Database db)
        {
            List<User> users = db.GetUsers();
            foreach (User user in users)
            {
                if (user.GetId() == id)
                {
                    user.UpdateLastSeenAt();
                }
            }
        }
    }
}
