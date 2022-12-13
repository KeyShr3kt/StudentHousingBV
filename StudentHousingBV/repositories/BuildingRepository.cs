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
            return new List<Building>
            {
                //new Building(1, "Address1", new List<Room>{new Room(1, "kitchen", "happy kitchen", null)}, new List<Event>()),
                //new Building(2, "Address2", new List<Room>(), new List<Event>()),
                //new Building(3, "Address3", new List<Room>(), new List<Event>())
            };
        }
       // Building Get(id)
       // void Delete(obj)
       // void Insert(obj)
       // void Update(obj)
       // Building GetForUser(obj)
    }
}
