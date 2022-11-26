using StudentHousingBV.models;

namespace StudentHousingBV
{
    public partial class Form1 : Form
    {
        public User user;
        public Form1()
        {
            InitializeComponent();
            user = new User(1, "Foo", "Foo2", "asd@abv.bg", "password", "0111", false);
            this.label1.Text = user.GetPassword() + " : " + SecurePassword.Verify("password", SecurePassword.Hash("password"));
        }

    }
}