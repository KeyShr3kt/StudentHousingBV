using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Building
    {
        private int _id;
        private string _address;
        private List<Room> _rooms;
        private List<Event> _events;

        public int Id { get => _id; private set => _id = value; }
        public string Address { get => _address; private set => _address = value; }

        public List<Room> Rooms { get => _rooms; private set => _rooms = value; }

        public List<BuildingEvents> BuildingEvents { get => _events; private set => _events = value; }

        public Building(int id, string address, List<Room> rooms, List<BuildingEvents> events)
        {
            Id = id;
            Address = address;
            Rooms = rooms;
            BuildingEvents = events;

        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public void AddEvent(BuildingEvents buildingEvent) 
        {
            BuildingEvents.Add(buildingEvent);
        }
    }
}
