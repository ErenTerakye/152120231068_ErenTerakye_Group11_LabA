using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ogrenci[] ogrenciListem;

        class Ogrenci
        {
            public string ogr_ad { get; set; }
            public string ogr_soyad { get; set; }
            public int ogr_boy { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenciListem = new Ogrenci[2];
            Ogrenci ugur = new Ogrenci();
            ugur.ogr_ad = "Ugur";
            ugur.ogr_soyad = "Gürel";
            ugur.ogr_boy = 170;
            ogrenciListem[0]=ugur;

            Ogrenci onur = new Ogrenci();
            onur.ogr_ad = "Onur";
            onur.ogr_soyad = "Gül";
            onur.ogr_boy = 190;
            ogrenciListem[1] = onur;



            int a = 90;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Ogrenci ogr in ogrenciListem)
            {
                txtEkran.Text += ogr.ogr_ad + " " + ogr.ogr_soyad + " " + ogr.ogr_boy+Environment.NewLine;

            }
            txtEkran.Text +=   Environment.NewLine;
            txtEkran.Text += Environment.NewLine;
            txtEkran.Text += Environment.NewLine;

            for (int i = 0; i < ogrenciListem.Length; i++)
            {
                txtEkran.Text += ogrenciListem[i].ogr_ad + " " + ogrenciListem[i].ogr_soyad + " " + ogrenciListem[i].ogr_boy+ Environment.NewLine; 
            }
        }
    }
}
