namespace StudentHousingBV.models
{
    public class Agreement : Event
    {
        private bool _isAccepted = false;

        public Agreement(int id, string title, string description, User creator, DateTime createdAt, bool isAccepted)
            : base(id, title, description, creator, createdAt)
        {
            _isAccepted = isAccepted;
        }

        public bool IsAccepted { get => _isAccepted; set => _isAccepted = value; }
    }
}
