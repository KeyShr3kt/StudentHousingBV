using StudentHousingBV.forms.components;
using StudentHousingBV.models;
using System.Drawing.Text;

namespace StudentHousingBV.forms
{
    public partial class StudentPanel : Form
    {
        private StudentHousingBV.models.Task _testTask;
        private StudentHousingBV.models.Rule _testRule;
        public StudentPanel()
        {
            InitializeComponent();
            #region tests
            listClosedAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            listOpenAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            _testTask = new StudentHousingBV.models.Task(1, "bla", DateTime.Now, 2, false, false);
            for (int i = 1; i <= 10; i++)
                flowTasks.Controls.Add(new TaskComponent(_testTask));
            _testRule = new StudentHousingBV.models.Rule(1, "bla", DateTime.Now, 2, DateTime.Now);
            for (int i = 1; i <= 10; i++)
                flowRules.Controls.Add(new RuleComponent(_testRule));
            #endregion
        }
    }
}