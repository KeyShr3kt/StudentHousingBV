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
        public List<User> GetAllUsers()
        {
            User user1 = new User(1, "Peter", "Ivanov", "email@email.com", "password", "+314321256", false);
            User user2 = new User(2, "John", "Johnes", "email@email.com", "password", "+314321256", false);
            User user3 = new User(3, "Martin", "LastName", "email@email.com", "password", "+314321256", false);
            User user4 = new User(4, "Lucas", "Petrov", "email@email.com", "password", "+314321256", false);
            return new List<User>{user1, user2, user3, user4};
        }

        public bool isFirstTimeLoginForUserId(int id)
        {
            return true;
        }

        public bool IsAdmin(int id)
        {
            return true;
        }
    }
}
