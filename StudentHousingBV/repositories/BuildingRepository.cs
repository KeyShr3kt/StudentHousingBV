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
                new Building(1, "Eindhoven1"),
                new Building(2, "Eindhoven2"),
                new Building(3, "Eindhoven3")
            };
        }
       // Building Get(id)
       // void Delete(obj)
       // void Insert(obj)
       // void Update(obj)
       // Building GetForUser(obj)
    }
}
