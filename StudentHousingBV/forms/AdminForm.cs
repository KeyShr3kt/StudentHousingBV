using StudentHousingBV.controllers;
using StudentHousingBV.forms.adminSectionForms;
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
    public partial class AdminForm : Form
    {
        private Form? _activeForm;
        private UserManager _userManager;
        public UserManager userManager { get => _userManager; private set {_userManager = value; } }
        public AdminForm(UserManager manager)
        {
            InitializeComponent();
            _userManager = manager;
            OpenChildForm(new AdminUsersForm(_userManager), this);
            
        }

        public AdminForm(int userId) 
        {
            InitializeComponent();
            _userManager = new UserManager(userId);
            //Color color = ColorTranslator.FromHtml("#D9514EFF");
            OpenChildForm(new AdminUsersForm(_userManager), this);
            // sidebarPanel.BackColor = Color.FromArgb(217, 81, 78);


        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.adminSectionForms.AdminUsersForm(userManager), this);
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
           OpenChildForm(new AdminRulesForm(userManager.CurrentUserId), this);
        }

       

        private void btnTasks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminTasksForm(userManager.CurrentUserId), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender) {

            if (_activeForm != null) _activeForm.Close();

            //ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.BackColor = Color.FromArgb(42, 43, 45);
            childForm.Dock = DockStyle.Fill;
            this.pnlActiveForm.Controls.Add(childForm);
            this.pnlActiveForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminReportsForm(userManager), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPanel login = new LoginPanel();
            login.Show();
            this.Close();
        }

 
    }

}

