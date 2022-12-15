using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.repositories
{
    public class RoomRepository
    {
        public List<Room> GetAll() 
        { 
            return new List<Room>(); 
        }

        // Building Get(id)
        // void Delete(obj)
        // void Insert(obj)
        // void Update(obj)
        // Building GetForUser(obj)

        public List<Room> GetAvailableBedroomsForBuildingId(int id) 
        {
            // select where buildingId == b.Id
            return new List<Room> {
                new Room(1, "Bedroom", null, "3.01", 3),
                new Room(2, "Bedroom", null, "3.02", 3),
                new Room(3, "Bedroom", null, "3.03", 3)
            };
        
        }

        public void SetRoomToUserId(int roomId, int userId) 
        {
            
        }
    }
}
