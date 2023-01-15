namespace StudentHousingBV.models
{
    public class Agreement : Event
    {
        private bool _isAccepted = false;
        private DateTime _startDateTime;
        private DateTime _endDateTime;

        public Agreement()
        { }

        public Agreement(int id, string title, string description, DateTime createdAt, int creatorId, int buildingId, bool isAccepted, DateTime startDateTime, DateTime endDateTime)
            : base(id, title, description, createdAt, creatorId, buildingId)
        {
            _isAccepted = isAccepted;
            _startDateTime = startDateTime;
            _endDateTime = endDateTime;
            _startDateTime = startDateTime;
        }

        public bool IsAccepted { get => _isAccepted; set => _isAccepted = value; }

        public DateTime StartDateTime { get => _startDateTime; private set => _startDateTime = value; }

        public DateTime EndDateTime { get => _endDateTime; private set => _endDateTime = value; }

        public int EventId { get; private set; } // so we can read columns using reflection
    }
}
