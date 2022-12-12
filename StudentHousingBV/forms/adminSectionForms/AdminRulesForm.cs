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
using System.Threading.Tasks;
using System.Windows.Forms;
using Rule = StudentHousingBV.models.Rule;

namespace StudentHousingBV.forms.adminSectionForms
{
    public partial class AdminRulesForm : Form
    {
        private RulesManager _rulesManager;
        public RulesManager RulesManager { get => _rulesManager; private set {_rulesManager = value; } }
        public AdminRulesForm(int userId)
        {
            RulesManager = new RulesManager(userId);
            InitializeComponent();
            List<Rule> rules = RulesManager.getAllRules();
            List<AdminRuleComponent> components = new List<AdminRuleComponent>();
            foreach(Rule rule in rules)
            {
                components.Add(new AdminRuleComponent(rule));
            }
            foreach (AdminRuleComponent auc in components)
            {
                flowLayoutPanel1.Controls.Add(auc);
            }
        }


    }
}
