using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            String Aciklama = "";

            if(rbKadin.Checked)
            {
                Aciklama = " Kadın ";
            }
            else
            {
                Aciklama = " Erkek ";
            }

            if ( rb_0_1000.Checked)
            {
                Aciklama += " Gelir Düzeyi 0-1000 Seçildi";
            }
            else if(rb_1001_5000.Checked)
            {
                Aciklama += " Gelir Düzeyi 1001-5000 Seçildi";
            }
            else
            {
                Aciklama += " Gelir Düzeyi 5000'den büyük Seçildi";
            }

            lbEkran.Text = Aciklama;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbKadin.Checked = true;
            rb_0_1000.Checked = true;
        }

        private void rbKadin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Aciklama = "";
            int bencede = 0;

            if(chk_1.Checked)
            {
                Aciklama += "Seçim 1";
                bencede++;
            }
            if (chk_2.Checked)
            {
                Aciklama += " Seçim 2";
                bencede++;
            }
            if (chk_3.Checked)
            {
                Aciklama += " Seçim 3";
                bencede++;
            }
            if (chk_4.Checked)
            {
                Aciklama = Aciklama+ " Seçim 4";
                bencede++;
            }
            if (chk_5.Checked)
            {
                Aciklama += " Seçim 5";
                bencede++;
            }

            if(bencede > 3)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.White;
            }

            lbEkran.Text=Aciklama;



        }
    }
}
