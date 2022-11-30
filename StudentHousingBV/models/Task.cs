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

        public Task(int id, string description, DateTime createdAt, int buildingId, bool isShopping, bool isCompleted) : base(id, description, createdAt, buildingId)
        {
            _isShopping = isShopping;
            _isCompleted = isCompleted;
        }
    }
}
