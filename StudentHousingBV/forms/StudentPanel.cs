using StudentHousingBV.forms.components;
using StudentHousingBV.models;

namespace StudentHousingBV.forms
{
    public partial class StudentPanel : Form
    {
        DateTime date = DateTime.Now;
        public StudentPanel()
        {
            InitializeComponent();
            listClosedAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            listOpenAgreements.Items.Add("#ID | {user}: {title} - Upvotes: {number} / Downvotes: {number}");
            flowTasks.Controls.Add(new TaskComponent(1, "bla", date, 2, false, false));
        }
    }
}