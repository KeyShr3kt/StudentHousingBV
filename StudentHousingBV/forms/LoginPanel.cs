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
    public partial class LoginPanel : Form
    {

        private UserManager _userManager = new UserManager();
        StudentHousingBV.models.User _currentUser;
        public UserManager UserManager { get => _userManager; private set { _userManager = value; } }
        public LoginPanel(StudentHousingBV.models.User currentUser)
        {
            InitializeComponent();
            this._currentUser = currentUser;
            //this._db = db;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtBoxEmail.Text.Trim();
            string password = txtBoxPassword.Text.Trim();


            int? userId = UserManager.GetUserIdWith(email, password, _db);


            if (userId != null)
            {
                if (UserManager.isFirstTimeLoginForUserId((int)userId, _db))
                {
                    ChangePasswordForm form = new ChangePasswordForm((int)userId, this._db);
                    form.Show();
                    this.Hide();

                } else if (UserManager.IsUserWithIdAdmin((int)userId, this._db)) 
                { 
                    UserManager.UpdateLastSeenAtForUserId((int)userId, _db);
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                } else 
                {
                    StudentPanel form = new StudentPanel(_currentUser);
                    form.Show();
                    this.Hide();
                }
            } else
            {
                MessageBox.Show("User not found!");
                this.txtBoxPassword.Text = "";
            }
           
            
        }

       

    }
}
