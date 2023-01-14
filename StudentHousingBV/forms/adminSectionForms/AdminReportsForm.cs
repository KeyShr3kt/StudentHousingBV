using StudentHousingBV.controllers;
using StudentHousingBV.forms.components;
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

namespace StudentHousingBV.forms.adminSectionForms
{
    public partial class AdminReportsForm : Form
    {
        private UserManager _userManager;
        public UserManager userManager { get => _userManager; private set { _userManager = value; } }

        private BuildingManager _buildingManager;
        public BuildingManager buildingManager { get => _buildingManager; }

        private ReportManager _reportManager;
        public ReportManager reportManager { get => _reportManager; }
        public AdminReportsForm(UserManager manager)
        {
            InitializeComponent();
            _reportManager = new ReportManager(manager.CurrentUserId);
            _userManager = manager;
            _buildingManager = new BuildingManager(manager.CurrentUserId);
            fillBuildings();
            fillReports(new());
        }

        void fillBuildings()
        {
            cmbBoxBuildings.Items.Clear();
            buildingManager.GetAllBuildings().ForEach(building => { cmbBoxBuildings.Items.Add(building); });

        }

        public void fillReports(List<Report> reportsToFill)
        {
            flPanelReports.Controls.Clear();

            List<Report> reports;
            if (reportsToFill.Count == 0)
            {
                reports = reportManager.GetAll();
            }
            else
            {
                reports = new List<Report>(reportsToFill);
            }


            List<AdminReportComponent> components = new ();
            foreach (Report report in reports)
            {
                components.Add(new AdminReportComponent(report, userManager));
            }
            foreach (AdminReportComponent arc in components)
            {
                flPanelReports.Controls.Add(arc);
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text.Length > 0)
            {
                if (flPanelReports.Controls.Count == 0)
                {
                    fillReports(new List<Report>());
                }

                List<AdminReportComponent> testcomponents = new List<AdminReportComponent>();
                foreach (Control c in flPanelReports.Controls)
                {
                    if (c.GetType() == typeof(AdminReportComponent))
                    {
                        AdminReportComponent auc = (AdminReportComponent)c;
                        if (!auc.report.Title.ToLower().Contains(txtBoxSearch.Text.Trim().ToLower()) &&
                            !auc.CreatorName.ToLower().Contains(txtBoxSearch.Text.Trim().ToLower()))
                        {
                            testcomponents.Add(auc);
                        }
                    }
                }
                foreach (AdminReportComponent c in testcomponents)
                {
                    flPanelReports.Controls.Remove(c);
                }
            }
            else
            {
                flPanelReports.Controls.Clear();
                fillReports(new List<Report>());
            }
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            Building? building = (Building)cmbBoxBuildings.SelectedItem;
            bool review = rdBtnForReview.Checked;
            List<Report> reports;

            if (review)
            {
                if (building != null)
                    reports = reportManager.GetAllInBuildingIdForReview(building.Id);
                else
                    reports = reportManager.GetAllAllForReview();
            }
            else
            {
                if (building != null)
                    reports = reportManager.GetAllInBuildingId(building.Id);
                else
                    reports = reportManager.GetAll();
            }
            if (reports.Count == 0)
            {
                MessageBox.Show("There are no active reports in this category.");
            }
            fillReports(reports);
        }

        private void btnDisableFilters_Click(object sender, EventArgs e)
        {
            cmbBoxBuildings.SelectedItem = null;
            rdBtnForReview.Checked = false;
            fillReports(new List<Report>());
        }
    }
}
