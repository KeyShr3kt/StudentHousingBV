using StudentHousingBV.controllers;
using StudentHousingBV.forms.components;
using StudentHousingBV.models;
using System.Drawing.Text;
using Task = StudentHousingBV.models.Task;

namespace StudentHousingBV.forms
{
    public partial class StudentPanel : Form
    {
        private User _currUser;
        private Building _currUserBuilding;
        private BuildingManager _buildingManager;
        private EventManager _eventManager;

        public StudentPanel(User user)
        {
            _currUser = user;
            _buildingManager = new BuildingManager(_currUser.Id);
            _currUserBuilding = _buildingManager.GetForUser(user);
            _eventManager = new EventManager(_currUser.Id);
            InitializeComponent();
            updateAgreements();
            updateTasks();
            updateRules();
            updateAccount();
        }

        private void updateAgreements()
        {
            flowOpenAgreements.Controls.Clear();
            flowClosedAgreements.Controls.Clear();
            foreach (Agreement agreement in _eventManager.GetPendingAgreements(_currUserBuilding))
            {
                flowOpenAgreements.Controls.Add(new AgreementCard(agreement, _eventManager, _currUser));
            }
            foreach (Agreement agreement in _eventManager.GetAcceptedAgreements(_currUserBuilding))
            {
                flowClosedAgreements.Controls.Add(new AgreementCard(agreement, _eventManager, _currUser));
            }
        }

        private void btnCreateAgreement_Click(object sender, EventArgs e)
        {
            CreateAgreementForm f = new(_eventManager, _currUserBuilding, _currUser);
            if (f.ShowDialog() == DialogResult.OK)
            {
                updateAgreements();
            }
        }

        private void updateTasks()
        {
            fpPageTasks.Controls.Clear();
            foreach (Task task in _eventManager.GetAllTasksInBuildingId(_currUserBuilding.Id))
            {
                fpPageTasks.Controls.Add(new TaskComponent(task, _currUser.Id, _currUserBuilding.Id));
            }
        }

        private void updateRules()
        {
            flowRules.Controls.Clear();
            foreach (Rule rule in _eventManager.GetAllRulesInBuildingId(_currUserBuilding.Id))
            {
                flowRules.Controls.Add(new RuleComponent(rule, _currUser.Id, _currUserBuilding.Id));
            }
        }

        private void updateAccount()
        {
            lbAccountName.Text = $"{_currUser.LastName} {_currUser.FirstName}";
            lbAccountEmail.Text = $"{_currUser.EmailAddress}";
            lbAccountPhone.Text = $"{_currUser.PhoneNumber}";
            lbAccountPosVotes.Text = $"{_currUser.PositiveVotes}";
            lbAccountNegVotes.Text = $"{_currUser.NegativeVotes}";
        }

        private void btnAccountChEmail_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeDetails updateUserForm = new ChangeDetails(_currUser, "Email");
            updateUserForm.Text = $"Change email";
            updateUserForm.Closed += (s, args) =>
            {
                this.Show();
                updateAccount();
            };
            updateUserForm.Show();
        }

        private void btnAccountChPhone_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeDetails updateUserForm = new ChangeDetails(_currUser, "Phone");
            updateUserForm.Text = $"Change phone number";
            updateUserForm.Closed += (s, args) =>
            {
                this.Show();
                updateAccount();
            };
            updateUserForm.Show();
        }

        private void btnAccountLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}