using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;


namespace personalInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = "profiles.csv";

            // CSV dosyası yoksa başlık satırı ile oluştur
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "username,name,surname,phone,address,email,password,photo\n");
            }

            // Formdaki bilgileri al
            string username = txtUsername.Text.Trim();
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string phone = mtbPhone.Text;
            string address = txtAddress.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string photoBase64 = "";

            if (picPhoto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picPhoto.Image.Save(ms, picPhoto.Image.RawFormat);
                    photoBase64 = Convert.ToBase64String(ms.ToArray());
                }
            }

            // Bilgileri csv'ye ekle
            File.AppendAllText(path, $"{username},{name},{surname},{phone},{address},{email},{password},{photoBase64}\n");

            MessageBox.Show("Kayıt başarılı!");

            // Kayıttan sonra LoginForm'a geç
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

     

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
