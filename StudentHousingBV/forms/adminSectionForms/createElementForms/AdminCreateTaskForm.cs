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
    public partial class AdminCreateTaskForm : Form
    {
        private EventManager _eventManager;
        private BuildingManager _buildingManager;

        public EventManager eventManager { get => _eventManager; }

        public BuildingManager buildingManager { get => _buildingManager; }

        public AdminCreateTaskForm(BuildingManager bManager, EventManager eManager)
        {
            InitializeComponent();
            _eventManager = eManager;
            _buildingManager = bManager;
            fillBuildings();
        }

        void fillBuildings()
        {
            cmbBoxBuildings.Items.Clear();
            buildingManager.GetAllBuildings().ForEach(building => { cmbBoxBuildings.Items.Add(building); });
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtBoxTitle.Text;
                string description = txtBoxDescription.Text;
                bool includesPayment = rdBtnPaymentYes.Checked ? true : false;
                Building building = (Building)cmbBoxBuildings.SelectedItem;
                if (!rdBtnPaymentYes.Checked && !rdBtnPaymentNo.Checked)
                {
                    throw new ArgumentException("You should choose if the task includes payment");
                }
                eventManager.CreateTaskForBuilding(building, title, description, includesPayment);
                this.Close();

            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }  
    }
}
