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
    public partial class MoreInfoRule : Form
    {
        public MoreInfoRule(EventManager eventManager, Rule rule)
        {
            InitializeComponent();
            lblCreatedAt.Text = rule.CreatedAt.ToString();
            lblUpdatedAt.Text = rule.UpdatedAt.ToString();
            User user = eventManager.GetCreatorOfRule(rule);
            lblCreatedBy.Text = user.FirstName + " " + user.LastName;
        }
    }
}
