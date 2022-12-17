﻿using StudentHousingBV.controllers;
using StudentHousingBV.forms.components;
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
    public partial class AdminRulesForm : Form
    {
        // private RulesManager _rulesManager;
        // public RulesManager RulesManager { get => _rulesManager; private set {_rulesManager = value; } }
        private BuildingManager _buildingManager;
        public BuildingManager buildingManager { get => _buildingManager; }

        private EventManager _eventManager;
        public EventManager eventManager { get => _eventManager;}


        public AdminRulesForm(int userId)
        {
            InitializeComponent();
            _buildingManager = new BuildingManager(userId);
            _eventManager = new EventManager(userId);
            fillRules(new());
            fillBuildings();
        }
        void fillBuildings()
        {
            cmbBoxBuildings.Items.Clear();
            buildingManager.GetAllBuildings().ForEach(building => { cmbBoxBuildings.Items.Add(building); });
        }
        void fillRules(List<Rule> rulesToFill)
        {
            flowLayoutPanel1.Controls.Clear();

            List<Rule> rules;
            if (rulesToFill.Count == 0)
            {
                rules = eventManager.GetAllRules();
            }
            else
            {
                rules = new List<Rule>(rulesToFill);
            }


            List<AdminRuleComponent> components = new List<AdminRuleComponent>();
            foreach (Rule rule in rules)
            {
                components.Add(new AdminRuleComponent(rule, eventManager));
            }
            foreach (AdminRuleComponent arc in components)
            {
                flowLayoutPanel1.Controls.Add(arc);
            }
        }

        private void btnCreateRule_Click(object sender, EventArgs e)
        {
            AdminCreateRuleForm createForm = new AdminCreateRuleForm(eventManager, buildingManager);
            createForm.Show();
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            Building? building = (Building)cmbBoxBuildings.SelectedItem;
            List<Rule> rules;
            if (building != null)
                rules = eventManager.GetAllRulesInBuildingId(building.Id);
            else
                rules = eventManager.GetAllRules();
            fillRules(rules);
        }

        private void btnDisableFilters_Click(object sender, EventArgs e)
        {
            cmbBoxBuildings.SelectedItem = null;
            fillRules(new());
        }
    }
}
