using StudentHousingBV.models;

namespace StudentHousingBV.forms
{
    public partial class StudentPanel : Form
    {
        public StudentPanel()
        {
            InitializeComponent();
            listClosedAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            listOpenAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            listTasks.Items.Add("#ID | {task_description}: {student_name} / Status: Finished");
            listTasks.Items.Add("#ID | {task_description}: {student_name} / Status: Unfinished");
        }
    }
}