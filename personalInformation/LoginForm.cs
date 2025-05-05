using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace personalInformation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosing += LoginForm_FormClosing;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string path = "profiles.csv";
            if (!File.Exists(path))
            {
                MessageBox.Show("profiles.csv dosyası bulunamadı.");
                return;
            }

            string username = txtLoginUsername.Text.Trim().ToLower();
            string password = txtLoginPassword.Text.Trim();
            bool loginSuccess = false; // <-- Buraya dikkat!

            var lines = File.ReadAllLines(path).Skip(1); // başlık atla

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 7)
                {
                    string csvUsername = parts[0].ToLower();
                    string csvPassword = parts[6];

                    if (csvUsername == username && csvPassword == password)
                    {
                        Session.currentUsername = username;
                        loginSuccess = true;
                        break;
                    }
                }
            }

            if (loginSuccess)
            {
                MessageBox.Show("Giriş başarılı!");
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }
    


    private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Kapatmayı iptal eder
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    } }
