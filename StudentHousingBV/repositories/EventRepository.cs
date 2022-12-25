using StudentHousingBV.models;
using Task = StudentHousingBV.models.Task;

namespace StudentHousingBV.repositories
{
    public partial class EventRepository
    {
        private Dictionary<int, Event> _events = new();
        private int _lastId = 1;

        public void Delete(int id)
        {
            if (_events.TryGetValue(id, out Event? ev))
            {
                _events.Remove(id);
                _agreements.Remove(id);
                _rules.Remove(id);
                _tasks.Remove(id);
            }
        }
        public Event Get(int id)
        {
            return _events[id];
            //return new Task(1, "Task1", "Description here", DateTime.Now, 1, 1, false, false);
        }

        public User GetCreatorOfEventId(int id)
        {
            // man come on where do I get a fucking UserRepository in here from?
            return new User(1, "Nela", "Geraldo", "nela@mail.com", "password", "+3165123", 10, 99, false, DateTime.UtcNow, "NL51INGB9304669103");
        }
    }
}
