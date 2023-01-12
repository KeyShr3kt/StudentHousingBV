using StudentHousingBV.controllers;
using StudentHousingBV.forms.adminSectionForms;
using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.forms.components
{
    public partial class AdminReportComponent : UserControl
    {
        private Report _report;
        private User _user;
        private Building _building;

        public Report report { get => _report; }

        public string CreatorName { get; private set; }
        public UserManager userManager { get; }
        public BuildingManager buildingManager { get; }
        public AdminReportComponent(Report report, UserManager manager)
        {
            InitializeComponent();
            userManager = manager;
            _report = report;
          
            buildingManager = new BuildingManager(manager.CurrentUserId);
            lblTitle.Text = report.Title;
            User user = (userManager.GetUser(report.CreatorId));
            _user = user;
            lblCreatedBy.Text = user.FirstName + " " + user.LastName;
            CreatorName = user.FirstName + " " + user.LastName;
            Building building = buildingManager.GetBuidingWithId(report.BuildingId);
            _building = building;
            lblBuilding.Text = building.Address;
            if (report.IsReviewed)
            {
                btnReview.Hide();
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            ReviewReportForm rrf = new ReviewReportForm(_report, _user, _building, userManager.CurrentUserId);
            rrf.Show();
        }
    }
}
