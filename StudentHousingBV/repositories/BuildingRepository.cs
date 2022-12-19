using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.repositories
{
    public class BuildingRepository
    {
        public List<Building> GetAll()
        {
            List<Building> _buildings = new List<Building>();
            // adding from database
            return _buildings;
        }

        public Building Get(int Id)
        {
            foreach (Building building in GetAll())
            {
                if (building.Id == Id)
                {
                    return building;
                }
            }
            // return null;
            return new Building(1, "Address", new List<Room>(), new List<Event>());
        }

        public void Delete(Building building)
        {
            // delete from database
        }

        public void Add(Building building)
        {
            // insert into database
        }

        public void Update(Building building)
        {
            // update into database
        }
        
        // public Building GetForUser(User user)
        // {
            // search into database
            // return new StudentHousingBV.models.Task(1, "This is a task title.", "This is a task description.", new User(1, "First Name", "Last Name", "Email", "Password", "Phone Number", false, 0, 0, DateTime.UtcNow), DateTime.Now, false, false);
        // }
    }
}
