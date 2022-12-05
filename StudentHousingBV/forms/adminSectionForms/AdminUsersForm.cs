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
    public partial class AdminUsersForm : Form
    {
        public AdminUsersForm()
        {
            InitializeComponent();
            fillUsers();
        }

        public void fillUsers()
        {
            
            User user1 = new User(1, "ivan", "ivan", "ivan", "ivan", "ivan", true);
            AdminUserComponent component1 = new AdminUserComponent(user1);

            User user2 = new User(1, "ivan1", "ivan1", "ivan1", "ivan1", "ivan1", true);
            AdminUserComponent component2 = new AdminUserComponent(user2);

            AdminUserComponent component3 = new AdminUserComponent(user1);
            AdminUserComponent component4 = new AdminUserComponent(user1);
            AdminUserComponent component5 = new AdminUserComponent(user1);
            AdminUserComponent component6 = new AdminUserComponent(user1);

            List<AdminUserComponent> components = new List<AdminUserComponent> { component1, component2, component3, component4, component5, component6 };
            foreach (AdminUserComponent auc in components)
            {
                flowLayoutPanel1.Controls.Add(auc);
            }
            
        }
    }
}
