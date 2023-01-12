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

namespace StudentHousingBV.forms
{
    public partial class CreateAgreementForm : Form
    {
        private EventManager _eventManager;
        private Building _curUserBuilding;
        private User _curUser;
        public CreateAgreementForm(EventManager eventManager, Building curBuilding, User curUser)
        {
            _eventManager = eventManager;
            _curUserBuilding = curBuilding;
            _curUser = curUser;
            InitializeComponent();
            dtpStartsAt.Value = DateTime.Now;
            dtpEndsAt.Value = DateTime.Now.AddDays(1);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            DateTime startDateTime = dtpStartsAt.Value;
            DateTime endDateTime = dtpEndsAt.Value;
            if (title.Length < 3)
            {
                MessageBox.Show("Title must be at least 3 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (description.Length < 3)
            {
                MessageBox.Show("Description must be at least 3 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (startDateTime > endDateTime)
            {
                MessageBox.Show("Start date must be before end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Agreement agreement = new(0, title, description, DateTime.Now, _curUser.Id, _curUserBuilding.Id, false, startDateTime, endDateTime);
            if (_eventManager.CreateAgreement(agreement))
            {
                MessageBox.Show("Agreement created successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Agreement creation failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
