using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder
{
    public partial class MainReminderForm : Form
    {
        public MainReminderForm()
        {
            InitializeComponent();
            InitializeGrid();
            SetupEventHandlers();
            new ReminderObserver(this); // Otomatik kayıt
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditReminderForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReminderService.AddReminder(form.CreatedReminder);
            }
        }

        private void MainReminderForm_Load(object sender, EventArgs e)
        {
            cmbFilterType.SelectedIndex = 0; // "Tümü" varsayılan seçili
            dgvReminders.DataSource = ReminderService.Reminders;
        }



        private void InitializeGrid()
        {
            dgvReminders.AutoGenerateColumns = false;
            dgvReminders.Columns.Clear();

            dgvReminders.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "colSummary", DataPropertyName = "Summary", HeaderText = "Özet" },
                new DataGridViewTextBoxColumn { Name = "colDate", DataPropertyName = "Date", HeaderText = "Tarih" },
                new DataGridViewTextBoxColumn { Name = "colType", HeaderText = "Tür" }
            );

            dgvReminders.DataSource = ReminderService.Reminders;
        }

        private void SetupEventHandlers()
        {
            btnAdd.Click += (s, e) => new AddEditReminderForm().ShowDialog();
            btnRefresh.Click += (s, e) => dgvReminders.Refresh();

            dgvReminders.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex == dgvReminders.Columns["colType"].Index)
                    e.Value = e.RowIndex >= 0 ?
                        (dgvReminders.Rows[e.RowIndex].DataBoundItem is MeetingReminder ? "Toplantı" : "Görev") : "";
            };
        }
    }
}