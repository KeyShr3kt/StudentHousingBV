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
    public partial class RuleComponent : UserControl
    {
        private StudentHousingBV.models.Rule _rule;
        private int _currentUserId;
        private int _currentBuildingId;

        public RuleComponent(StudentHousingBV.models.Rule rule, int currentUserId, int currentBuildingId)
        {
            InitializeComponent();
            this._rule = rule;
            this.lbRuleId.Text = this._rule.Id.ToString();
            this.lbRuleTitle.Text = this._rule.Title;
            this._currentBuildingId = currentBuildingId;
            this._currentUserId = currentUserId;
            string description = this._rule.Description;
            if (this._rule.Description.Length > 60)
            {
                description = description.Remove(57);
                description = description + "...";
            }
            this.lbRuleDescription.Text = description;
        }

        private void btnReportTask_Click(object sender, EventArgs e)
        {
            StudentHousingBV.forms.ReportForm _reportForm = new StudentHousingBV.forms.ReportForm(this._rule, _currentUserId, _currentBuildingId);
            _reportForm.Show();
        }

        private void linkDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoreInfoRule rule = new MoreInfoRule(_rule);
            rule.Show();
        }
    }
}
