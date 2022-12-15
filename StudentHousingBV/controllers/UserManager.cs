using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        
        public void createUser(string firstName, string lastName, string email, 
                                string phoneNumber, bool isAdmin, Room? room)
        {

            if (firstName == "" || lastName == "" || room == null )
            {
                throw new ArgumentException("Invalid input! Please try again!");
            }
            else if (!IsValidEmail(email))
            {
                throw new ArgumentException("Invalid email! Please try again!");
            }
            else if (!IsPhoneNumber(phoneNumber)) 
            {
                throw new ArgumentException("Invalid phone number! You should include country code ins the beginning!");
            }

            int userId = unitOfWork.Users.Insert(firstName, lastName, email, phoneNumber, isAdmin);

            unitOfWork.Rooms.SetRoomToUserId(room.Id, userId);
        }

<<<<<<< HEAD
        public void ChangePasswordForUserWith(int id, string password)
=======
        public List<User> GetAdminsInBuilding(Building building)
>>>>>>> martin-accountsManagement
        {
            return unitOfWork.Users.GetAdminsInBuildingId(building.Id);
        }

        public List<User> GetAllUsersInBuilding(Building building)
        {
            return unitOfWork.Users.GetAllUsersInBuildingId(building.Id);
        }

        public List<User> GetAllAdmins()
        {
            return unitOfWork.Users.GetAllAdmins();
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsPhoneNumber(string number)
        {
            Regex validatePhoneNumberRegex = new Regex("^\\s*\\+?[0-9]\\d?[- .]?(\\([2-9]\\d{2}\\)|[2-9]\\d{2})[- .]?\\d{3}[- .]?\\d{4}$");
            return validatePhoneNumberRegex.IsMatch(number); // returns True
            //return Regex.Match(number, @"^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$").Success;
        }
    }
}
