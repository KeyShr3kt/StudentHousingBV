using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Event
    {
        private int _id;
        private DateTime _createdAt;
        private int _buildingId;
        private string _description;

        public Event(int id, string description, DateTime createdAt, int buildingId)
        {
            this._id = id;
            this._description = description;
            this._createdAt = createdAt;
            this._buildingId = buildingId;
        }

        public string Description { get => _description; set => _description = value; }

        public int Id { get => _id; set => _id = value; }
        
        public DateTime CreatedAt { get => _createdAt; set => _createdAt = value; }

        public int BuildingId { get => _buildingId; set => _buildingId = value; }
    }
}
