using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(lstEkle.Items.Contains(txtEkle.Text))
            {
                MessageBox.Show("Bu Eleman Mevcut");
                txtEkle.Text = "";
            }
            else 
            { 
                lstEkle.Items.Add(txtEkle.Text);
                txtEkle.Text = "";
            }
        }

        private void btnTopluEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(txtElemanSayisi.Text); i++)
            {
                lstEkle.Items.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lstEkle.Items.Clear();
            for (int i = lstEkle.Items.Count-1; i >=0; i--)
            {
                lstEkle.Items.RemoveAt(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstEkle.Items.Remove(txtElemanSil.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstEkle.Items.RemoveAt(int.Parse(txtElemanSilİndis.Text));
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstEkle.Items.Contains(txtEkle.Text))
            {
                MessageBox.Show("Bu Eleman Mevcut");
                txtEkle.Text = "";
            }
            else
            {
                lstEkle.Items.Add(txtEkle.Text);
                txtEkle.Text = "";
            }
        }

        private void topluEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(txtElemanSayisi.Text); i++)
            {
                lstEkle.Items.Add(i.ToString());
            }
        }

        private void topluSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
             lstEkle.Items.Clear();
            
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstEkle.Items.RemoveAt(lstEkle.SelectedIndex);
            
        }
    }
}
