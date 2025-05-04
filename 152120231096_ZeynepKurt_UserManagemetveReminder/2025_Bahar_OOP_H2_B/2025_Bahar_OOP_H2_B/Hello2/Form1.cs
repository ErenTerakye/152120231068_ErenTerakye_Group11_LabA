using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello2
{
    public partial class Form1 : Form
    {
        int sayi1 = 0;
        int[] dizi;
        int indis = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dizi = new int[5];
        }

        private void BaskabirFonksiyon()
        {
             
        }

        private void btnRandomEleman_Click(object sender, EventArgs e)
        {
            if (indis < 5)
            {
                Random random = new Random(System.DateTime.Now.Millisecond);
                dizi[indis] = random.Next(0, 100);
                indis++;
            }

          

        }

        private void btnElemanListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                txtEkran.Text += dizi[i] + Environment.NewLine;
            }
            txtEkran.Text += Environment.NewLine;
            txtEkran.Text += Environment.NewLine;
            txtEkran.Text += Environment.NewLine;
             
            foreach (int sayi in dizi)
            {
                txtEkran.Text += sayi + Environment.NewLine;
            }
        }
    }
}
