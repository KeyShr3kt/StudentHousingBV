namespace StudentHousingBV.models
{
    public class Agreement : Event
    {
        private bool _isAccepted = false;
        private string _title;

        public string Title { get => _title; set => _title = value; }

        public Agreement(int id, string title, string description, DateTime createdAt, int buildingId, bool isAccepted)
            : base(id, description, createdAt, buildingId)
        {
            _title = title;
            _isAccepted = isAccepted;
        }
    }
}
