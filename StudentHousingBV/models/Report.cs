using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Report: Event
    {
        private int _targetedToEventId;
        public Report(int id, string title, string description, DateTime createdAt, int creatorId, int buildingId, int eventId) 
            : base(id, title, description, createdAt, creatorId, buildingId)
        {
            _targetedToEventId = eventId;
        }

        public int TargetedToEventId { get => _targetedToEventId; private set => _targetedToEventId = value; }
    }
}
