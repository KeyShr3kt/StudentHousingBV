using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentHousingBV.models;
using StudentHousingBV.repositories;

namespace StudentHousingBV.controllers
{
    public class UserManager
    {
        private int? _currentUserId;
        public int? CurrentUserId { get => _currentUserId;  set { _currentUserId = value; } }

        private UserRepository _userRepository = new UserRepository();
        public UserRepository UserRepository { get => _userRepository;}

        public bool TryLoginWithEmailAndPassword(string email, string password)
        {
            /*bool userFound = false;
            List<User> users = UserRepository.GetAllUsers();
            foreach (User user in users)
            {
                if (user.EmailAddress == email && PasswordHasher.Verify(password, user.Password))
                {
                    CurrentUserId = user.Id;
                    user.LastSeenAt = DateTime.UtcNow;
                    userFound = true;
                }
            }
            return userFound;*/
            return true;
        }

        public List<User> GetAllUsers()
        {

           return new List<User>();
        }

        public bool IsUserAdmin()
        {
            /*bool isAdmin = false;
            if (CurrentUserId != null)
            {
                isAdmin = UserRepository.IsAdmin((int)CurrentUserId);
            }*/
            return true;
        }

        public bool isFirstTimeLogin()
        {
            /* bool firstTime = false;
             if (CurrentUserId != null)
             {
                 firstTime = UserRepository.isFirstTimeLoginForUserId((int)CurrentUserId);
             }
             return firstTime;*/
            return true;
        }

        public void ChangePasswordForUserWith(int id, string password, Database db)
        {

            // open the db and do the query "get all users where user.id = id and change its password"
            //Database db = new Database();
           // List<User> users = db.GetUsers();

            // close the db object in the end of the method
            /*foreach (User user in users)
            {
                if (user.Id == id)
                {
                    user.Password = password;
                }
            }*/
        }


        public static void UpdateLastSeenAtForUserId(int id)
        {
            /*List<User> users = db.GetUsers();
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    user.LastSeenAt = DateTime.Now;
                }
            }*/
        }
    }
}
