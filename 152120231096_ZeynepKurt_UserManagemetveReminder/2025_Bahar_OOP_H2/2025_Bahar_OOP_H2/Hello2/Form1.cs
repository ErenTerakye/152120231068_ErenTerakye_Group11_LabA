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
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Text = e.X + " " + e.Y;
            if (e.X < 50)
            {
                txtEkran.Text = "Merhaba MouseMove SOL";
            }
            else
            {
                txtEkran.Text = "Merhaba MouseMove SAĞ";
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
           
            txtEkran.BackColor = Color.Yellow;
            txtEkran.ForeColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            txtEkran.Text = "";
            txtEkran.BackColor = Color.White ;
        }
    }
}
