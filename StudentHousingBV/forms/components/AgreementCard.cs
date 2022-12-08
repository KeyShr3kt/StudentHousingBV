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
    public partial class AgreementCard : UserControl
    {
        private Agreement _agreement;
        public AgreementCard(Agreement agreement)
        {
            _agreement = agreement;
            InitializeComponent();
            lblTitle.Text = _agreement.Title;
            // limit description to 240 characters without cutting words off
            int wordCount = _agreement.Description
                .Substring(0, Math.Min(240, _agreement.Description.Length))
                .Split(" ")
                .Length;
            string description = string.Join(" ", _agreement.Description.Split(" ").Take(wordCount - 1));
            lblDescription.Text = description;
            lblUpvote.Text = "6";
            lblDownvote.Text = "9";
        }

        private void linkMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: open an AgreementPanel or something
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            // TODO: open an AgreementPanel or something
        }
    }
}
