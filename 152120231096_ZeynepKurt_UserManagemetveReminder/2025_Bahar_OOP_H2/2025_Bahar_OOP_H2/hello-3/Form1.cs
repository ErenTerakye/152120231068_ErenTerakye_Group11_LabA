using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class ogrenci
        {
            public string adi { get; set; }
            public string soyadi { get; set; }
            public int yas { get; set; }

        }


        int[] dizinin_adi;

        ogrenci[] ogrencilerim;

        private void Form1_Load(object sender, EventArgs e)
        {
            // dizinin_adi = new int[5];

            //  dizinin_adi = new int[5] { 1, 2, 3, 4, 5 }; 
       

            dizinin_adi = new int[5];
            dizinin_adi[0]= 1;
            dizinin_adi[1] = 90;
            dizinin_adi[3] = 444;
            dizinin_adi[2] = 9;
            dizinin_adi[4] = 88;

            int a = 0;
            // DiziYazdir_1();
            DiziYazdir_2();
        }

        private void DiziYazdir_1()
        {
            for (int i = 0; i < dizinin_adi.Length; i++)
            {
                txtEkran.Text = txtEkran.Text +" "+ dizinin_adi[i] + Environment.NewLine ;

            }
        }

        private void DiziYazdir_2()
        {
            foreach (int item in dizinin_adi)
            {
                txtEkran.Text += item + Environment.NewLine;
            }
        }

        private void btnInitOgr_Click(object sender, EventArgs e)
        {
            ogrencilerim = new ogrenci[2];

            ogrenci myogrenci = new ogrenci();
            myogrenci.adi = "Ugur";
            myogrenci.soyadi = "Gürel";
            myogrenci.yas = 44;

            ogrencilerim[0] = myogrenci;

            ogrencilerim[1] = new ogrenci();
            ogrencilerim[1].adi = "Veli";
            ogrencilerim[1].soyadi = "Güzel";
            ogrencilerim[1].yas = 99;


            for (int i = 0; i < ogrencilerim.Length; i++)
            {
                txtEkran.Text += ogrencilerim[i].adi + " " + ogrencilerim[i].soyadi + " " + ogrencilerim[i].yas + Environment.NewLine;

            }


            foreach (ogrenci ogr in ogrencilerim)
            {
                txtEkran.Text += ogr.adi + " " + ogr.soyadi + " " + ogr.yas + Environment.NewLine;
            }

            int a = 90;
        }
    }
}
