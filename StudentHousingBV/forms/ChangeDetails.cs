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
    public partial class ChangeDetails : Form
    {
        private User _currentUser;
        private string _field;
        private UserManager _userManager;

        public ChangeDetails(User user, string field)
        {
            InitializeComponent();
            _currentUser = user;
            _field = field;
            _userManager = new UserManager(_currentUser.Id);
            updateField();
        }

        private void updateField()
        {
            if (_field == "Email")
            {
                tbNewValue.Text = _currentUser.EmailAddress;
            }
            else if (_field == "Phone")
            {
                tbNewValue.Text = _currentUser.PhoneNumber;
            }
        }

        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            if (tbNewValue.Text.Length > 0)
            {
                if (_field == "Email")
                {
                    if (UserManager.IsEmail(tbNewValue.Text))
                    {
                        _currentUser.EmailAddress = tbNewValue.Text;
                        _userManager.UpdateUser(_currentUser);
                        MessageBox.Show("User updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Error while updating user! \n" +
                            $"Email is not valid!");
                    }
                }
                else if (_field == "Phone")
                {
                    if (UserManager.IsPhoneNumber(tbNewValue.Text))
                    {
                        _currentUser.PhoneNumber = tbNewValue.Text;
                        _userManager.UpdateUser(_currentUser);
                        MessageBox.Show("User updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Error while updating user! \n" +
                            $"Phone number is not valid!");
                    }
                }
            }
        }
    }
}
