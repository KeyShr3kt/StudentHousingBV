using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.forms
{
    public partial class ReportForm : Form
    {
        private StudentHousingBV.models.Task _reportedTask;
        private StudentHousingBV.models.Rule _reportedRule;
        public ReportForm(StudentHousingBV.models.Task reportedTask)
        {
            InitializeComponent();
            this._reportedTask = reportedTask;
            this.lbReportedEvent.Text = $"Reported task: #{this._reportedTask.Id} {this._reportedTask.Description}";
        }

        public ReportForm(StudentHousingBV.models.Rule reportedRule)
        {
            InitializeComponent();
            this._reportedRule = reportedRule;
            this.lbReportedEvent.Text = $"Reported rule: #{this._reportedRule.Id} {this._reportedRule.Description}";
        }
    }
}
