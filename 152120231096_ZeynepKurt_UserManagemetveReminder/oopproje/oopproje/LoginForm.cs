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
                MessageBox.Show("Giri� ba�ar�l�.");
                ReminderForm reminderForm = new ReminderForm(user);
                reminderForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giri� ba�ar�s�z. Bilgileri kontrol edin.");
            }
        }
    }
}
