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

namespace StudentHousingBV.forms
{
    public partial class AgreementDetailsForm : Form
    {
        private EventManager _eventManager;
        private Agreement _agreement;
        public AgreementDetailsForm(EventManager eventManager, Agreement agreement)
        {
            _eventManager = eventManager;
            _agreement = agreement;
            InitializeComponent();
            lblTitle.Text = _agreement.Title;
            User creator = eventManager.GetAgreementCreator(_agreement);
            lblCreator.Text = $"{creator.FirstName} {creator.LastName}";
            lblCreatedAt.Text = _agreement.CreatedAt.ToString("u").Replace("Z", "");
            lblStartsAt.Text = _agreement.StartDateTime.ToString("u").Replace("Z", "");
            lblEndsAt.Text = _agreement.EndDateTime.ToString("u").Replace("Z", "");
            int upvotes = eventManager.GetAgreementUpvotes(_agreement);
            int downvotes = eventManager.GetAgreementDownvotes(_agreement);
            lblUpvotes.Text = upvotes.ToString();
            lblDownvotes.Text = downvotes.ToString();
            lblAccepted.Text = _agreement.IsAccepted ? "Yes" : "No";
            txtDescription.Text = _agreement.Description;
        }
    }
}
