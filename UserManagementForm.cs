using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using _152120231068_ErenTerakye_Group11_LabA;

namespace userManagement
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Event bağlantıları
            this.Load += UserManagementForm_Load;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            btnChangeType.Click += btnChangeType_Click;
            btnSendEmail.Click += btnSendEmail_Click;
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsers();

            // Kullanıcı tipi seçenekleri
            cmbUserType.Items.Add("admin");
            cmbUserType.Items.Add("user");
            cmbUserType.Items.Add("part-time-user");
        }

        private void LoadUsers()
        {
            string path = "users.csv";
            if (!File.Exists(path))
            {
                MessageBox.Show("users.csv bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvUsers.Rows.Clear();
            dgvUsers.Columns.Clear();

            dgvUsers.Columns.Add("Username", "Kullanıcı Adı");
            dgvUsers.Columns.Add("Password", "Şifre");
            dgvUsers.Columns.Add("Email", "E-Posta");
            dgvUsers.Columns.Add("UserType", "Kullanıcı Tipi");

            var lines = File.ReadAllLines(path);
            bool skipHeader = true;

            foreach (var line in lines)
            {
                if (skipHeader) { skipHeader = false; continue; }

                var parts = line.Split(',');
                if (parts.Length >= 4)
                {
                    dgvUsers.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
                }
            }

            dgvUsers.ClearSelection();
            lblSelectedUser.Text = "Seçilen Kullanıcı: -";
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                string selectedUsername = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
                lblSelectedUser.Text = "Seçilen Kullanıcı: " + selectedUsername;
            }
        }

        private void btnChangeType_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
                return;
            }

            string selectedUsername = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
            string newType = cmbUserType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(newType))
            {
                MessageBox.Show("Lütfen bir kullanıcı tipi seçin.");
                return;
            }

            string path = "users.csv";
            var lines = File.ReadAllLines(path);
            var updatedLines = new List<string>();

            updatedLines.Add(lines[0]); // Başlık

            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts[0] == selectedUsername)
                {
                    parts[3] = newType;
                    updatedLines.Add(string.Join(",", parts));
                }
                else
                {
                    updatedLines.Add(lines[i]);
                }
            }

            File.WriteAllLines(path, updatedLines);
            MessageBox.Show("Kullanıcı tipi başarıyla güncellendi!");

            LoadUsers(); // tabloyu yenile
        }

        private async void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
                return;
            }

            string newPassword = txtNewPassword.Text.Trim();
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Lütfen bir şifre girin.");
                return;
            }

            string selectedUsername = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
            string email = dgvUsers.SelectedRows[0].Cells[2].Value.ToString();

            // ProgressBar başlat
            progressBarMail.Value = 0;
            for (int i = 0; i <= 100; i += 10)
            {
                await Task.Delay(50); // animasyon gibi görünmesi için
                progressBarMail.Value = i;
            }

            // Şifreyi users.csv içinde güncelle
            string path = "users.csv";
            var lines = File.ReadAllLines(path);
            var updatedLines = new List<string>();
            updatedLines.Add(lines[0]); // başlık

            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts[0] == selectedUsername)
                {
                    parts[1] = newPassword; // şifreyi güncelle
                    updatedLines.Add(string.Join(",", parts));
                }
                else
                {
                    updatedLines.Add(lines[i]);
                }
            }

            File.WriteAllLines(path, updatedLines);

            // ✅ GERÇEK E-POSTA GÖNDERME
            try
            {
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("nzl2606ylmz@gmail.com", "wvdz pbog qdqj yvcf"); // 👈 burayı değiştir

                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.From = new System.Net.Mail.MailAddress("seningmailadresin@gmail.com");
                mail.To.Add(email); // seçilen kişinin e-posta adresi
                mail.Subject = "Yeni Şifreniz";
                mail.Body = $"Merhaba {selectedUsername},\nYeni şifreniz: {newPassword}";

                await smtp.SendMailAsync(mail);

                MessageBox.Show($"{selectedUsername} kullanıcısına yeni şifre e-posta ile gönderildi!", "Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderilemedi!\nHata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Temizlik
            txtNewPassword.Clear();
            progressBarMail.Value = 0;
            LoadUsers(); // tabloyu güncelle
        }

        private void buttonPhoneBook_Click(object sender, EventArgs e)
        {
            PhoneBook f2 = new PhoneBook();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Notes f3 = new Notes();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalaryCalculator_Click(object sender, EventArgs e)
        {
            SalaryCalculator f4 = new SalaryCalculator();
            f4.ShowDialog();
        }
    }
}
