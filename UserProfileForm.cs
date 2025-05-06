using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using _152120231068_ErenTerakye_Group11_LabA;

namespace userManagement
{
    public partial class UserProfileForm : Form
    {
        private string currentUsername;
        private string currentEmail;
        private string currentUserType;

        public UserProfileForm(string username, string email, string userType)
        {
            InitializeComponent();
            this.currentUsername = username;
            this.currentEmail = email;
            this.currentUserType = userType;
            
            txtProfileEmail.Text = currentEmail;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += UserProfileForm_FormClosing;

            LoadProfile();
        }

        private void UserProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Gerçekten çıkmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void LoadProfile()
        {
            string path = "profiles.csv";
            if (!File.Exists(path)) return;

            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts[0] == currentUsername)
                {
                    txtProfileName.Text = parts[1];
                    txtProfileSurname.Text = parts[2];
                    mtbProfilePhone.Text = parts[3];
                    txtProfileAddress.Text = parts[4];
                    txtProfileEmail.Text = parts[5];
                    txtProfilePassword.Text = parts[6];

                    if (parts.Length > 7)
                        pbProfilePhoto.Image = Base64ToImage(parts[7]);
                    break;
                }
            }
        }

        private void btnProfileSave_Click(object sender, EventArgs e)
        {
            string path = "UserProfiles.csv";
            var lines = new List<string>();
            bool updated = false;

            if (File.Exists(path))
                lines.AddRange(File.ReadAllLines(path));

            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split(',');
                if (parts[0] == currentUsername)
                {
                    lines[i] = string.Join(",", new string[]
                    {
                        currentUsername,
                        txtProfileName.Text,
                        txtProfileSurname.Text,
                        mtbProfilePhone.Text,
                        txtProfileAddress.Text,
                        txtProfileEmail.Text,
                        txtProfilePassword.Text,
                        ImageToBase64(pbProfilePhoto.Image)
                    });
                    updated = true;
                    break;
                }
            }

            if (!updated)
            {
                lines.Add(string.Join(",", new string[]
                {
                    currentUsername,
                    txtProfileName.Text,
                    txtProfileSurname.Text,
                    mtbProfilePhone.Text,
                    txtProfileAddress.Text,
                    txtProfileEmail.Text,
                    txtProfilePassword.Text,
                    ImageToBase64(pbProfilePhoto.Image)
                }));
            }

            File.WriteAllLines(path, lines);
            MessageBox.Show("Bilgiler başarıyla kaydedildi.", "Başarılı");
        }

        private void btnProfileSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbProfilePhoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private string ImageToBase64(Image image)
        {
            if (image == null) return "";
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        private Image Base64ToImage(string base64)
        {
            if (string.IsNullOrEmpty(base64)) return null;
            byte[] bytes = Convert.FromBase64String(base64);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void buttonPhoneBook_Click(object sender, EventArgs e)
        {
            PhoneBook f2 = new PhoneBook();
            f2.ShowDialog();
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {
            Notes f3 = new Notes();
            f3.ShowDialog();
        }

        private void buttonReminder_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalaryCalculator_Click(object sender, EventArgs e)
        {
            SalaryCalculator f4 = new SalaryCalculator();
            f4.ShowDialog();
        }
    }
}
