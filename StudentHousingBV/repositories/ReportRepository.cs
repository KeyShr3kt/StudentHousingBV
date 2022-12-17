using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.repositories
{
    public class ReportRepository
    {
        // List<Report> GetAll()

        // Report Get(id)
        // void Delete(obj)
        // void Insert(obj)
        // void Update(obj)

        public List<Report> GetAll()
        {
            return new List<Report>
            {
                new Report(1, 1, "Title", "des", DateTime.Now, 1, 1),
                new Report(2, 1, "Title", "des", DateTime.Now, 1, 1),
                new Report(3, 1, "Title", "des", DateTime.Now, 1, 1)
            };
        }

        public void MarkAsReviewed(int id)
        {
            // report.isReviewed = true;
        }

        public List<Report> GetAllInBuildingId(int id)
        {
            return new List<Report>();
        }

        public List<Report> GetAllInBuildingIdForReview(int id)
        {
            return new List<Report>();
        }

        public List<Report> GetAllForReview()
        {
            // isReviewd == false
            return new List<Report>();
        }
    }
}
