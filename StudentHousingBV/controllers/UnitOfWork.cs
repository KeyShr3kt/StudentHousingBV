using StudentHousingBV.repositories;

namespace StudentHousingBV.controllers
{
    public class UnitOfWork
    {
        public static string CONNECTION_STRING = "Server=mssqlstud.fhict.local;Database=dbi510175_shbv;User Id=dbi510175_shbv;Password=StudentHousingBV;";

        private UserRepository _userRepository = new();
        private BuildingRepository _buildingRepository = new();
        private RoomRepository _roomRepository = new();
        private ReportRepository _reportRepository = new();
        private EventRepository _eventRepository = new(CONNECTION_STRING);
        private ReactionRepository _reactionRepository = new(CONNECTION_STRING);


        public UserRepository Users { get => _userRepository; }

        public BuildingRepository Buildings { get => _buildingRepository; }

        public RoomRepository Rooms { get => _roomRepository; }

        public EventRepository Events { get => _eventRepository; }

        public ReportRepository Reports { get => _reportRepository; }

        public ReactionRepository Reactions { get => _reactionRepository; }
    }
}
