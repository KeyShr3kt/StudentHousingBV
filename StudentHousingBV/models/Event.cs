using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Event
    {
        private int _id;
        private string _description;
        private DateTime _createdAt;
        private int _buildingId;

        public Event(int id, string description, DateTime createdAt, int buildingId)
        {
            this._id = id;
            this._description = description;
            this._createdAt = createdAt;
            this._buildingId = buildingId;
        }
    }
}
