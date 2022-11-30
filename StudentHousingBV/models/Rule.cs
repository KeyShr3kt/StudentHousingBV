using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Rule : Event
    {
        private DateTime _updatedAt;

        public Rule(int id, string description, DateTime createdAt, int buildingId, DateTime updatedAt) : base(id, description, createdAt, buildingId)
        {
            _updatedAt = updatedAt;
        }

        public DateTime UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
    }
}
