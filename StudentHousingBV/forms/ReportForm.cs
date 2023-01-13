using StudentHousingBV.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.forms
{
    public partial class ReportForm : Form
    {
        private ReportManager _reportManager;
        private StudentHousingBV.models.Task? _reportedTask;
        private StudentHousingBV.models.Rule? _reportedRule;
        private int _currentUserId;
        private int _currentBuildingId;

        public ReportForm(StudentHousingBV.models.Task reportedTask, int currentUserId, int currentBuildingId)
        {
            InitializeComponent();
            this._reportedTask = reportedTask;
            this._currentUserId = currentUserId;
            this._currentBuildingId = currentBuildingId;
            _reportManager = new ReportManager(_currentUserId);
            this.lbReportedEvent.Text = $"Reported task: #{this._reportedTask.Id} {this._reportedTask.Description}";
        }

        public ReportForm(StudentHousingBV.models.Rule reportedRule, int currentUserId, int currentBuildingId)
        {
            InitializeComponent();
            this._reportedRule = reportedRule;
            this._currentUserId = currentUserId;
            this._currentBuildingId = currentBuildingId;
            _reportManager = new ReportManager(_currentUserId);
            this.lbReportedEvent.Text = $"Reported rule: #{this._reportedRule.Id} {this._reportedRule.Description}";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string title = "";
            int reportedEvent = 0;
            if (this._reportedRule != null)
            {
                title = $"Report for event {this._reportedRule.EventId}";
                reportedEvent = this._reportedRule.EventId;
            }
            else if (_reportedTask != null)
            {
                title = $"Report for event {this._reportedTask.EventId}";
                reportedEvent = this._reportedTask.EventId;
            }
            string description = this.tbDescription.Text;
            _reportManager.Create(title, description, _currentUserId, _currentBuildingId, reportedEvent, 0);
        }
    }
}
