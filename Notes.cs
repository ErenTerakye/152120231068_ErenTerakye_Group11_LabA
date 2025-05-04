using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120231068_ErenTerakye_Group11_LabA
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNote.Text != "")
            {
                listBoxNotes.Items.Add(textBoxNote.Text);
                textBoxNote.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a note.");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedItem != null)
            {
                listBoxNotes.Items[listBoxNotes.SelectedIndex] = textBoxNote.Text;
                textBoxNote.Clear();
            }
            else
            {
                MessageBox.Show("Please select a note to update.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedItem != null)
            {
                listBoxNotes.Items.RemoveAt(listBoxNotes.SelectedIndex);
                textBoxNote.Clear();
            }
            else
            {
                MessageBox.Show("Please select a note to delete.");
            }
        }
    }
}
