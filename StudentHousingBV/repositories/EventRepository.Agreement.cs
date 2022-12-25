using StudentHousingBV.models;

namespace StudentHousingBV.repositories
{
    public partial class EventRepository
    {
        private Dictionary<int, Agreement> _agreements = new();

        public List<Agreement> GetAllAgreements()
        {
            return _agreements.Values.ToList();
        }

        public Agreement? GetAgreement(int id)
        {
            _agreements.TryGetValue(id, out Agreement? agreement);
            return agreement;
        }

        public void CreateAgreement(
            string title,
            string description,
            int creatorId,
            int buildingId,
            DateTime startDateTime,
            DateTime endDateTime
        )
        {
            int id = _lastId++;
            Agreement agreement = new(
                id,
                title,
                description,
                DateTime.Now,
                creatorId,
                buildingId,
                false,
                startDateTime,
                endDateTime
            );
            _agreements[id] = agreement;
            _events[id] = agreement;
        }

        public void UpdateAgreement(
            int id,
            string title,
            string description,
            int creatorId,
            int buildingId,
            bool isAccepted
        )
        {
            if (_agreements.TryGetValue(id, out Agreement? agreement))
            {
                agreement.Title = title;
                agreement.Description = description;
                agreement.CreatorId = creatorId;
                agreement.BuildingId = buildingId;
                agreement.IsAccepted = isAccepted;
            }
        }

        public List<Agreement> GetAgreementsForBuilding(int buildingId)
        {
            return _agreements.Values.Where(a => a.BuildingId == buildingId).ToList();
        }

        public List<Agreement> GetPendingAgreements()
        {
            return _agreements.Values.Where(a => !a.IsAccepted).ToList();
        }

        public List<Agreement> GetAcceptedAgreements()
        {
            return _agreements.Values.Where(a => a.IsAccepted).ToList();
        }
    }
}
