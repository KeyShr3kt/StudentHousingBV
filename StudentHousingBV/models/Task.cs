using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Task : Event
    {
        private bool _isShopping;
        private bool _isCompleted;
        private int? _totalPrice;

        public Task(int id, string title, string description, DateTime createdAt, int creatorId, int buildingId, bool isShopping, bool isCompleted) 
            : base(id, title, description, createdAt, creatorId, buildingId)
        {
            this._isShopping = isShopping;
            this._isCompleted = isCompleted;
            _totalPrice = null;
        }

        public Task(int id, string title, string description, DateTime createdAt, int creatorId, int buildingId, bool isShopping, bool isCompleted, int totalPrice)
            : base(id, title, description, createdAt, creatorId, buildingId)
        {
            this._isShopping = isShopping;
            this._isCompleted = isCompleted;
            _totalPrice = totalPrice;
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

        public int? TotalPrice { get => _totalPrice; }
    }
}
