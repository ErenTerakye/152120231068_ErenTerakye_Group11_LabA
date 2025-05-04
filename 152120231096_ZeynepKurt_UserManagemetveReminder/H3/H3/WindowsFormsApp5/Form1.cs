using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            cmbEkle.Items.Add(txtEkle.Text);
        }

        private void cmbEkle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEkle.SelectedIndex==0)
            {
                this.BackColor = Color.Blue;
            }
            else if (cmbEkle.SelectedIndex == 1)
            {
                this.BackColor = Color.LimeGreen;
            }
            else
            {
                this.BackColor = Color.Red;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEkle.SelectedIndex = 0;
        }
    }
}
