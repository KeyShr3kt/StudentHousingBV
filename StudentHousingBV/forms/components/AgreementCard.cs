using StudentHousingBV.controllers;
using StudentHousingBV.models;

namespace StudentHousingBV.forms.components
{
    public partial class AgreementCard : UserControl
    {
        private Agreement _agreement;
        private EventManager _eventManager;
        private User _curUser;

        public AgreementCard(Agreement agreement, EventManager eventManager, User curUser)
        {
            _agreement = agreement;
            _eventManager = eventManager;
            _curUser = curUser;
            InitializeComponent();
            lblTitle.Text = _agreement.Title;
            // limit description to 240 characters without cutting words off
            int wordCount = _agreement.Description
                .Substring(0, Math.Min(240, _agreement.Description.Length))
                .Split(" ")
                .Length;
            string description = string.Join(" ", _agreement.Description.Split(" ").Take(wordCount - 1));
            lblDescription.Text = description;
            update();
        }

        private void update()
        {
            int upvotes = _eventManager.GetAgreementUpvotes(_agreement);
            int downvotes = _eventManager.GetAgreementDownvotes(_agreement);
            lblUpvote.Text = upvotes.ToString();
            lblDownvote.Text = downvotes.ToString();
            Reaction? userReaction = _eventManager.GetUserReactionOnAgreement(_agreement, _curUser);
            btnUpvote.ForeColor = userReaction switch
            {
                { IsPositive: true } => Color.ForestGreen,
                { IsPositive: false } => SystemColors.GrayText,
                _ => SystemColors.ControlText,
            };
            btnDownvote.ForeColor = userReaction switch
            {
                { IsPositive: true } => SystemColors.GrayText,
                { IsPositive: false } => Color.OrangeRed,
                _ => SystemColors.ControlText,
            };
            btnUpvote.Enabled = userReaction?.IsPositive != false;
            btnDownvote.Enabled = userReaction?.IsPositive != true;
            flowReactionControls.Visible = !_agreement.IsAccepted;
        }

        private void linkMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgreementDetailsForm f = new(_eventManager, _agreement);
            f.ShowDialog();
        }

        private void btnUpvote_Click(object sender, EventArgs e)
        {
            Reaction? userReaction = _eventManager.GetUserReactionOnAgreement(_agreement, _curUser);
            if (userReaction switch
            {
                { IsPositive: true } => _eventManager.DeleteAgreementReaction(_agreement, userReaction),
                { IsPositive: false } => false, // update not needed
                _ => _eventManager.UpvoteAgreement(_agreement),
            })
            {
                update();
            }
        }

        private void btnDownvote_Click(object sender, EventArgs e)
        {
            Reaction? userReaction = _eventManager.GetUserReactionOnAgreement(_agreement, _curUser);
            if (userReaction switch
            {
                { IsPositive: true } => false, // update not needed
                { IsPositive: false } => _eventManager.DeleteAgreementReaction(_agreement, userReaction),
                _ => _eventManager.DownvoteAgreement(_agreement),
            })
            {
                update();
            }
        }
    }
}
