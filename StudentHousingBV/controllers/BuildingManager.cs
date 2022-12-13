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
        public int CurrentUserId { get => _currentUserId; set { _currentUserId = value; } }
        private UnitOfWork _unitOfWork = new();
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
            return unitOfWork.Rooms.GetAvailableBedroomsForBuilding(building);
        }
    }
}
