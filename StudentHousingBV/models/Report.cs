using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Report: Event
    {
        private int _inRegardOfEventId;
        public Report(int id, string description, DateTime createdAt, int buildingId, int inRegardOfEventId): base(id, description, createdAt, buildingId)
        {
            _inRegardOfEventId = inRegardOfEventId;
        }
    }
}
