using StudentHousingBV.controllers;
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
        public List<Task> GetAllTasks() 
        {
            return new List<Task> {
                new Task(1, "Task1", "Description here", DateTime.Now, 1, 1, false, false),
                new Task(2, "Task2", "Description here", DateTime.Now, 1, 1, true, false, 337),
                new Task(3, "Task3", "Description here", DateTime.Now, 1, 1, true, false)
            };
        }
        public List<Rule> GetAllRules() { return new List<Rule>{ new Rule(1, "Title", "description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description", DateTime.Now, 1, 1, DateTime.Now) }; }
        public List<Agreement> GetAllAgreements() { return new List<Agreement>(); }
        public List<Report> GetAllReports() { return new List<Report>(); }

        public List<Rule> GetAllRulesInBuildingId(int id)
        {
            return new List<Rule>();
        }

        public void CreateRule(string title, string description, int createdByUserId, int inBuildingId)
        {
        }
        public List<Task> GetAllTasksWithTotalPriceAndNotCompleted()
        {
            return new List<Task>();
        }

        public List<Task> GetAllTasksWithStatusCompleted()
        {
            return new List<Task>();
        }

        public User GetCreatorOfEventId(int id)
        {
            return new User(1, "Nela", "Geraldo", "nela@mail.com", "password", "+3165123", 10, 99, false, DateTime.UtcNow, "NL51INGB9304669103");
        }

        public void UpdateRule(int ruleId, string title, string description, int creatorId, int buildingId)
        {

        }

        public void CreateTask(string title, string description, int creatorId, int buildingId)
        {

        }

        public List<Task> GetAllTasksInBuildingIdWithTotalPriceAndNotCompleted(int id)
        {
            return new List<Task>();
        }

        public List<Task> GetAllTasksInBuildingIdWithStatusCompleted(int id)
        {
            return new List<Task>();
        }

        public List<Task> GetAllTasksInBuildingId(int id)
        {
            return new List<Task>();
        }

        public void Delete(int id)
        {
            // delete event with id
        }
        public Event Get(int id)
        {
            return new Task(1, "Task1", "Description here", DateTime.Now, 1, 1, false, false);
        }

        public void MarkTaskIdAsComplete(int id)
        {
            // to do 
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
