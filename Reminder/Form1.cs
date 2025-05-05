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
                MessageBox.Show("L�tfen ba�l�k ve a��klama giriniz.");
                return;
            }

            // Hat�rlat�c�y� kay�t i�lemi burada yap�labilir (veritaban� yoksa mesajla sim�le ediyoruz)
            MessageBox.Show($"Hat�rlat�c� kaydedildi!\n\nBa�l�k: {title}\nA��klama: {description}\nTarih: {date.ToShortDateString()}");

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
