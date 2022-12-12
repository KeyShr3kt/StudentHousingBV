using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.forms
{
    public partial class TaskForm : Form
    {
        private StudentHousingBV.models.Task _task;
        public TaskForm(StudentHousingBV.models.Task task)
        {
            InitializeComponent();
            this._task = task;
            this.Text = $"Student Housing BV - Task #{this._task.Id}";
        }
    }
}
