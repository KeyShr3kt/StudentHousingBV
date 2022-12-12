using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task = StudentHousingBV.models.Task;

namespace StudentHousingBV.repositories
{
    public class EventRepository
    {
        public List<Task> GetAllTasks() { return new List<Task>(); }
        public List<Rule> GetAllRules() { return new List<Rule>(); }
        public List<Agreement> GetAllAgreements() { return new List<Agreement>(); }
        public List<Report> GetAllReports() { return new List<Report>(); }

        // GetTask(id)
        // GetRule(id)
        // GetAgreement(id)
        // GetReport(id)

       // List<Task> GetTasksForBuilding()
       // List<Rule> GetRuleForBuilding()
       // List<Agreement> GetAgreementsForBuilding()
       // List<Report> GetReportsForBuilding()
       // List<Agreement> GetAgreementsWithStatusPending()
       // List<Agreement> GetAgreementsWithStatusAgreed()
    }
}
