namespace Reminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveReminder_Click(object sender, EventArgs e)
        {
            string title = txtReminderTitle.Text;
            string description = txtReminderDesc.Text;
            DateTime date = dtpReminderDate.Value;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Lütfen baþlýk ve açýklama giriniz.");
                return;
            }

            // Hatýrlatýcýyý kayýt iþlemi burada yapýlabilir (veritabaný yoksa mesajla simüle ediyoruz)
            MessageBox.Show($"Hatýrlatýcý kaydedildi!\n\nBaþlýk: {title}\nAçýklama: {description}\nTarih: {date.ToShortDateString()}");

            // Temizleme
            txtReminderTitle.Text = "";
            txtReminderDesc.Text = "";
            dtpReminderDate.Value = DateTime.Now;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
