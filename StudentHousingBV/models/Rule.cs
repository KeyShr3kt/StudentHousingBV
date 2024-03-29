﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Rule : Event
    {
        private DateTime _updatedAt;

        public Rule()
        { }
        public Rule(int id, string title, string description, DateTime createdAt, int creatorId, int buildingId, DateTime updatedAt) : base(id, title, description, createdAt, creatorId, buildingId)
        {
            _updatedAt = updatedAt;
        }

        public DateTime UpdatedAt
        {   
            get
            { return this._updatedAt; }
            set
            { this._updatedAt = value; }
        }

        public int EventId { get; set; } // so we can read columns using reflection
    }
}
