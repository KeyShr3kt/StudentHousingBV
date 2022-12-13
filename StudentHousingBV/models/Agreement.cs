namespace StudentHousingBV.models
{
    public class Agreement : Event
    {
        private bool _isAccepted = false;

        public Agreement(int id, string title, string description, DateTime createdAt, int creatorId, int buildingId, bool isAccepted)
            : base(id, title, description, createdAt, creatorId, buildingId)
        {
            _isAccepted = isAccepted;
        }

        public bool IsAccepted { get => _isAccepted; set => _isAccepted = value; }
    }
}
