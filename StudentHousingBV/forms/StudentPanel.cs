using StudentHousingBV.forms.components;
using StudentHousingBV.models;
using System.Drawing.Text;

namespace StudentHousingBV.forms
{
    public partial class StudentPanel : Form
    {
        private StudentHousingBV.models.Task _testTask;
        public StudentPanel()
        {
            InitializeComponent();
            #region tests
            listClosedAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            listOpenAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            _testTask = new StudentHousingBV.models.Task(1, "bla", DateTime.Now, 2, false, false);
            flowTasks.Controls.Add(new TaskComponent(_testTask));
            for (int i = 1; i <= 10; i++)
                flowTasks.Controls.Add(new TaskComponent(_testTask));
            #endregion
        }
    }
}