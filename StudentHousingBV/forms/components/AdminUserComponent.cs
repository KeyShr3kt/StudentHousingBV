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
            lblPossitiveVotes.Text = _user.PossitiveVotes.ToString();
            lblNegativeVotes.Text = _user.NegativeVotes.ToString();
            lblStrikes.Text = _user.Strikes.ToString();
            lblisAdmin.Text = _user.isAdmin.ToString();
            lblLastSeenAt.Text = _user.LastSeenAt.ToString();
        }
        #region Properties
        private User _user;
        [Category("Custom Props")]
        public User User { get => _user; set => _user = value; }
        #endregion


        private void AdminUserComponent_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void AdminUserComponent_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor= Color.White;
        }
    }
}
