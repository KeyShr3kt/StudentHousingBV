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
        private int _currUserid;
        UnitOfWork _unitOfWork = new();

        public int CurrentUserId { get => _currUserid;}

        public UnitOfWork unitOfWork { get => _unitOfWork;}

        public EventManager(int currUseid)
        {
            _currUserid = currUseid;
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

        public static User GetCreatorOfRule(Rule rule)
        {
            UnitOfWork unitOfWork = new();
            return unitOfWork.Users.GetCreatorOfEventId(rule.Id);
        }

        public void CreateTaskForBuilding(Building building, string title, string description, bool includesPayment)
        {
            var createdAt = DateTime.Now;
            if (title == "" || description == "" || building == null)
            {
                throw new ArgumentException("Invalid input!");
            }
            if (includesPayment)
            {
                unitOfWork.Events.CreateTaskGrocery(title, description, CurrentUserId, building.Id);
            }
            else
            {
                unitOfWork.Events.CreateTask(title, description, CurrentUserId, building.Id);
            }
        }

        public List<Task> GetAllTasksForReview(int? id)
        {
            List<Task> tasks;
            if (id == null)
            {
                tasks = unitOfWork.Events.GetAllTasksForReview();
            }
            else
            {
                tasks = unitOfWork.Events.GetAllTasksForReviewInBuilding((int)id);
            }
            return tasks;
        }
            
        public List<Task> GetAllTasksInBuildingIdWithStatusCompleted(int? id)
        {
            List<Task> tasks;
            if (id == null)
            {
                tasks = unitOfWork.Events.GetAllTasksWithStatusCompleted();
            } else 
            {
                tasks = unitOfWork.Events.GetAllTasksInBuildingIdWithStatusCompleted((int)id);
            }
            return tasks;
        }

        public List<Task> GetAllTasksInBuildingId(int? id)
        {
            List<Task> tasks;
            if (id == null)
            {
                tasks = unitOfWork.Events.GetAllTasks();
            } else
            {
                tasks = unitOfWork.Events.GetAllTasksInBuildingId((int)id);
            }
            return tasks;
        }

        public void DeleteTaskWithId(int id)
        {
            unitOfWork.Events.DeleteTask(id);
        }

        public void MarkTaskIdAsComplete(int id)
        {
            unitOfWork.Events.MarkTaskIdAsComplete(id);
        }

        public Event GetEvent(int id)
        {
            return unitOfWork.Events.Get(id);
        }

        public void MarkReportAsReviewed(Report report)
        {
            unitOfWork.Reports.MarkAsReviewed(report);
        }

        public bool UpvoteAgreement(Agreement agreement)
        {
            Reaction r = new(CurrentUserId, agreement.Id, true);
            return unitOfWork.Reactions.InsertUnique(r);
        }

        public bool DownvoteAgreement(Agreement agreement)
        {
            Reaction r = new(CurrentUserId, agreement.Id, false);
            return unitOfWork.Reactions.InsertUnique(r);
        }

        public bool DeleteAgreementReaction(Agreement agreement, Reaction reaction)
        {
            return unitOfWork.Reactions.Delete(reaction);
        }

        public bool CreateAgreement(Agreement agreement)
        {
            try
            {
                unitOfWork.Events.CreateAgreement(
                    agreement.Title,
                    agreement.Description,
                    agreement.CreatorId,
                    agreement.BuildingId,
                    agreement.StartDateTime,
                    agreement.EndDateTime
                );
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteAgreement(Agreement agreement)
        {
            try
            {
                unitOfWork.Events.Delete(agreement.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Agreement> GetAllAgreements()
        {
            return unitOfWork.Events.GetAllAgreements();
        }

        public List<Agreement> GetAcceptedAgreements(Building building)
        {
            return unitOfWork.Events.GetAcceptedAgreements(building.Id);
        }

        public List<Agreement> GetPendingAgreements(Building building)
        {
            return unitOfWork.Events.GetPendingAgreements(building.Id);
        }

        public int GetAgreementUpvotes(Agreement agreement)
        {
            return unitOfWork.Reactions.CountReactionsForAgreement(agreement.Id, true)!.Value;
        }

        public int GetAgreementDownvotes(Agreement agreement)
        {
            return unitOfWork.Reactions.CountReactionsForAgreement(agreement.Id, false)!.Value;
        }

        public Reaction? GetUserReactionOnAgreement(Agreement agreement, User user)
        {
            return unitOfWork.Reactions.GetUserReactionOnAgreement(user.Id, agreement.Id);
        }

        public User GetAgreementCreator(Agreement agreement)
        {
            return unitOfWork.Users.GetCreatorOfEventId(agreement.Id);
        }
    }
}
