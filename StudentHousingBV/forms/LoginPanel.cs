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

        public LoginPanel()
        {
            InitializeComponent();
            txtBoxEmail.Text = "admin";
            txtBoxPassword.Text = "admin";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtBoxEmail.Text.Trim();
                string password = txtBoxPassword.Text.Trim();

                User? foundUser = UserManager.VirifyUserWithEmailAndPassword(email, password);
                if (foundUser != null)
                {
                    if (foundUser.LastSeenAt == null)
                    {
                        ChangePasswordForm form = new ChangePasswordForm(foundUser.Id);
                        form.Show();
                        this.Hide();
                    }
                    else if (foundUser.isAdmin)
                    {
                        AdminForm adminForm = new AdminForm(foundUser.Id);
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        StudentPanel form = new StudentPanel();
                        form.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("User not found!");
                    this.txtBoxPassword.Text = "";
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

    }
}
