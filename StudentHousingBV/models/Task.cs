using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Task : Event
    {
        private int _assignedToUserId;
        private bool _isShopping;
        private bool _isCompleted;
        private int? _totalPrice;

        public Task()
        { }

        public Task(int id, string title, string description, DateTime createdAt, int creatorId, int buildingId, int assignedToUserId, bool isShopping, bool isCompleted) 
            : base(id, title, description, createdAt, creatorId, buildingId)
        {
            this._assignedToUserId = assignedToUserId;
            this._isShopping = isShopping;
            this._isCompleted = isCompleted;
            this._totalPrice = null;
        }

        public Task(int id, string title, string description, DateTime createdAt, int creatorId, int buildingId, int assignedToUserId, bool isShopping, bool isCompleted, int totalPrice)
            : base(id, title, description, createdAt, creatorId, buildingId)
        {
            this._assignedToUserId = assignedToUserId;
            this._isShopping = isShopping;
            this._isCompleted = isCompleted;
            this._totalPrice = totalPrice;
        }

        public bool IsCompleted
        {
            get
            { return this._isCompleted; }
            set
            { this._isCompleted = value; }
        }

        public bool IsShopping
        {
            get
            { return this._isShopping; }
            set
            { this._isShopping = value; }
        }

        public int AssignedToUserId
        {
            get
            { return this._assignedToUserId; }
            set
            { this._assignedToUserId = value; }
        }

        public int? TotalPrice
        {
            get
            { return this._totalPrice; }
            set
            { this._totalPrice = value; }
        }

        public int EventId { get; set; } // so we can read columns using reflection
    }
}
