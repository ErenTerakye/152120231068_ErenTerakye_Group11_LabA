using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "";
            if (chkArmut.Checked)
            {
                txtEkran.Text += "Armut Seçili" + Environment.NewLine; ;
            }

            if(chkElma.Checked)
            {
                txtEkran.Text+= "Elma Seçili " + Environment.NewLine; ;
            }

        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if(rbGreen.Checked)
            {
                this.BackColor = Color.Green;
            }

        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                this.BackColor = Color.Blue;
            }
        }
    }
}
