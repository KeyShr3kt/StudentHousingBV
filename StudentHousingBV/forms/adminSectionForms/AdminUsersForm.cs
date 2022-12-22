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
        public UserManager userManager { get => _userManager; private set { _userManager = value; } }

        private BuildingManager _buildingManager;
        public BuildingManager buildingManager { get => _buildingManager; }

        public AdminUsersForm(UserManager manager)
        {
            InitializeComponent();
            _userManager = manager;
            _buildingManager = new BuildingManager(manager.CurrentUserId);
            fillUsers(new List<User>());
            fillBuildings();
        }

        void fillBuildings()
        {
            cmbBoxBuildings.Items.Clear();
            buildingManager.GetAllBuildings().ForEach(building => { cmbBoxBuildings.Items.Add(building); });

        }
        public void fillUsers(List<User> usersToFill)
        {
            flowLayoutPanel1.Controls.Clear();

            List<User> users;
            if (usersToFill.Count == 0)
            {
                users = userManager.GetAllUsers();
            } 
            else
            {
                users = new List<User>(usersToFill);
            }


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
            AdminCreateUserForm form = new AdminCreateUserForm(userManager, buildingManager);
            form.Show();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text.Length > 0)
            {
                if (flowLayoutPanel1.Controls.Count == 0)
                {
                    fillUsers(new List<User>());
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
                fillUsers(new List<User>());
            }
        }

        private void AdminUsersForm_Load(object sender, EventArgs e)
        {
            fillUsers(new List<User>());
            fillBuildings();
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            Building? building = cmbBoxBuildings.SelectedItem as Building;
            bool isAdmin = checkBoxIsAdmin.Checked;

           
            if (isAdmin)
            {
                if (building != null)
                    fillUsers(userManager.GetAdminsInBuilding(building));
                else
                    fillUsers(userManager.GetAllAdmins());
            }
            else
            {
                if (building != null)
                    fillUsers(userManager.GetAllUsersInBuilding(building));
                else
                    fillUsers(userManager.GetAllUsers());
            } 
       
            
        }

        private void btnDisableFilters_Click(object sender, EventArgs e)
        {
            cmbBoxBuildings.SelectedItem = null;
            checkBoxIsAdmin.Checked = false;

            fillUsers(new List<User>());
        }

        private void btnSortByUpvotes_Click(object sender, EventArgs e)
        {
            List<AdminUserComponent> components = new();
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                components.Add((AdminUserComponent)c);
            }
            List<AdminUserComponent> sortedComponents = components.OrderByDescending(c => c.User.PositiveVotes).ToList();
            flowLayoutPanel1.Controls.Clear();
            foreach (AdminUserComponent c in sortedComponents)
            {
                flowLayoutPanel1.Controls.Add(c);
            }

        }

        private void btnSortByDownvotes_Click(object sender, EventArgs e)
        {
            List<AdminUserComponent> components = new();
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                components.Add((AdminUserComponent)c);
            }
            List<AdminUserComponent> sortedComponents = components.OrderByDescending(c => c.User.NegativeVotes).ToList();
            flowLayoutPanel1.Controls.Clear();
            foreach (AdminUserComponent c in sortedComponents)
            {
                flowLayoutPanel1.Controls.Add(c);
            }
        }
    }
}
