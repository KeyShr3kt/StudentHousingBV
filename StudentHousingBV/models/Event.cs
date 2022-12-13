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
        private string _description;
        private string _title;
        private int _creatorId;
        private int _buildingId;

        public Event(int id, string title, string description, DateTime createdAt, int creatorId, int buildingId)
        {
            this._id = id;
            this._description = description;
            this._createdAt = createdAt;
            this._title = title;
            this._creatorId = creatorId;
            this._buildingId = buildingId;
        }

        public string Description
        {
            get
            { return this._description; }
            set
            { this._description = value; }
        }

        public int Id
        {
            get
            { return this._id; }
            set
            { this._id = value; }
        }

        public DateTime CreatedAt
        {
            get
            { return this._createdAt; }
            set
            { this._createdAt = value; }
        }

        public string Title
        {
            get
            { return this._title; }
            set
            { this._title = value; }
        }

        public int CreatorId
        {
            get
            { return this._creatorId; }
            set
            { this._creatorId = value; }
        }

        public int BuildingId { get => this._buildingId; set => _buildingId = value; }
    }
}
