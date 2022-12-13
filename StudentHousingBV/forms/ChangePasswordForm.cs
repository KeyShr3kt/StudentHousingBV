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
    public partial class ChangePasswordForm : Form
    {
        private UserManager _userManager;
        public UserManager userManager { get => _userManager; private set { _userManager = value; } }
        public ChangePasswordForm(int userId)
        {
            InitializeComponent();
            _userManager = new UserManager(userId);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string newPassword = this.txtBoxNewPassword.Text.Trim();
                string confirmPassword = this.txtBoxConfirmPassword.Text.Trim();

                if (newPassword != confirmPassword)
                {
                    throw new ArgumentException("Password can't be empty!");
                }

                userManager.SetNewPasswordForCurrentUser(newPassword);
                MessageBox.Show("Password saved!");
                if (userManager.isCurrentUserAdmin())
                {
                    AdminForm admin = new AdminForm(userManager);
                    admin.Show();
                    this.Hide();
                }
            } 
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
