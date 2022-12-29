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
    public partial class RuleComponent : UserControl
    {
        private StudentHousingBV.models.Rule _rule;
        public RuleComponent(StudentHousingBV.models.Rule rule)
        {
            InitializeComponent();
            this._rule = rule;
            this.lbRuleId.Text = this._rule.Id.ToString();
            this.lbRuleTitle.Text = this._rule.Title;
        }

        private void btnReportTask_Click(object sender, EventArgs e)
        {
            StudentHousingBV.forms.ReportForm _reportForm = new StudentHousingBV.forms.ReportForm(this._rule);
            _reportForm.Show();
        }
    }
}
