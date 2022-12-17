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
        public int TargetedToEventId { get => _targetedToEventId;}
        public int Id { get => _id; }

        public string Title { get => _title; }
        public string Description { get => _description; }
        public DateTime CreatedAt { get => _createdAt; }

        public int CreatorId { get => _creatorId; }

        public int BuildingId { get => _buildingId; }

        public bool IsReviewd { get => _isReviewed; }

        public Report(int id, int targetedToEventId, string title, string description, DateTime createdAt, int creatorId, int buildingId)
        {
            _id = id;
            _targetedToEventId = targetedToEventId;
            _title = title;
            _description = description;
            _createdAt = createdAt;
            _creatorId = creatorId;
            _buildingId = buildingId;
        }

    }
}
