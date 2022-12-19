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
            List<User> _users = new List<User>();
            // adding from database
            return _users;
        }

        public User Get(int id)
        {
            foreach (User user in GetAll())
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            // return null;
            return new User(1, "First Name", "Last Name", "Email", "Password", "Phone Number", false, 0, 0, DateTime.UtcNow);
        }

        public void Delete(User user)
        {
            // delete from database
        }

        public void Add(User user)
        {
            // add to database
        }

        public void Update(User user)
        {
            // update details in database for specified user
        }
    }
}
