using StudentHousingBV.forms.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.forms.adminSectionForms
{
    public partial class AdminTasksForm : Form
    {
        public AdminTasksForm()
        {
            InitializeComponent();
            AdminTaskComponent component1 = new AdminTaskComponent();
            AdminTaskComponent component2 = new AdminTaskComponent();

            AdminTaskComponent component3 = new AdminTaskComponent();
            AdminTaskComponent component4 = new AdminTaskComponent();
            AdminTaskComponent component5 = new AdminTaskComponent();
            AdminTaskComponent component6 = new AdminTaskComponent();
            AdminTaskComponent component7 = new AdminTaskComponent();
            AdminTaskComponent component8 = new AdminTaskComponent();

            List<AdminTaskComponent> components = new List<AdminTaskComponent> { component1, component2, component3, component4, component5, component6, component7, component8 };
            foreach (AdminTaskComponent auc in components)
            {
                flowLayoutPanel1.Controls.Add(auc);
            }
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            AdminCreateTaskForm form = new AdminCreateTaskForm();
            form.Show();
        }
    }
}
