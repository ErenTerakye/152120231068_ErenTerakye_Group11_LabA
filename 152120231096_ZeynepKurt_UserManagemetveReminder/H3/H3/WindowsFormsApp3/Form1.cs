using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtEkle.Text.Length > 0) { 
                chkLbEkle.Items.Add(txtEkle.Text);
                txtEkle.Text = "";
            }
            else
            {
                MessageBox.Show("Metin Boş Olamaz");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            chkLbEkle.Items.Remove(txtEkle.Text);
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            chkLbEkle.Items.RemoveAt(int.Parse(txtEkle.Text));
        }

        private void btnTopluEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                chkLbEkle.Items.Add(i.ToString());
            }
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLbEkle.Items.Count; i++)
            {
                chkLbEkle.SetItemChecked(i, true);
            }
        }

        private void tersiniSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLbEkle.Items.Count; i++)
            {
                if(chkLbEkle.GetItemChecked(i) == true)
                {
                    chkLbEkle.SetItemChecked(i, false);
                }
                else
                {
                    chkLbEkle.SetItemChecked(i, true);
                }

            }
        }

        private void seçilenleriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = chkLbEkle.Items.Count-1; i >=0; i--)
            {
                if (chkLbEkle.GetItemChecked(i) == true)
                { chkLbEkle.Items.RemoveAt(i); }

            }
        }
    }
}
