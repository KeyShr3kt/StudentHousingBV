using StudentHousingBV.controllers;
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

namespace StudentHousingBV.forms.adminSectionForms
{
    public partial class AdminReportedEventPreview : Form
    {
        public AdminReportedEventPreview(int eventId, EventManager manager)
        {
            InitializeComponent();

            Event e = manager.GetEvent(eventId);
            lblTitle.Text = "Title: " + e.Title;
            lblDescription.Text = "Description: " + e.Description;
            lblCreatedAt.Text = "Created at: " + e.CreatedAt.ToString();
            UserManager userManager = new UserManager(manager.CurrentUserId);
            User user = userManager.GetUser(e.CreatorId);
            lblCreator.Text = "Created by: " + user.FirstName + " " + user.LastName + " " + user.EmailAddress;
            BuildingManager bManager = new BuildingManager(manager.CurrentUserId);
            Building b = bManager.GetBuidingWithId(e.BuildingId);
            lblBuilding.Text = "Building: " + b.Address;
            Type type = e.GetType();

            if (e.GetType() == typeof(Agreement))
            {
                Agreement a = (Agreement) e;
                lblStartDate.Text = "Start date: " + a.StartDateTime.ToString(); 
                lblEndDate.Text = "End date: " + a.EndDateTime.ToString();
                lblIsAccepted.Text = "Is accepted: " + a.IsAccepted.ToString();

            } else if (e.GetType() == typeof(models.Task))
            {
                models.Task t = (models.Task) e;
                lblIsShopping.Text = "Does it include payment: " + t.IsShopping.ToString();
                lblIsCompleted.Text = "Is it fully completed: " + t.IsCompleted.ToString();
            }
        }
    }
}
