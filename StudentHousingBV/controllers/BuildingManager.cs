using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.controllers
{
    public class BuildingManager
    {
        private int _currentUserId;
        private UnitOfWork _unitOfWork = new();

        public int CurrentUserId { get => _currentUserId; set { _currentUserId = value; } }
        
        public UnitOfWork unitOfWork { get => _unitOfWork; }

        public BuildingManager(int currentUserId)
        {
            _currentUserId = currentUserId;
        }

        public List<Building> GetAllBuildings()
        {
            return unitOfWork.Buildings.GetAll();
        }

        public List<Room> GetAvailableBedroomsForBuilding(Building building) 
        {
            return unitOfWork.Rooms.GetAvailableBedroomsForBuildingId(building.Id);
        }

        public Building GetBuidingWithId(int id)
        {
            return unitOfWork.Buildings.Get(id);
        }

        public Building GetForUser(User user)
        {
            return unitOfWork.Buildings.GetForUser(user);
        }
    }
}
