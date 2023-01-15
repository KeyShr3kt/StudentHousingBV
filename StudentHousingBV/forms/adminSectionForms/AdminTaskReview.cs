using StudentHousingBV.controllers;
using StudentHousingBV.forms.components;
using StudentHousingBV.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentHousingBV.forms.adminSectionForms
{
    public partial class AdminTaskReview : Form
    {
        private models.Task _task;
        public UserManager userManager { get; }
        public EventManager eventManager { get; }
        public AdminTaskReview(models.Task task, int currUserId)
        {
            InitializeComponent();
            userManager = new UserManager(currUserId);
            eventManager = new EventManager(currUserId);
            _task = task;
            lblTitle.Text = task.Title;
            lblDescription.Text = task.Description;
            lblTotalPrice.Text = PriceToEuro(task.TotalPrice);
            User user = userManager.GetUser(task.CreatorId);
            lblIBAN.Text = user.IBAN;

            int count = userManager.CountUsersInBuildingId(task.BuildingId);
            if (task.TotalPrice != 0)
            {
                if (count == 0)
                {
                    lblToPayBack.Text = "Only one person in this building.\nNothing to return.\n";
                }
                else
                {
                    int payBack = (((int)(task.TotalPrice)) / count) * (count - 1);
                    lblToPayBack.Text = PriceToEuro(payBack);
                }
            }
         }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            eventManager.MarkTaskIdAsComplete(_task.Id);
            
            this.Close();
        }
        public string PriceToEuro(int? price)
        {
            return String.Format("€ {0:0.00}", price / 100m);
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.Show();
        }
    }
}
