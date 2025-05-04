using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Merhaba Dünya";
        }

        private void btnTıkla_Click(object sender, EventArgs e)
        {
           
            txtEkran.BackColor = Color.Yellow;
            txtEkran.ForeColor = Color.Green;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lbX.Text = e.X.ToString(); 
            lbY.Text=e.Y.ToString();

        }
    }
}
