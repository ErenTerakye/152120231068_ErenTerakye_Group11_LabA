using System;
using System.Windows.Forms;

namespace Reminder
{
    public partial class AddEditReminderForm : Form
    {
        public Reminder CreatedReminder { get; private set; }

        public AddEditReminderForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            dtpDate.MinDate = DateTime.Today;
            cmbCategory.Items.AddRange(new[] { "İş", "Kişisel", "Aile" });
            cmbCategory.SelectedIndex = 0;

            rbMeeting.CheckedChanged += (s, e) => TogglePanels();
            rbTask.CheckedChanged += (s, e) => TogglePanels();
        }

        private void TogglePanels()
        {
            pnlMeetingFields.Visible = rbMeeting.Checked;
            pnlTaskFields.Visible = rbTask.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (rbMeeting.Checked)
            {
                CreatedReminder = new MeetingReminder
                {
                    Location = txtLocation.Text
                };
            }
            else if (rbTask.Checked)
            {
                CreatedReminder = new TaskReminder
                {
                    Category = cmbCategory.Text
                };
            }

            SetCommonProperties();

            ReminderService.AddReminder(CreatedReminder);
            DialogResult = DialogResult.OK;
        }

        private void SetCommonProperties()
        {
            CreatedReminder.Summary = txtSummary.Text;
            CreatedReminder.Date = dtpDate.Value;
            CreatedReminder.Time = new TimeSpan((int)numHour.Value, (int)numMinute.Value, 0);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtSummary.Text))
            {
                MessageBox.Show("Özet alanı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void pnlMeetingFields_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
