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
        int Secilen_Secim_Sayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Aciklama = "";
            if(rbKadin.Checked)
            {
                Aciklama = "Kadın";
            }
            else
            {
                Aciklama = "Erkek";
            }

            if(rb_0_1000.Checked == true)
            {
                Aciklama += " Seçildi Gelir Düzeyi 0 - 1000 Arası";
            }
            else
            {
                Aciklama += " Seçildi Gelir Düzeyi 1001 - 5000 Arası";
            }

            lbEkran.Text = Aciklama;

        }


        private void SecimSayisiKontrolEt()
        {
            if(Secilen_Secim_Sayisi >=3)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor= Color.White;
            }
        }


        private void btnKontrol_Click(object sender, EventArgs e)
        {
            Secilen_Secim_Sayisi = 0;
            String Secim = "";

            if(cbSecim_1.Checked)
            {
                Secim = "Seçim 1 ";
                Secilen_Secim_Sayisi += 1;
            }

            if(cbSecim_2.Checked)
            {
                Secim += "Seçim 2";
                Secilen_Secim_Sayisi += 1;
            }

            if (cbSecim_3.Checked)
            {
                Secim += "Seçim 3";
                Secilen_Secim_Sayisi += 1;
            }

            if (cbSecim_4.Checked)
            {
                Secim += "Seçim 4";
                Secilen_Secim_Sayisi += 1;
            }


            if (cbSecim_5.Checked)
            {
                Secim += "Seçim 5";
                Secilen_Secim_Sayisi += 1;
            }
            SecimSayisiKontrolEt();
            lbEkran.Text = Secim;
        }
    }
}
