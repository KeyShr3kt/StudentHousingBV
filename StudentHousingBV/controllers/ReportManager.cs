using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.controllers
{
    public class ReportManager
    {
        private int _currUseid;
        public int CurrentUserId { get => _currUseid; }

        UnitOfWork _unitOfWork = new();

        public UnitOfWork unitOfWork { get => _unitOfWork; }

        public ReportManager(int id)
        {
            _currUseid = id;
        }
        public List<Report> GetAll()
        {
            return unitOfWork.Reports.GetAll();
        }

        public List<Report> GetAllInBuildingId(int? id)
        {
            List<Report> reports;
            if (id != null)
            {
                reports = unitOfWork.Reports.GetAllInBuildingId((int)id);
            } else
            {
                reports=unitOfWork.Reports.GetAll();
            }
            return reports;
        }

        public List<Report> GetAllInBuildingIdForReview(int id)
        {
           return unitOfWork.Reports.GetAllInBuildingIdForReview(id);
        }

        public List<Report> GetAllAllForReview()
        {
            return unitOfWork.Reports.GetAllForReview();
        }

        public void Create(string title, string description, int creatorId, int buildingId, int targetedToEventId, int isReviewed)
        {
            unitOfWork.Reports.Insert(title, description, creatorId, buildingId, targetedToEventId, isReviewed);
        }
    }
}
