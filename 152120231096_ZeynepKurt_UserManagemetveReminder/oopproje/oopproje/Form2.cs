using System;
using System.Windows.Forms;

namespace oopproje
{
    public partial class Form2 : Form
    {
        private User currentUser;

        public Form2(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnSaveReminder_Click(object sender, EventArgs e)
        {
            Reminder reminder = new Reminder()
            {
                Title = txtReminderTitle.Text,
                Description = txtReminderDesc.Text,
                Date = dtpReminderDate.Value,
                UserId = currentUser.Id
            };

            MessageBox.Show("Hatırlatıcı eklendi:\n" + reminder.Title);
        }
    }
}
