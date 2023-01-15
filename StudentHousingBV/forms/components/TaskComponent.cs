﻿using StudentHousingBV.models;
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
    public partial class TaskComponent : UserControl
    {
        private StudentHousingBV.models.Task _task;
        private int _currentUserId;
        private int _currentBuildingId;

        public TaskComponent(StudentHousingBV.models.Task task, int currentUserId, int currentBuildingId)
        {
            InitializeComponent();
            this._task = task;
            this.lbTaskDescription.Text = this._task.Title;
            this._currentUserId = currentUserId;
            this._currentBuildingId = currentBuildingId;
            if (this._task.IsShopping == true && this._task.AssignedToUserId == currentUserId && this._task.TotalPrice == null) 
            {
                this.btnTaskComponent.Enabled = true;
            }
        }

        private void btnTaskComponent_Click(object sender, EventArgs e)
        {
            StudentHousingBV.forms.CompletePaymentForm _completePaymentForm = new StudentHousingBV.forms.CompletePaymentForm(this._task, this._currentUserId);
            _completePaymentForm.Closed += (s, args) =>
            {
                this.btnTaskComponent.Enabled = false;
            };
            _completePaymentForm.Show();
        }

        private void btnReportTask_Click(object sender, EventArgs e)
        {
            StudentHousingBV.forms.ReportForm _reportForm = new StudentHousingBV.forms.ReportForm(this._task, _currentUserId, _currentBuildingId);
            _reportForm.Show();
        }
    }
}
