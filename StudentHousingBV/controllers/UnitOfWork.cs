using StudentHousingBV.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace StudentHousingBV.controllers
{
    public class UnitOfWork
    {
        public static string CONNECTION_STRING = "server=localmac; database=database; uid=SA; password=password;";
        private UserRepository _userRepository = new();
        public UserRepository Users { get => _userRepository; }

        private BuildingRepository _buildingRepository = new();

        public BuildingRepository Buildings { get => _buildingRepository;}

        private RoomRepository _roomRepository = new();
        public RoomRepository Rooms { get => _roomRepository; }

        private EventRepository _eventRepository = new();
        public EventRepository Events { get => _eventRepository; }

        private ReportRepository _reportRepository = new();

        public ReportRepository Reports { get => _reportRepository; }
    }
}
