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

namespace StudentHousingBV.forms.components
{
    public partial class AdminRuleComponent : UserControl
    {
        public AdminRuleComponent(Events rule)
        {
            InitializeComponent();
            lblRuleDescription.Text = rule.Description;
            lblCreatedBy.Text = "asds";
            lblForBuilding.Text = "das";
            lblUpdatedAt.Text = "asdas";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
