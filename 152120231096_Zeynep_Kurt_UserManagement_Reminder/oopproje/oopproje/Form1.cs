using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace oopproje
{
    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();
        private User currentUser;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Id = users.Count + 1,
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            users.Add(user);
            currentUser = user;

            MessageBox.Show("Kayýt baþarýlý!");
        }

        private void btnOpenReminderForm_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Lütfen önce kayýt olun.");
                return;
            }

            Form2 reminderForm = new Form;
        }
    }
}