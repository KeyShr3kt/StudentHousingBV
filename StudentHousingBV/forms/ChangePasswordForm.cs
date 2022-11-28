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
        private int _userId;
        private Database _db;
        public ChangePasswordForm(int userId, Database db)
        {
            InitializeComponent();
            this._userId = userId;
            this._db = db;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newPassword = this.txtBoxNewPassword.Text.Trim();
            string confirmPassword = this.txtBoxConfirmPassword.Text.Trim();
            if (newPassword == "" || confirmPassword == "" || newPassword.Length < 8 || confirmPassword.Length < 8) 
            { 
                MessageBox.Show("The password must contain at least 8 characters."); 
                return; 
            }

            if (newPassword != confirmPassword) 
            { 
                MessageBox.Show("The passwords are not the same!");
                return; 
            }

            UserManager.ChangePasswordForUserWith(_userId, newPassword, _db);
            UserManager.UpdateLastSeenAtForUserId(_userId, _db);
            // redirect the user to the user form 
            //Form1 form = new Form1(); // pass current user to the form?????/
            LoginPanel form = new LoginPanel(_db);
            form.Show();
            this.Hide();
        }
    }
}
