using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120231068_ErenTerakye_Group11_LabA
{
    public partial class PhoneBook : Form
    {
        int id = 0;
        public PhoneBook()
        {
            InitializeComponent();
        }



        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regex for (123) 456 78 90 format
            string pattern = @"^\(\d{3}\) \d{3} \d{2} \d{2}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        // Crate SaveToCSV method for buttonAdd_Click
        private void SaveToCSV(string id, string name, string surname, string phoneNumber, string address, string description, string email)
        {
            string filePath = "phonebook.csv";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
            {
                file.WriteLine($"{id},{name},{surname},{phoneNumber},{address},{description},{email}");
            }
        }

        private void UpdateCSV(string id, string name, string surname, string phoneNumber, string address, string description, string email)
        {
            string filePath = "phonebook.csv";
            var lines = System.IO.File.ReadAllLines(filePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(id + ","))
                {
                    lines[i] = $"{id},{name},{surname},{phoneNumber},{address},{description},{email}";
                    break;
                }
            }
            System.IO.File.WriteAllLines(filePath, lines);
        }

        // Create delete method for buttonDelete_Click
        private void DeleteFromCSV(string id)
        {
            string filePath = "phonebook.csv";
            var lines = System.IO.File.ReadAllLines(filePath).ToList();
            lines.RemoveAll(line => line.StartsWith(id + ","));
            System.IO.File.WriteAllLines(filePath, lines);
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string phoneNumber = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            string description = textBoxDescription.Text;
            string email = textBoxEmail.Text;

            if (IsValidEmail(email) && IsValidPhoneNumber(phoneNumber))
            {
                id++;
                dataGridViewPhoneBook.Rows.Add(id.ToString(), name, surname, phoneNumber, address, description, email);
            }
            else
            {
                MessageBox.Show("Invalid email or phone number format.");
            }

            SaveToCSV(id.ToString(), name, surname, phoneNumber, address, description, email);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhoneBook.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPhoneBook.SelectedRows[0];
                selectedRow.Cells["Name"].Value = textBoxName.Text;
                selectedRow.Cells["Surname"].Value = textBoxSurname.Text;
                selectedRow.Cells["PhoneNumber"].Value = textBoxPhone.Text;
                selectedRow.Cells["Address"].Value = textBoxAddress.Text;
                selectedRow.Cells["Description"].Value = textBoxDescription.Text;
                selectedRow.Cells["Email"].Value = textBoxEmail.Text;
                MessageBox.Show("Contact updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a contact to update.");
            }

            UpdateCSV(id.ToString(), textBoxName.Text, textBoxSurname.Text, textBoxPhone.Text, textBoxAddress.Text, textBoxDescription.Text, textBoxEmail.Text);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhoneBook.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPhoneBook.SelectedRows[0];
                dataGridViewPhoneBook.Rows.Remove(selectedRow);
                MessageBox.Show("Contact deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a contact to delete.");
            }

            DeleteFromCSV(id.ToString());
        }
    }
}
