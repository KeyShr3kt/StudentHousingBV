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

        public Task(int id, string description, DateTime createdAt, Building building, bool isShopping, bool isCompleted, User user) 
            : base(id, description, createdAt, building, user)
        {
            _isShopping = isShopping;
            _isCompleted = isCompleted;
        }

        public bool IsCompleted { get => _isCompleted; set => _isCompleted = value; }

        public bool IsShopping { get => _isShopping; set => _isShopping = value; }
    }
}
