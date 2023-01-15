using StudentHousingBV.controllers;
using StudentHousingBV.forms.adminSectionForms;
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

namespace StudentHousingBV.forms.components
{
    public partial class AdminRuleComponent : UserControl
    {
        private Rule _rule;
        private EventManager _eventManager;

        public EventManager eventManager { get => _eventManager;}

        public AdminRuleComponent(Rule rule, EventManager manager)
        {
            InitializeComponent();
            _rule = rule;
            //lblRuleDescription.Text = rule.Description;
            lblTitle.Text = rule.Title;
            _eventManager = manager;
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            MoreInfoRule rule = new MoreInfoRule(_rule);
            rule.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AdminCreateRuleForm editRule = new AdminCreateRuleForm(eventManager, _rule);
            editRule.Show();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Color color = Color.FromArgb(220, 220, 220);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, color,
            ButtonBorderStyle.Solid);
            base.OnPaint(e);
        }
    }
}
