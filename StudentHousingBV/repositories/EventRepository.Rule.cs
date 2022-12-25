using StudentHousingBV.models;

namespace StudentHousingBV.repositories
{
    public partial class EventRepository
    {
        private Dictionary<int, Rule> _rules = new();
        public List<Rule> GetAllRules() {
            return _rules.Values.ToList();
            //return new List<Rule> { new Rule(1, "Title", "description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description", DateTime.Now, 1, 1, DateTime.Now) };
        }

        public List<Rule> GetAllRulesInBuildingId(int buildingId)
        {
            return _rules.Values.Where(r => r.BuildingId == buildingId).ToList();
        }

        public void CreateRule(string title, string description, int creatorId, int buildingId)
        {
            int id = _lastId++;
            Rule rule = new(id, title, description, DateTime.Now, creatorId, buildingId, DateTime.Now);
            _rules[id] = rule;
            _events[id] = rule;

        }

        public void UpdateRule(int id, string title, string description, int creatorId, int buildingId)
        {
            if (_rules.TryGetValue(id, out Rule? rule))
            {
                rule.Title = title;
                rule.Description = description;
                rule.CreatorId = creatorId;
                rule.BuildingId = buildingId;
                rule.UpdatedAt = DateTime.Now;
            }
        }

        public Rule? GetRule(int id)
        {
            _rules.TryGetValue(id, out Rule? rule);
            return rule;
        }
    }
}
