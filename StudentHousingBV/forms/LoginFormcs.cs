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
    public partial class LoginForm : Form
    {
        private Database _db = new Database();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtBoxEmail.Text.Trim();
            string password = txtBoxPassword.Text.Trim();


            User? foundUser = _db.getUserWithLogin(email, password);

            if (foundUser != null)
            {
                if (foundUser.GetLastSeenAt() == null)
                {
                    ChangePasswordForm form = new ChangePasswordForm(foundUser.GetId(), this._db);
                    form.Show();
                    this.Hide();

                } else if (foundUser.GetIsAdmin()) { MessageBox.Show("welcome! (show the admin form)"); }
                  else { MessageBox.Show("welcome! show user form!"); }
            } else
            {
                MessageBox.Show("User not found!");
                this.txtBoxPassword.Text = "";
            }
           
            
        }
    }
}
