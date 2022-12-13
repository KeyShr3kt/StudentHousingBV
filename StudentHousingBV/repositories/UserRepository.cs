using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.repositories
{
    public class UserRepository
    {
        public List<User> GetAll() 
        { 
            return new List<User> {
                new User(1, "Nela", "Geraldo", "nela@mail.com", "password", "+3165123", 10, 99, false, DateTime.UtcNow),
                new User(2, "Quanna", "Cevdet", "quanna@mail.com", "password", "+31434342", 7, 1, false, DateTime.UtcNow),
                new User(3, "Kalina", "Ravi", "admin", "admin", "+3154i2o", 90, 37, true, DateTime.UtcNow)
            }; 
        }
        public User Get(int id) { return new User(1, "firstName", "LastName", "email", "password", "phonenumber", 1, 0, true, DateTime.UtcNow); }
        public void Delete(User user) { return; }
        public int Insert(string firstName, string lastName, string email, string phoneNumber, bool isAdmin) { return 1; }
        public void Update(User user) { return;  }

        public List<User> GetAdminsInBuildingId(int buildingId)
        {
            return new List<User>();
        }

        public List<User> GetAllUsersInBuildingId(int buildingId)
        {
            return new List<User>();
        }

        public List<User> GetAllAdmins()
        {
            return new List<User>();
        }
    }
}
