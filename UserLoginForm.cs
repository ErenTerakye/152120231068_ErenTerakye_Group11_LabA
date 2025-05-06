using System;
using System.IO;
using System.Windows.Forms;
using userManagement;


namespace userManagement
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtLoginPassword.UseSystemPasswordChar = true;
        }

        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            string filePath = "users.csv";
            string inputUsername = txtLoginUsername.Text.Trim();
            string inputPassword = txtLoginPassword.Text.Trim();

            bool loginSuccess = false;
            string userType = "";
            string email = "";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("users.csv bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                bool skipHeader = true;

                while ((line = sr.ReadLine()) != null)
                {
                    if (skipHeader) { skipHeader = false; continue; }

                    string[] parts = line.Split(',');
                    if (parts.Length < 4) continue;

                    string username = parts[0];
                    string password = parts[1];
                    email = parts[2];
                    userType = parts[3];

                    if (username == inputUsername && password == inputPassword)
                    {
                        loginSuccess = true;
                        break;
                    }
                }
            }

            if (loginSuccess)
            {
                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (userType.ToLower() == "admin")
                {
                    UserManagementForm adminForm = new UserManagementForm();
                    adminForm.Show();
                }
                else
                {
                    UserProfileForm profileForm = new UserProfileForm(inputUsername, email, userType);
                    profileForm.Show();
                }

                this.Hide(); // Giriş ekranını kapat
            }

        }

        private void chkLoginShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtLoginPassword.UseSystemPasswordChar = !chkLoginShowPassword.Checked;
        }

        private void UserLoginForm_Click(object sender, EventArgs e)
        {
            // Şu anda bir iş yapmasına gerek yok
        }

    }
}
