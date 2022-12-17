using StudentHousingBV.controllers;
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
    public partial class ReviewReportForm : Form
    {
        private Report _report; 
        public EventManager eventManager { get; }
        public ReviewReportForm(Report report, User user, Building building, int currUserId)
        {
            InitializeComponent();
            eventManager = new EventManager(currUserId);
            _report = report;
            lblTitle.Text = report.Title;
            lblDescription.Text = report.Description;
            lblBuilding.Text = building.Address;
            lblCreatedAt.Text = report.CreatedAt.ToString();
            lblUserName.Text = "Received from from: " + user.FirstName + " " + user.LastName + ", email: " + user.EmailAddress;
            lblReportingEvent.Text = (eventManager.GetEvent(report.TargetedToEventId)).Title;
        }

        private void btnReportedEventInfo_Click(object sender, EventArgs e)
        {
            AdminReportedEventPreview rep = new AdminReportedEventPreview(_report.TargetedToEventId, eventManager);
            rep.Show();
        }

        private void btnMarkAsReviewed_Click(object sender, EventArgs e)
        {
            eventManager.MarkReportAsReviewed(_report.Id);
            this.Close();
        }
    }
}
