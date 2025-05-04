using System;
using System.Windows.Forms;

namespace oopproje
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Id = UserService.GetAllUsers().Count + 1,
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            UserService.AddUser(user);
            MessageBox.Show("Kayýt baþarýlý.");
        }
    }
}
