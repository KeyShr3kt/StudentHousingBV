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
            this._rule = rule;
            InitializeComponent();
        }
    }
}
