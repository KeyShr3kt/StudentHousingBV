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
        public List<Task> GetAllTasks()
        {
            List<Task> _tasks = new List<Task>();
            // adding from database
            return _tasks;
        }

        public List<Agreement> GetAllAgreements()
        {
            List<Agreement> _agreements = new List<Agreement>();
            // adding from database
            return _agreements;
        }

        public List<Rule> GetAllRules()
        {
            List<Rule> _rules = new List<Rule>();
            // adding from database
            return _rules;
        }

        public Task GetTask(int id)
        {
            foreach (Task task in GetAllTasks())
            {
                if (task.Id == id)
                {
                    return task;
                }
            }
            // return null;
            return new Task(1, "Task Title", "Task Description",
                new User(1, "First Name", "Last Name", "Email", "Password", "Phone Number", false, 0, 0, DateTime.UtcNow),
                DateTime.Now, false, false);
        }

        public Rule GetRule(int id)
        {
            foreach (Rule rule in GetAllRules())
            {
                if (rule.Id == id)
                {
                    return rule;
                }
            }
            // return null;
            return new Rule(1, "Task Title", "Task Description",
                new User(1, "First Name", "Last Name", "Email", "Password", "Phone Number", false, 0, 0, DateTime.UtcNow),
                DateTime.Now, DateTime.Now);
        }

        public Agreement GetAgreement(int id)
        {
            foreach (Agreement agreement in GetAllAgreements())
            {
                if (agreement.Id == id)
                {
                    return agreement;
                }
            }
            // return null;
            return new Agreement(1, "Task Title", "Task Description",
                new User(1, "First Name", "Last Name", "Email", "Password", "Phone Number", false, 0, 0, DateTime.UtcNow),
                DateTime.Now, false);
        }

        // List<Task> GetTasksForBuilding()
        // List<Rule> GetRuleForBuilding()
        // List<Agreement> GetAgreementsForBuilding()
        // List<Agreement> GetAgreementsWithStatusPending()
        // List<Agreement> GetAgreementsWithStatusAgreed()
    }
}
