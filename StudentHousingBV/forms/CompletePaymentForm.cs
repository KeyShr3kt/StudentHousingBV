using StudentHousingBV.controllers;
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
    public partial class CompletePaymentForm : Form
    {
        private StudentHousingBV.models.Task _task;
        private int _currUserId;
        private EventManager _eventManager;

        public CompletePaymentForm(StudentHousingBV.models.Task task, int currUserId)
        {
            InitializeComponent();
            _task = task;
            _currUserId = currUserId;
            _eventManager = new(_currUserId);
        }

        private void AddPictureLabel_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show("File uploaded successfully!");
            SendButton.Enabled = true;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(PriceTextBox.Text, out int price))
            {
                _eventManager.AddPriceToTask(_task.Id, price);
                MessageBox.Show("Task completed!");
            }
        }
    }
}
