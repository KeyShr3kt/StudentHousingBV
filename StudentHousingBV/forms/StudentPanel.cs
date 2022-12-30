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
            /*
            #region Tests
            StudentHousingBV.models.Task _testTask1, _testTask2;
            StudentHousingBV.models.Rule _testRule;
            StudentHousingBV.models.User _testUser = new User(1,"Ionut", "Dragomir", "510175@student.fontys.nl", "smthsmthsmth", "+31633396888", 0, 0, false, DateTime.Now, "IBAN");
            listClosedAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            listOpenAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            _testTask1 = new StudentHousingBV.models.Task(1, "This is a task title.", "This is a task description.", DateTime.Now, _testUser.Id, 1, 2, false, false);
            _testTask2 = new StudentHousingBV.models.Task(1, "This is a task title.", "This is a task description.", DateTime.Now, _testUser.Id, 1, 2, true, false);
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                    fpPageTasks.Controls.Add(new TaskComponent(_testTask1, 1));
                else
                    fpPageTasks.Controls.Add(new TaskComponent(_testTask2, 1));
            }
            _testRule = new StudentHousingBV.models.Rule(1, "This is a rule title.", "This is a rule description.", DateTime.Now, _testUser.Id, 1, DateTime.Now);
            for (int i = 1; i <= 10; i++)
                flowRules.Controls.Add(new RuleComponent(_testRule));
            #endregion
            */

        }
    }
}