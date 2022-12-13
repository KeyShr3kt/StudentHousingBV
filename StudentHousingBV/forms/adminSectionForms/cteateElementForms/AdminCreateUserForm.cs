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

        public UserManager userManager { get => _userManager; }
        public AdminCreateUserForm(UserManager manager)
        {
            InitializeComponent();
            _userManager = manager;
            fillBuildings();
        }

        void fillBuildings()
        {
            cmbBoxBuildings.Items.Clear();
            foreach (Building building in userManager.GetAllBuildings())
            {
                cmbBoxBuildings.Items.Add(building);
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string firstName = txtBoxFirstName.Text;
            string lastName = txtBoxLastName.Text;
            string email = txtBoxEmail.Text;
            string phoneNumber = txtBoxPhoneNumber.Text;


        }

        private void cmbBoxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxRooms.Items.Clear();
            if (cmbBoxBuildings.SelectedIndex > -1)
            {
                Building building = (Building) cmbBoxBuildings.SelectedItem;

                /*foreach (Room room in building.Rooms) 
                {
                    if (room.User == null)
                    {
                        cmbBoxRooms.Items.Add(room);
                    }
                }*/
            }
        }
    }
}
