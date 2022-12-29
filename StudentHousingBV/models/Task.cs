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
        private byte[]? _image;

        public Task()
        {

        }
        public Task(int id, string title, string description, DateTime createdAt, int creatorId, int buildingId, bool isShopping, bool isCompleted) 
            : base(id, title, description, createdAt, creatorId, buildingId)
        {
            this._isShopping = isShopping;
            this._isCompleted = isCompleted;
            this._totalPrice = null;
        }

        public Task(int id, string title, string description, DateTime createdAt, int creatorId, int buildingId, bool isShopping, bool isCompleted, int totalPrice)
            : base(id, title, description, createdAt, creatorId, buildingId)
        {
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

        public int? TotalPrice { get => _totalPrice; set => _totalPrice = value; }

        public int EventId { get; set; } // so we can read columns using reflection

        public byte[]? Image { get => _image; set => _image = value; }
    }
}
