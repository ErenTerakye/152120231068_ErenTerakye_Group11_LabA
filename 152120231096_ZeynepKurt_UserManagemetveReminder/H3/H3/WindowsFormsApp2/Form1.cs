using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
           DialogResult benimCevabim= MessageBox.Show("Merhaba ekranı Mavi Yapmak İstermisin ? ",
                "Bu Bir Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(benimCevabim==DialogResult.Yes)
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                this.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult benimCevabim = MessageBox.Show("Formu Kapatmak İstermisin ? ",
              "Bu Bir Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(benimCevabim==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          DialogResult cevap=  MessageBox.Show("Soru","3 Seçenekli Soru",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                lbEkran.Text = " Kullanıcı EVET seçeneğini Seçti";
            }
            else if (cevap == DialogResult.No)
            {
                lbEkran.Text = " Kullanıcı HAYIR seçeneğini Seçti";
            }
            else
            {
                lbEkran.Text = " Kullanıcı İptal Seçeneğini Seçti";
            }
        }
    }
}
