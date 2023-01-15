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
        private UnitOfWork _unitOfWork = new();

        public int CurrentUserId { get => _currentUserId;  set { _currentUserId = value; } }
        public UnitOfWork unitOfWork { get => _unitOfWork; }

        public UserManager(int userId) 
        {
            _currentUserId = userId;
        }

        public User GetUser(int userId) 
        {
           return unitOfWork.Users.Get(userId);
        }

        public List<User> GetAllUsers()
        {
            return unitOfWork.Users.GetAll();
        }

        public List<User> GetAdminsInBuilding(Building building)
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

        public int CountUsersInBuildingId(int id)
        {
            return unitOfWork.Users.CountInBuildingId(id);
        }

        public void UpdateUser(User user)
        {
            unitOfWork.Users.Update(user);
        }

        public static User? Verify(string email, string password)
        {
            UnitOfWork unitOfWork = new();
            List<User> users = unitOfWork.Users.GetAll();
            User? foundUser = null;
            string hashString = "47B63402595D7DE12B1E0EA732D7391776E1ABBD0DC305783756C7CBB1157B3B:36D58FD2B56E1B17D4908458B524D74A:100000:SHA256";

            if (email == "" || password == "")
            {
                throw new ArgumentException("Input cannot be empty");
            }

            bool res = PasswordHasher.Verify(password, hashString);
            
            foreach (User user in users) 
            {
                if (user.EmailAddress == email && PasswordHasher.Verify(password, user.Password))
                {
                    foundUser = user;
                }
            }
            return foundUser;
        }
        
        public void CreateUser(string firstName, string lastName, string email, 
                                string phoneNumber, bool isAdmin, string IBAN, Room? room)
        {

            if (firstName == "" || lastName == "" || IBAN == "" )
            {
                throw new ArgumentException("Invalid input! Please try again!");
            }
            else if (!IsEmail(email))
            {
                throw new ArgumentException("Invalid email! Please try again!");
            }
            else if (!IsPhoneNumber(phoneNumber)) 
            {
                throw new ArgumentException("Invalid phone number! You should include country code ins the beginning!");
            }

            int userId = unitOfWork.Users.Insert(firstName, lastName, email, phoneNumber, isAdmin, IBAN);
            if (room != null)
            {
                unitOfWork.Rooms.SetRoomToUserId(room.Id, userId);
            }
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
            user.Password = PasswordHasher.Hash(password);
            unitOfWork.Users.Update(user);
        }

        public bool IsCurrentUserAdmin()
        {
            return unitOfWork.Users.Get(CurrentUserId).IsAdmin;
        }

        public static bool IsEmail(string email)
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
            Regex validatePhoneNumberRegex = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");
            return validatePhoneNumberRegex.IsMatch(number); // returns True
        }
    }
}
