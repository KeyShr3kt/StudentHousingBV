using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Report: Events
    {
        private int _inRegardOfEventId;
        public Report(int id, string description, DateTime createdAt, Building building, int inRegardOfEventId, User createdBy): 
            base(id, description, createdAt, building, createdBy)
        {
            _inRegardOfEventId = inRegardOfEventId;
        }
    }
}
