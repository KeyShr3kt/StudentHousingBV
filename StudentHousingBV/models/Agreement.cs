namespace StudentHousingBV.models
{
    public class Agreement : Event
    {
        private bool _isAccepted = false;
        private List<Reaction> _reactions = new();

        public Agreement(int id, string title, string description, User creator, DateTime createdAt, bool isAccepted)
            : base(id, title, description, creator, createdAt)
        {
            _isAccepted = isAccepted;
        }

        public bool IsAccepted { get => _isAccepted; set => _isAccepted = value; }
        public List<Reaction> Reactions { get => _reactions; set => _reactions = value; }
    }
}
