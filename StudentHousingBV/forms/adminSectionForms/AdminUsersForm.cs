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

namespace StudentHousingBV.forms.adminSectionForms
{
    public partial class AdminUsersForm : Form
    {
        private UserManager _userManager;
        public UserManager UserManager { get => _userManager; private set { _userManager = value; } }
        public AdminUsersForm(UserManager manager)
        {
            InitializeComponent();
            UserManager = manager;
            fillUsers();
        }

        public void fillUsers()
        {
            flowLayoutPanel1.Controls.Clear();
            List<User> users = UserManager.GetAllUsers();
            List<AdminUserComponent> components = new List<AdminUserComponent>();
            foreach (User user in users)
            {
                components.Add(new AdminUserComponent(user));
            }
            foreach (AdminUserComponent auc in components)
            {
                flowLayoutPanel1.Controls.Add(auc);
            }
            
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            AdminCreateUserForm form = new AdminCreateUserForm();
            form.Show();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text.Length > 0)
            {
                if (flowLayoutPanel1.Controls.Count == 0)
                {
                    fillUsers();
                }
                
                List<AdminUserComponent> testcomponents = new List<AdminUserComponent>();
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    if (c.GetType() == typeof(AdminUserComponent))
                    {
                        AdminUserComponent auc = (AdminUserComponent)c;
                        if (!auc.User.FirstName.ToLower().Contains(txtBoxSearch.Text.Trim().ToLower()) &&
                            !auc.User.LastName.ToLower().Contains(txtBoxSearch.Text.Trim().ToLower()) &&
                            !auc.User.EmailAddress.ToLower().Contains(txtBoxSearch.Text.Trim().ToLower()))
                        {
                            //flowLayoutPanel1.Controls.Remove(auc);
                            testcomponents.Add(auc);
                        }
                    }
                }
                foreach (AdminUserComponent c in testcomponents)
                {
                    flowLayoutPanel1.Controls.Remove(c);
                }
            } 
            else
            {
                flowLayoutPanel1.Controls.Clear();
                fillUsers();
            }
        }

        private void AdminUsersForm_Load(object sender, EventArgs e)
        {
            fillUsers();
        }
    }
}
