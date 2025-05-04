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

        private void btnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu benim Mesajım");
        }

        private void btnMsg2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu benim mesajım", "Bu da Başlık",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
        }

        private void btnMsg3_Click(object sender, EventArgs e)
        {
           DialogResult cevap = MessageBox.Show("Ekranı Maviye Boyamak İstiyormusunuz? ", "Soru :) ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(cevap == DialogResult.Yes )
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                this.BackColor = Color.White;
            }
        
        }

        private void btnMsg4_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Programı Kapatmak İstiyormusunuz ", "Soru ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
            if (cevap == DialogResult.Yes )
            {
                this.Close();
            }
        
        }
    }
}
