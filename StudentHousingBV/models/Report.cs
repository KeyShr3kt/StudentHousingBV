using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Report
    {
        private int _id; 
        private int _targetedToEventId;
        private string _title;
        private string _description;
        private DateTime _createdAt;
        private int _creatorId;
        private int _buildingId;
        private bool _isReviewed;

        public int TargetedToEventId { get => _targetedToEventId; private set => _targetedToEventId = value; }
        public int Id { get => _id; private set => _id = value; }

        public string Title { get => _title; private set => _title = value; }
        public string Description { get => _description; private set => _description = value; }
        public DateTime CreatedAt { get => _createdAt; private set => _createdAt = value; }

        public int CreatorId { get => _creatorId; private set => _creatorId = value; }

        public int BuildingId { get => _buildingId; private set => _buildingId = value; }

        public bool IsReviewed { get => _isReviewed; private set => _isReviewed = value; }

        public Report(int id, int targetedToEventId, string title, string description, DateTime createdAt, int creatorId, int buildingId)
        {
            _id = id;
            _targetedToEventId = targetedToEventId;
            _title = title;
            _description = description;
            _createdAt = createdAt;
            _creatorId = creatorId;
            _buildingId = buildingId;
            _isReviewed = false;
        }

        public Report()
        { }
    }
}
