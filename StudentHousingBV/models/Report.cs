using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.models
{
    public class Report: Event
    {
        private StudentHousingBV.models.Event _inRegardOfEvent;
        public Report(int id, string title, string description, StudentHousingBV.models.User user, DateTime createdAt, StudentHousingBV.models.Event inRegardOfEvent) : base(id, title, description, user, createdAt)
        {
            _inRegardOfEvent = inRegardOfEvent;
        }
    }
}
