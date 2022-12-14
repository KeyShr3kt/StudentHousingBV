using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rule = StudentHousingBV.models.Rule;

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

        public List<Rule> GetAllRulesInBuildingId(int id)
        {
            return unitOfWork.Events.GetAllRulesInBuildingId(id);
        }

        public void CreateRuleForBuilding(string title, string description, Building building)
        {
           var createdAt = DateTime.Now;
            if (title == "" || description == "" || building == null)
            {
                throw new ArgumentException("Invalid input!");
            }
           unitOfWork.Events.CreateRule(title, description, createdAt, CurrentUserId, building.Id, createdAt);
        }

        public void UpdateRuleForBuilding(int ruleId, string title, string description, Building building)
        {
            var updatedAt = DateTime.Now;
            if (title == "" || description == "" || building == null)
            {
                throw new ArgumentException("Invalid input!");
            }
            unitOfWork.Events.UpdateRule(ruleId, title, description, CurrentUserId, building.Id, updatedAt);
        }

        public User GetCreatorOfRule(Rule rule)
        {
            return unitOfWork.Events.GetCreatorOfEventId(rule.Id);
        }
    }
}
