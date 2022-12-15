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
        private int _currentUserId;
        public int CurrentUserId { get => _currentUserId;  set { _currentUserId = value; } }

        //      private UserRepository _userRepository = new UserRepository();
        //      public UserRepository userRepository { get => _userRepository;}

        private UnitOfWork _unitOfWork = new();
        public UnitOfWork unitOfWork { get => _unitOfWork;}

        public UserManager(int userId) 
        {
            CurrentUserId = userId;
        }
        public static User? VirifyUserWithEmailAndPassword(string email, string password)
        {
            UnitOfWork unitOfWork = new();
            List<User> users = unitOfWork.Users.GetAll();
            User? foundUser = null;

            if (email == "" || password == "")
            {
                throw new ArgumentException("Input cannot be empty");
            }
            
            
            foreach (User user in users) 
            {
                if (user.EmailAddress == email && PasswordHasher.Verify(password, user.Password))
                {
                    foundUser = user;
                }
            }
            return foundUser;
        }

        public List<User> GetAllUsers()
        {
           return unitOfWork.Users.GetAll();
        }

        public List<Building> GetAllBuildings()
        {
            return unitOfWork.Buildings.GetAll();
        }

        public void SetNewPasswordForCurrentUser(string password)
        {
            if (password == "")
            {
                throw new ArgumentException("Password can't be empty!");
            }
            if (password.Length < 8)
            {
                throw new ArgumentException("Password should be at least 8 characters!");
            }

            User user = unitOfWork.Users.Get(CurrentUserId);
            user.Password = password;
            unitOfWork.Users.Update(user);
        }
        public bool isCurrentUserAdmin()
        {
            return unitOfWork.Users.Get(CurrentUserId).isAdmin;
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

        public void ChangePasswordForUserWith(int id, string password)
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
