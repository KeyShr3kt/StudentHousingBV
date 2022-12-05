using StudentHousingBV.forms.components;
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
    public partial class AdminRulesForm : Form
    {
        public AdminRulesForm()
        {
            InitializeComponent();

            AdminRuleComponent component1 = new AdminRuleComponent();
            AdminRuleComponent component2 = new AdminRuleComponent();

            AdminRuleComponent component3 = new AdminRuleComponent();
            AdminRuleComponent component4 = new AdminRuleComponent();
            AdminRuleComponent component5 = new AdminRuleComponent();
            AdminRuleComponent component6 = new AdminRuleComponent();
            AdminRuleComponent component7 = new AdminRuleComponent();
            AdminRuleComponent component8 = new AdminRuleComponent();

            List<AdminRuleComponent> components = new List<AdminRuleComponent> { component1, component2, component3, component4, component5, component6, component7, component8 };
            foreach (AdminRuleComponent auc in components)
            {
                flowLayoutPanel1.Controls.Add(auc);
            }
        }


    }
}
