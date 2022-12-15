using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rule = StudentHousingBV.models.Rule;
using Task = StudentHousingBV.models.Task;

namespace StudentHousingBV.controllers
{
    public class EventManager
    {
        private int _currUseid;
        public int CurrentUserId { get => _currUseid;}

        UnitOfWork _unitOfWork = new();

        public UnitOfWork unitOfWork { get => _unitOfWork;}

        public EventManager(int currUseid)
        {
            _currUseid = currUseid;
        }

        public List<Rule> GetAllRules()
        {
            return unitOfWork.Events.GetAllRules();
        }

        public List<Task> GetAllTasks()
        {
            return unitOfWork.Events.GetAllTasks();
        }

        public List<Rule> GetAllRulesInBuildingId(int id)
        {
            return unitOfWork.Events.GetAllRulesInBuildingId(id);
        }

        public void CreateRuleForBuilding(string title, string description, Building building)
        {
            if (title == "" || description == "" || building == null)
            {
                throw new ArgumentException("Invalid input!");
            }
           unitOfWork.Events.CreateRule(title, description,CurrentUserId, building.Id);
        }

        public void UpdateRuleForBuilding(int ruleId, string title, string description, Building building)
        {
     
            if (title == "" || description == "" || building == null)
            {
                throw new ArgumentException("Invalid input!");
            }
            unitOfWork.Events.UpdateRule(ruleId, title, description, CurrentUserId, building.Id);
        }

        public User GetCreatorOfRule(Rule rule)
        {
            return unitOfWork.Events.GetCreatorOfEventId(rule.Id);
        }

        public void CreateTaskForBuilding(Building building, string title, string description, bool includesPayment)
        {
            var createdAt = DateTime.Now;
            if (title == "" || description == "" || building == null)
            {
                throw new ArgumentException("Invalid input!");
            }

            unitOfWork.Events.CreateTask(title, description, CurrentUserId, building.Id);
        }

        public List<Task> GetAllTasksInBuildingIdWithTotalPriceAndNotCompleted(int id)
        {
            return unitOfWork.Events.GetAllTasksInBuildingIdWithTotalPriceAndNotCompleted(id);
        }
            
        public List<Task> GetAllTasksInBuildingIdWithStatusCompleted(int id)
        {
            return unitOfWork.Events.GetAllTasksInBuildingIdWithStatusCompleted(id);
        }

        public List<Task> GetAllTasksInBuildingId(int id)
        {
            return unitOfWork.Events.GetAllTasksInBuildingId(id);
        }

        public void DeleteTaskWithId(int id)
        {
            unitOfWork.Events.Delete(id);
        }
    }
}
