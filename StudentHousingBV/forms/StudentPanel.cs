using StudentHousingBV.forms.components;
using StudentHousingBV.models;
using System.Drawing.Text;

namespace StudentHousingBV.forms
{
    public partial class StudentPanel : Form
    {
        public StudentPanel()
        {
            InitializeComponent();
            #region Tests
            StudentHousingBV.models.Task _testTask1, _testTask2;
            StudentHousingBV.models.Rule _testRule;
            StudentHousingBV.models.User _testUser = new User(1,"Ionut", "Dragomir", "510175@student.fontys.nl", "smthsmthsmth", "+31633396888", false, DateTime.Now);
            listClosedAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            listOpenAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            _testTask1 = new StudentHousingBV.models.Task(1, "This is a task title.", "This is a task description.", _testUser, DateTime.Now, false, false);
            _testTask2 = new StudentHousingBV.models.Task(2, "This is a task title.", "This is a task description.", _testUser, DateTime.Now, true, false);
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                    fpPageTasks.Controls.Add(new TaskComponent(_testTask1));
                else
                    fpPageTasks.Controls.Add(new TaskComponent(_testTask2));
            }
            _testRule = new StudentHousingBV.models.Rule(1, "This is a rule title.", "This is a rule description.", _testUser, DateTime.Now, DateTime.Now);
            for (int i = 1; i <= 10; i++)
                flowRules.Controls.Add(new RuleComponent(_testRule));
            #endregion
        }
    }
}