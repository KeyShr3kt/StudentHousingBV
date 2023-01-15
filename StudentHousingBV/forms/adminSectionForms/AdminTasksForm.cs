using StudentHousingBV.controllers;
using StudentHousingBV.forms.components;
using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentHousingBV.forms.adminSectionForms
{
    public partial class AdminTasksForm : Form
    {
        private EventManager _eventManager;
        private BuildingManager _buildingManager;

        public EventManager eventManager { get => _eventManager; }

        public BuildingManager buildingManager { get => _buildingManager; }

        public AdminTasksForm(int id)
        {
            InitializeComponent();
            _eventManager = new EventManager(id);
            _buildingManager = new BuildingManager(id);
            fillBuildings();
            fillTasks(new());
        }

        void fillBuildings()
        {
            cmbBoxBuildings.Items.Clear();
            buildingManager.GetAllBuildings().ForEach(building => { cmbBoxBuildings.Items.Add(building); });
        }

        void fillTasks(List<models.Task> tasksToFill)
        {
            flowLayoutPanel1.Controls.Clear();
            List<models.Task> tasks;
            if (tasksToFill.Count == 0)
            {
                tasks = eventManager.GetAllTasks();
            }
            else
            {
                tasks = new List<models.Task>(tasksToFill);
            }
            List<AdminTaskComponent> components = new ();
            foreach (models.Task task in tasks)
            {
                components.Add(new AdminTaskComponent(task, eventManager));
            }
            foreach (AdminTaskComponent atc in components)
            {
                flowLayoutPanel1.Controls.Add(atc);
            }
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            AdminCreateTaskForm form = new AdminCreateTaskForm(buildingManager, eventManager);
            form.Show();
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            List<models.Task> tasks;
            Building? building = (Building)cmbBoxBuildings.SelectedItem;
            int? buildingId = null;
            if (building != null)
            {
                buildingId = building.Id;
            }
            if (rdBtnCompleted.Checked)
            {
                tasks = eventManager.GetAllTasksInBuildingIdWithStatusCompleted(buildingId);
            }
            else if (rdBtnForReview.Checked)
            {
                tasks = eventManager.GetAllTasksInBuildingIdWithTotalPriceAndNotCompleted(buildingId);
            }
            else
            {
                tasks = eventManager.GetAllTasksInBuildingId(buildingId);
            }
            if (tasks.Count == 0)
            {
                MessageBox.Show("There are no active tasks in this category.");
            }
            fillTasks(tasks);
        }

        private void btnDisableFilters_Click(object sender, EventArgs e)
        {
            cmbBoxBuildings.SelectedItem = null;
            rdBtnCompleted.Checked = false;
            rdBtnForReview.Checked = false;
            fillTasks(new());
        }
    }
}
