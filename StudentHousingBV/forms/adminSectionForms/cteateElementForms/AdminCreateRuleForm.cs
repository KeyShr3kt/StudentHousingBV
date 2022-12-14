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
using Rule = StudentHousingBV.models.Rule;

namespace StudentHousingBV.forms.adminSectionForms
{
    public partial class AdminCreateRuleForm : Form
    {
        private EventManager _eventManager;
        public EventManager eventManager { get => _eventManager; }

        private BuildingManager _buildingManager;

        public BuildingManager buildingManager { get => _buildingManager; }
        public AdminCreateRuleForm(EventManager manager, BuildingManager bManager)
        {
            InitializeComponent();
            lblHiddenRuleId.Hide();
            _eventManager = manager;
            _buildingManager = bManager;
            fillBuildings();
        }

        public AdminCreateRuleForm(EventManager manager, Rule rule)
        {
            InitializeComponent();
            _eventManager = manager;
            _buildingManager = new BuildingManager(manager.CurrentUserId);
            fillBuildings();
            lblTitleForm.Text = "Edit Rule";
            btnCreateRule.Text = "Edit";
            lblHiddenRuleId.Text = rule.Id.ToString();
            lblHiddenRuleId.Hide();
            txtBoxTitle.Text = rule.Title;
            txtBoxDescription.Text = rule.Description;
            cmbBoxBuildings.SelectedIndex = cmbBoxBuildings.FindStringExact((buildingManager.GetBuidingWithId(rule.Id)).ToString());
        }

        void fillBuildings()
        {
            cmbBoxBuildings.Items.Clear();
            buildingManager.GetAllBuildings().ForEach(building => { cmbBoxBuildings.Items.Add(building); });
        }

        private void btnCreateRule_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtBoxTitle.Text;
                string description = txtBoxDescription.Text;
                Building building = (Building)cmbBoxBuildings.SelectedItem;

                if (btnCreateRule.Text == "Edit")
                {
                    int ruleId = Int32.Parse(lblHiddenRuleId.Text);
                 //   MessageBox.Show(ruleId.ToString());

                    eventManager.UpdateRuleForBuilding(ruleId, title, description, building);
                }
                else
                {
                    eventManager.CreateRuleForBuilding(title, description, building);
                }
                this.Close();
            }
            catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
