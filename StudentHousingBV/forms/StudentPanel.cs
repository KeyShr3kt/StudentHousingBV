using StudentHousingBV.forms.components;
using StudentHousingBV.models;
using System.Drawing.Text;

namespace StudentHousingBV.forms
{
    public partial class StudentPanel : Form
    {
        public StudentPanel(StudentHousingBV.models.User currentUser)
        {
            InitializeComponent();
            #region Tests
            StudentHousingBV.models.Task _testTask1, _testTask2;
            StudentHousingBV.models.Rule _testRule;
            listClosedAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            listOpenAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            _testTask1 = new StudentHousingBV.models.Task(1, "This is a normal task title.", "This is a task description.", currentUser, DateTime.Now, false, false);
            _testTask2 = new StudentHousingBV.models.Task(2, "This is a shopping task title.", "This is a task description.", currentUser, DateTime.Now, true, false);
            fpPageTasks.Controls.Add(new TaskComponent(_testTask1, currentUser));
            fpPageTasks.Controls.Add(new TaskComponent(_testTask1, currentUser));
            fpPageTasks.Controls.Add(new TaskComponent(_testTask2, currentUser));
            _testRule = new StudentHousingBV.models.Rule(1, "This is a rule title.", "This is a rule description.", currentUser, DateTime.Now, DateTime.Now);
            flowRules.Controls.Add(new RuleComponent(_testRule));
            #endregion
        }
    }
}