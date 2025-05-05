using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;


namespace personalInformation
{
    public partial class Form1 : Form
    {
        Stack<string[]> undoStack = new Stack<string[]>();
        Stack<string[]> redoStack = new Stack<string[]>();

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            txtName.TextChanged += (s, ev) => SaveCurrentStateToUndo();
            txtSurname.TextChanged += (s, ev) => SaveCurrentStateToUndo();
            mtbPhone.TextChanged += (s, ev) => SaveCurrentStateToUndo();
            txtAddress.TextChanged += (s, ev) => SaveCurrentStateToUndo();
            txtEmail.TextChanged += (s, ev) => SaveCurrentStateToUndo();
            txtPassword.TextChanged += (s, ev) => SaveCurrentStateToUndo();

        }
        private bool isEditMode = false; // default: kayıt modu

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

        private void Form1_Load(object sender, EventArgs e)
        {
            string username = Session.currentUsername;
            string path = "profiles.csv";

            if (!string.IsNullOrEmpty(username) && File.Exists(path))
            {
                isEditMode = true; // Giriş yapıldı, düzenleme modundayız
                btnSave.Visible = false;
                btnUpdate.Visible = true;

                var lines = File.ReadAllLines(path).Skip(1);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts[0] == username)
                    {
                        txtUsername.Text = parts[0];
                        txtName.Text = parts[1];
                        txtSurname.Text = parts[2];
                        mtbPhone.Text = parts[3];
                        txtAddress.Text = parts[4];
                        txtEmail.Text = parts[5];
                        txtPassword.Text = parts[6];

                        if (parts.Length > 7 && !string.IsNullOrEmpty(parts[7]))
                        {
                            byte[] imgBytes = Convert.FromBase64String(parts[7]);
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                picPhoto.Image = Image.FromStream(ms);
                            }
                        }

                        txtUsername.ReadOnly = true; // Kullanıcı adını değiştirmesin
                        break;
                    }
                }
            }
            else
            {
                // Kayıt modundayız
                isEditMode = false;
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = "profiles.csv";
            string username = Session.currentUsername;

            if (!File.Exists(path))
            {
                MessageBox.Show("profiles.csv dosyası bulunamadı.");
                return;
            }

            var lines = new List<string>(File.ReadAllLines(path));

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(username + ","))
                {
                    string base64Photo = "";
                    if (picPhoto.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            picPhoto.Image.Save(ms, picPhoto.Image.RawFormat);
                            base64Photo = Convert.ToBase64String(ms.ToArray());
                        }
                    }

                    lines[i] = string.Join(",", new string[]
                    {
                username,
                txtName.Text,
                txtSurname.Text,
                mtbPhone.Text,
                txtAddress.Text,
                txtEmail.Text,
                txtPassword.Text,
                base64Photo
                    });
                    break;
                }
            }

            File.WriteAllLines(path, lines);
            MessageBox.Show("Güncelleme başarılı.");
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(GetCurrentState()); // Şu anki durumu ileri almak için sakla
                var previousState = undoStack.Pop(); // Önceki durumu al
                ApplyState(previousState); // Uygula
            }
            else
            {
                MessageBox.Show("Geri alınacak bir işlem yok.");
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(GetCurrentState()); // Şu anki durumu geri al için sakla
                var nextState = redoStack.Pop(); // İleri durum al
                ApplyState(nextState); // Uygula
            }
            else
            {
                MessageBox.Show("İleri alınacak bir işlem yok.");
            }
        }
        private string[] GetCurrentState()
        {
            return new string[]
            {
        txtName.Text,
        txtSurname.Text,
        mtbPhone.Text,
        txtAddress.Text,
        txtEmail.Text,
        txtPassword.Text
            };
        }

        private void ApplyState(string[] state)
        {
            if (state == null || state.Length < 6) return;

            txtName.Text = state[0];
            txtSurname.Text = state[1];
            mtbPhone.Text = state[2];
            txtAddress.Text = state[3];
            txtEmail.Text = state[4];
            txtPassword.Text = state[5];
        }
        private void SaveCurrentStateToUndo()
        {
            undoStack.Push(GetCurrentState());
            redoStack.Clear(); // Yeni işlem yapıldığında ileri yığını temizlenir
        }


    }


}
