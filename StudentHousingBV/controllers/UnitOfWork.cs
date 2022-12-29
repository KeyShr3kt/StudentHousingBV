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
        public static string CONNECTION_STRING = "server=localmac;database=StudentHousingBV;uid=SA;password=nepokornite9;";
        private UserRepository _userRepository = new();
        public UserRepository Users { get => _userRepository; }

        private BuildingRepository _buildingRepository = new();

        public BuildingRepository Buildings { get => _buildingRepository;}

        private RoomRepository _roomRepository = new();
        public RoomRepository Rooms { get => _roomRepository; }

        private EventRepository _eventRepository = new(CONNECTION_STRING);
        public EventRepository Events { get => _eventRepository; }

        private ReportRepository _reportRepository = new();

        public ReportRepository Reports { get => _reportRepository; }
    }
}
