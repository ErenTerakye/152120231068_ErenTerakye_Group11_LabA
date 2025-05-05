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

            // Load data from CSV file into DataGridView
            string filePath = "phonebook.csv";
            if (System.IO.File.Exists(filePath))
            {
                var lines = System.IO.File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var values = line.Split(',');

                    if (values[0] == "id" && values[1] == "name" && values[2] == "surname" && values[3] == "phoneNumber" && values[4] == "address" && values[5] == "description" && values[6] == "email")
                    {
                        continue;
                    }
                    else if (values.Length == 7)
                    {
                        dataGridViewPhoneBook.Rows.Add(values);

                        // Update the highest ID
                        if (int.TryParse(values[0], out int parsedId) && parsedId > id)
                        {
                            id = parsedId;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("CSV file not found. A new file will be created.");
            }

            // Increment id to start from the next available ID
            id++;
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

        private void DeleteFromCSV(string id)
        {
            string filePath = "phonebook.csv";
            var lines = System.IO.File.ReadAllLines(filePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(id + ","))
                {
                    lines.RemoveAt(i);
                    break;
                }
            }
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
                // Ensure the ID is unique
                while (dataGridViewPhoneBook.Rows.Cast<DataGridViewRow>()
                    .Any(row => row.Cells[0].Value?.ToString() == id.ToString()))
                {
                    id++;
                }

                dataGridViewPhoneBook.Rows.Add(id.ToString(), name, surname, phoneNumber, address, description, email);
                SaveToCSV(id.ToString(), name, surname, phoneNumber, address, description, email);

                // Increment id for the next entry
                id++;

                textBoxName.Clear();
                textBoxSurname.Clear();
                textBoxPhone.Clear();
                textBoxAddress.Clear();
                textBoxDescription.Clear();
                textBoxEmail.Clear();
                dataGridViewPhoneBook.ClearSelection();


                MessageBox.Show("Contact added successfully.");
            }
            else
            {
                MessageBox.Show("Invalid email or phone number format.");
            }
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhoneBook.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPhoneBook.SelectedRows[0];
                string id = selectedRow.Cells["Number"].Value.ToString();

                selectedRow.Cells["Name"].Value = textBoxName.Text;
                selectedRow.Cells["Surname"].Value = textBoxSurname.Text;
                selectedRow.Cells["PhoneNumber"].Value = textBoxPhone.Text;
                selectedRow.Cells["Address"].Value = textBoxAddress.Text;
                selectedRow.Cells["Description"].Value = textBoxDescription.Text;
                selectedRow.Cells["Email"].Value = textBoxEmail.Text;

                UpdateCSV(id, textBoxName.Text, textBoxSurname.Text, textBoxPhone.Text, textBoxAddress.Text, textBoxDescription.Text, textBoxEmail.Text);

                textBoxName.Clear();
                textBoxSurname.Clear();
                textBoxPhone.Clear();
                textBoxAddress.Clear();
                textBoxDescription.Clear();
                textBoxEmail.Clear();
                dataGridViewPhoneBook.ClearSelection();

                MessageBox.Show("Contact updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a contact to update.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhoneBook.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPhoneBook.SelectedRows[0];
                string id = selectedRow.Cells["Number"].Value.ToString();

                dataGridViewPhoneBook.Rows.Remove(selectedRow);

                DeleteFromCSV(id);

                textBoxName.Clear();
                textBoxSurname.Clear();
                textBoxPhone.Clear();
                textBoxAddress.Clear();
                textBoxDescription.Clear();
                textBoxEmail.Clear();
                dataGridViewPhoneBook.ClearSelection();

                MessageBox.Show("Contact deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a contact to delete.");
            }
        }

        private void dataGridViewPhoneBook_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewPhoneBook.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPhoneBook.SelectedRows[0];

                textBoxName.Text = selectedRow.Cells["Name"].Value?.ToString();
                textBoxSurname.Text = selectedRow.Cells["Surname"].Value?.ToString();
                textBoxPhone.Text = selectedRow.Cells["PhoneNumber"].Value?.ToString();
                textBoxAddress.Text = selectedRow.Cells["Address"].Value?.ToString();
                textBoxDescription.Text = selectedRow.Cells["Description"].Value?.ToString();
                textBoxEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string rawNumber = new string(textBoxPhone.Text.Where(char.IsDigit).ToArray());

            if (!char.IsControl(e.KeyChar) && rawNumber.Length + 1 > 10)
            {
                e.Handled = true;
                return;
            }

            // If the key is a digit, format manually
            if (char.IsDigit(e.KeyChar))
            {
                rawNumber += e.KeyChar;

                string formatted = FormatPhoneNumber(rawNumber);
                textBoxPhone.Text = formatted;
                textBoxPhone.SelectionStart = textBoxPhone.Text.Length;
                e.Handled = true;
            }
        }

        // Helper method to format digits as (XXX) XXX XX XX
        private string FormatPhoneNumber(string raw)
        {
            if (raw.Length <= 3)
                return "(" + raw;
            else if (raw.Length <= 6)
                return "(" + raw.Substring(0, 3) + ") " + raw.Substring(3);
            else if (raw.Length <= 8)
                return "(" + raw.Substring(0, 3) + ") " + raw.Substring(3, 3) + " " + raw.Substring(6);
            else
                return "(" + raw.Substring(0, 3) + ") " + raw.Substring(3, 3) + " " + raw.Substring(6, 2) + " " + raw.Substring(8);
        }
    }
}
