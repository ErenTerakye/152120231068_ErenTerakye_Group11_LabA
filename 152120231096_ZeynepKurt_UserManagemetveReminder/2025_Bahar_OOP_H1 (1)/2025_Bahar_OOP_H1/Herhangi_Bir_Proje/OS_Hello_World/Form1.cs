using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // lbEkran.Text = "MErhaba Dünya";
           btnIslem.Location = new Point(btnIslem.Location.X+5, btnIslem.Location.Y+5);
        }

        private void btnIslem_MouseHover(object sender, EventArgs e)
        {
            lbEkran.Text = "Mouse ÜZerinde";
            lbEkran.BackColor = Color.Aqua;
        }

        private void btnIslem_MouseLeave(object sender, EventArgs e)
        {
            lbEkran.Text = "";
        }

        private void btnMerhaba_Click(object sender, EventArgs e)
        {
            lbEkran.Text = "Merhaba " + txtAd.Text +" "+txtSoyad.Text;
            txtAd.Text = "";
            txtSoyad.Text = "";
        }

        private void btnIslem_MouseEnter(object sender, EventArgs e)
        {
            btnIslem.Location = new Point(btnIslem.Location.X + 1, btnIslem.Location.Y);
        }

        private void btnIslem_MouseMove(object sender, MouseEventArgs e)
        {
            btnIslem.Location = new Point(btnIslem.Location.X + 1, btnIslem.Location.Y);

        }
    }
}
