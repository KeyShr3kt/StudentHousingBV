using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.forms.components
{
    public partial class AdminRuleComponent : UserControl
    {
        public AdminRuleComponent()
        {
            InitializeComponent();
            lblRuleDescription.Text = "Description of the rule Description of the rule Description of the rule Description of the rule Description of the rule Description of the rule Description of the rule Description of the rule Description of the rule Description of the ruleDescription of the rule Description of the rule Description of the rule Description of the rule";
            lblCreatedBy.Text = "admin";
            lblForBuilding.Text = "building 1";
            lblUpdatedAt.Text = "updated at NOW";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
