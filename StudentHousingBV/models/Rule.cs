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

        public Rule(int id, string title, string description, StudentHousingBV.models.User user, DateTime createdAt, DateTime updatedAt) : base(id, title, description, user, createdAt)
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
    }
}
