using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rule = StudentHousingBV.models.Rule;
using Task = StudentHousingBV.models.Task;

namespace StudentHousingBV.repositories
{
    public class EventRepository
    {
        public List<Task> GetAllTasks() { return new List<Task>(); }
        public List<Rule> GetAllRules() { return new List<Rule>{ new Rule(1, "Title", "description", DateTime.Now, 1, 1, DateTime.Now) }; }
        public List<Agreement> GetAllAgreements() { return new List<Agreement>(); }
        public List<Report> GetAllReports() { return new List<Report>(); }

        public List<Rule> GetAllRulesInBuildingId(int id)
        {
            return new List<Rule>();
        }

        public void CreateRule(string title, string description, DateTime createdAt, int createdByUserId, int inBuildingId, DateTime updatedAt)
        {
        }

        public User GetCreatorOfEventId(int id)
        {
            return new User(1, "Nela", "Geraldo", "nela@mail.com", "password", "+3165123", 10, 99, false, DateTime.UtcNow);
        }

        public void UpdateRule(int ruleId, string title, string description, int creatorId, int buildingId, DateTime updatedAt)
        {

        }
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
