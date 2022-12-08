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
            #region tests
            flowClosedAgreements.Controls.Add(new AgreementCard(new Agreement(1, "I'm an agreement", "Lorem ipsum dolor sit amet", date, 1, true)));
            flowClosedAgreements.Controls.Add(new AgreementCard(new Agreement(2, "Me too", "Dolor sit amet lorem ipsum", date, 1, true)));
            flowOpenAgreements.Controls.Add(new AgreementCard(new Agreement(3, "I'm an open agreement", "The quick brown fox jumps over the lazy dog", date, 1, false)));
            flowOpenAgreements.Controls.Add(new AgreementCard(new Agreement(4, "Open agreement as well", "Lorem ipsum dolor sit amet", date, 1, false)));
            flowTasks.Controls.Add(new TaskComponent(1, "bla", date, 2, false, false));
            #endregion
        }
    }
}