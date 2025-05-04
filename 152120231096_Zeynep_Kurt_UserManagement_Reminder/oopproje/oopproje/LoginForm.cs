using System;
using System.Windows.Forms;

namespace oopproje
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = UserService.GetUserByEmailAndPassword(txtEmail.Text, txtPassword.Text);
            if (user != null)
            {
                MessageBox.Show("Giriþ baþarýlý.");
                ReminderForm reminderForm = new ReminderForm(user);
                reminderForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriþ baþarýsýz. Bilgileri kontrol edin.");
            }
        }
    }
}
