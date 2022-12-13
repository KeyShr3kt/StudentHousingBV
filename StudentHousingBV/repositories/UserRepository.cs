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
               // new User(1, "Nela", "Geraldo", "nela@mail.com", "password", "+3165123", false, 0, 0, DateTime.UtcNow),
               // new User(2, "Quanna", "Cevdet", "quanna@mail.com", "password", "+31434342", false, 0, 0, DateTime.UtcNow),
               // new User(3, "Kalina", "Ravi", "admin", "admin", "+3154i2o", true, 0, 0, DateTime.UtcNow)
            }; 
        }
        public User Get(int id) { return new User(1, "firstName", "LastName", "email", "password", "phonenumber", 1, 0, true, DateTime.UtcNow); }
        public void Delete(User user) { return; }
        public void Insert(User user) { return; }
        public void Update(User user) { return;  }
    
    }
}
