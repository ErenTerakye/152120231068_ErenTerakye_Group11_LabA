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
            chkListbox.Items.Add(txtEkle.Text); 
            listBox1.Items.Add(txtEkle.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                chkListbox.Items.Add(i.ToString());
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chkListbox.Items.Clear();
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(chkListbox.Items.Contains(txtEkle.Text))
            {
                MessageBox.Show("Bu Eleman Mevcut");
            }
            else
            {
                chkListbox.Items.Add(txtEkle.Text);
            }

           if( listBox1.Items.Contains(txtEkle.Text))
            {
                MessageBox.Show("Bu Eleman Mevcut");
            }
            else
            {
                listBox1.Items.Add(txtEkle.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chkListbox.Items.Remove(txtCikar.Text);
            listBox1.Items.Remove(txtCikar.Text);
        }

        private void hepsiniSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListbox.Items.Count; i++)
            {
                chkListbox.SetItemChecked(i, true);
            }
        }

        private void seçimiTersineÇevirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListbox.Items.Count; i++)
            {
                if (chkListbox.GetItemChecked(i))
                {
                    chkListbox.SetItemChecked(i, false);
                }
                else
                {
                    chkListbox.SetItemChecked(i, true);
                }

            }
        }

        private void seçilmişleriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = chkListbox.Items.Count-1; i >=0; i--)
            {
                if (chkListbox.GetItemChecked(i))
                { 
                    chkListbox.Items.RemoveAt(i);
                } 
            }
        }

        private void seçiliOlanıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
