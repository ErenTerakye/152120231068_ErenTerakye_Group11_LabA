namespace OOP_Çalışma
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Kaydol_Click(object sender, EventArgs e)
        {
            label6.Text =  "Kayıt olundu";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SIFIRLA_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label6.Text = "Tekrar kaydolabilirsiniz. ";
        }
    }
}
