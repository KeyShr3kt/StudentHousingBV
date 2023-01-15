using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;
using StudentHousingBV.controllers;
using StudentHousingBV.models;

namespace StudentHousingBV.forms
{
    public partial class AdminCreateUserForm : Form
    {
        private UserManager _userManager;
        private BuildingManager _buildingManager;

        public UserManager userManager { get => _userManager; }

        public BuildingManager buildingManager { get => _buildingManager; }

        public AdminCreateUserForm(UserManager manager, BuildingManager bManager)
        {
            InitializeComponent();
            _userManager = manager;
            _buildingManager = bManager;
            fillBuildings();
        }

        void fillBuildings()
        {
            cmbBoxBuildings.Items.Clear();
            foreach (Building building in buildingManager.GetAllBuildings())
            {
                cmbBoxBuildings.Items.Add(building);
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtBoxFirstName.Text;
                string lastName = txtBoxLastName.Text;
                string email = txtBoxEmail.Text;
                string phoneNumber = txtBoxPhoneNumber.Text;
                bool isAdmin = checkBoxIfAdmin.Checked;
                string IBAN = txtBoxIBAN.Text;
                userManager.CreateUser(firstName, lastName, email, phoneNumber, isAdmin, IBAN, cmbBoxRooms.SelectedItem as Room);
                this.Close();
            } 
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBoxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxRooms.Items.Clear();
            if (cmbBoxBuildings.SelectedIndex > -1)
            {
                Building building = (Building) cmbBoxBuildings.SelectedItem;
                List<Room> availableBedrooms = buildingManager.GetAvailableBedroomsForBuilding(building);
                foreach (Room room in availableBedrooms) 
                {
                    cmbBoxRooms.Items.Add(room);
                }
            }
        }
    }
}
