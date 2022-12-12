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
        public List<User> GetAll() { return new List<User>(); }
        public User Get(int id) { return new User(1, "firstName", "LastName", "email", "password", "phonenumber", false, 0, 0, DateTime.UtcNow); }
        public void Delete(User user) { return; }
        public void Insert(User user) { return; }
        public void Update(User user) { return;  }
    
    }
}
