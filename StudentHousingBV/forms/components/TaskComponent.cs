using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.forms.components
{
    public partial class TaskComponent : UserControl
    {
        private int id;
        private string description;
        private DateTime createdAt;
        private int buildingId;
        private bool _isShopping;
        private bool _isCompleted;

        public TaskComponent(int id, string description, DateTime createdAt, int buildingId, bool isShopping, bool isCompleted)
        {
            this.id = id;
            this.description = description;
            this.createdAt = createdAt;
            this.buildingId = buildingId;
            this._isCompleted = isCompleted;
            this._isShopping = isShopping;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.description;
        }
    }
}
