using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace oopproje
{
    public partial class ReminderForm : Form
    {
        private User currentUser;

        public ReminderForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Reminder reminder = new Reminder()
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                Date = dtpDate.Value,
                UserId = currentUser.Id
            };

            ReminderService.AddReminder(reminder);
            MessageBox.Show("Hatýrlatýcý kaydedildi.");
        }
    }
}
