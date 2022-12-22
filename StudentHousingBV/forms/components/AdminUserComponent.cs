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
    public partial class AdminUserComponent : UserControl
    {


        public AdminUserComponent(User user)
        {
            InitializeComponent();
            
            _user = user;
            lblName.Text = _user.FirstName + " " + _user.LastName;
            lblEmail.Text = _user.EmailAddress;
            lblPhoneNumber.Text = _user.PhoneNumber;
            lblPossitiveVotes.Text = _user.PositiveVotes.ToString();
            lblNegativeVotes.Text = _user.NegativeVotes.ToString();
            lblIBAN.Text = _user.IBAN;
            if (_user.IsAdmin)
            {
                lblisAdmin.Text = "Admin";
            } else
            {
                lblisAdmin.Text = "Tenant";
            }
             
            lblLastSeenAt.Text = _user.LastSeenAt.ToString();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Color color = Color.FromArgb(220, 220, 220);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, color,
            ButtonBorderStyle.Solid);
            base.OnPaint(e);
        }
        #region Properties
        private User _user;
        [Category("Custom Props")]
        public User User { get => _user; set => _user = value; }
        #endregion

    }
}
