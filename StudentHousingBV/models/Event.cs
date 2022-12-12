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
        private Building _building;
        private string _description;
        private User _createdBy;

        public User CreatedBy { get => _createdBy; private set { _createdBy = value; } }

        public string Description { get => _description; set => _description = value; }

        public int Id { get => _id; set => _id = value; }

        public DateTime CreatedAt { get => _createdAt; set => _createdAt = value; }

        public Building Building { get => _building; set => _building = value; }

        public Event(int id, string description, DateTime createdAt, Building building, User createdBy)
        {
            this.Id = id;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.Building = building;
        }

    }
}
