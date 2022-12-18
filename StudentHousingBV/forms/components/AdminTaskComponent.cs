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
using System.Windows.Forms;

namespace StudentHousingBV.forms.components
{
    public partial class AdminTaskComponent : UserControl
    {
        private models.Task _task; 
        private EventManager _eventManager;
        public EventManager eventManager { get => _eventManager; }
        public AdminTaskComponent(models.Task task, EventManager manager)
        {
            InitializeComponent();
            _eventManager = manager;
            _task = task;
            lblTitle.Text = ((Event)task).Title;
            lblDescription.Text = ((Event) task).Description;
            lblCreatedAt.Text = ((Event) task).CreatedAt.ToString();
            lblTaskIdHidden.Text = ((Event) task).Id.ToString();
            lblTaskIdHidden.Hide();
            if (task.TotalPrice == null)
            {
                btnComplete.Hide();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            AdminTaskReview atr = new AdminTaskReview(_task, eventManager.CurrentUserId);
            atr.Show();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Do you really want to delete {lblTitle.Text}?", "Attention!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                eventManager.DeleteTaskWithId(int.Parse(lblTaskIdHidden.Text));
            }
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Color color = Color.FromArgb(220, 220, 220);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, color,
            ButtonBorderStyle.Solid);
            base.OnPaint(e);
        }
    }
}
