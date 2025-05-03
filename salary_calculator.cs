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
    public partial class salary_calculator : Form
    {
        decimal grossMinimumWage;
        decimal baseSalary;
        decimal totalMultiplier;
        string cityOfResidence;

        public salary_calculator()
        {
            InitializeComponent();
            FillCityCombobox();
            FillEducationCombobox();
            FillPositionCombobox();

            comboBoxCities.SelectedItem = "-";
            comboBoxEducation.SelectedItem = "-";
            comboBoxPosition.SelectedItem = "-";
        }

        private void FillCityCombobox()
        {
            List<string> cities = new List<string>
            {
                "-", "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan",
                "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis",
                "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce",
                "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
                "Hakkâri", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük",
                "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis",
                "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş",
                "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Şanlıurfa", "Siirt",
                "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van",
                "Yalova", "Yozgat", "Zonguldak"
            };

            // Sort cities alphabetically
            cities.Sort();

            // Add cities to ComboBox
            comboBoxCities.Items.AddRange(cities.ToArray());
        }

        private void FillEducationCombobox()
        {
            List<string> educationLevels = new List<string>
            {
                "-",
                "Master’s Degree in a Relevant Field",
                "PhD in a Relevant Field",
                "Associate Professorship in a Relevant Field",
                "Master’s Degree in an Unrelated Field",
                "PhD/Associate Professorship in an Unrelated Field"
            };

            comboBoxEducation.Items.AddRange(educationLevels.ToArray());
        }

        private void FillPositionCombobox()
        {
            List<string> positions = new List<string>
            {
                "-",
                "Team Lead / Group Manager / Technical Manager / Software Architect",
                "Project Manager",
                "Director / Head of Projects",
                "CTO (Chief Technology Officer) / CEO (Chief Executive Officer)",
                "IT Officer / Manager (there are no more than 5 staff in the department)",
                "IT Officer / Manager (there are more than 5 staff in the department)"
            };

            comboBoxPosition.Items.AddRange(positions.ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // It is assumed that colleagues who graduated
            // from English-taught universities have
            // demonstrated English language proficiency
            checkBox1.Enabled = !checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                label5.Visible = true;
                numericUpDown2.Visible = true;
            }
            else
            {
                label5.Visible = false;
                numericUpDown2.Visible = false;
                numericUpDown2.Value = 0;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            totalMultiplier = 0;

            grossMinimumWage = numericUpDownGrossMinimumWage.Value;
            baseSalary = grossMinimumWage * 2;
            cityOfResidence = comboBoxCities.SelectedItem.ToString();

            labelBaseSalary.Visible = true;
            labelBaseSalary.Text = "Base Salary = Gross Minimum Wage * 2 = " +
                grossMinimumWage.ToString("F2") + " * 2 = " +
                baseSalary.ToString("F2") + " TL";

            labelTotalMultiplier.Text = "Total Multiplier: ";

            // Adjusts the totalMultiplier based on years worked
            if (numericUpDownYearsWorking.Value >= 2 &&
                numericUpDownYearsWorking.Value <= 4)
            {
                totalMultiplier += 0.6m;

                labelTotalMultiplier.Text += "0,60 (Years Working) + ";
            }
            else if (numericUpDownYearsWorking.Value >= 5 &&
                numericUpDownYearsWorking.Value <= 9)
            {
                totalMultiplier += 1;

                labelTotalMultiplier.Text += "1,00 (Years Working) + ";
            }
            else if (numericUpDownYearsWorking.Value >= 10 &&
                numericUpDownYearsWorking.Value <= 14)
            {
                totalMultiplier += 1.2m;

                labelTotalMultiplier.Text += "1,20 (Years Working) + ";
            }
            else if (numericUpDownYearsWorking.Value >= 15 &&
                numericUpDownYearsWorking.Value <= 20)
            {
                totalMultiplier += 1.35m;

                labelTotalMultiplier.Text += "1,35 (Years Working) + ";
            }
            else if (numericUpDownYearsWorking.Value > 20)
            {
                totalMultiplier += 1.5m;

                labelTotalMultiplier.Text += "1,50 (Years Working) + ";
            }

            if (cityOfResidence == "İstanbul")
            {
                totalMultiplier += 0.3m;

                labelTotalMultiplier.Text += "0,30 (" + cityOfResidence + ")";
            }
            else if (cityOfResidence == "Ankara" ||
                cityOfResidence == "İzmir")
            {
                totalMultiplier += 0.2m;

                labelTotalMultiplier.Text += "0,20 (" + cityOfResidence + ")";
            }
            else if (cityOfResidence == "Kocaeli" ||
                cityOfResidence == "Sakarya" ||
                cityOfResidence == "Düzce" ||
                cityOfResidence == "Bolu" ||
                cityOfResidence == "Yalova" ||
                cityOfResidence == "Edirne" ||
                cityOfResidence == "Kırklareli" ||
                cityOfResidence == "Tekirdağ")
            {
                totalMultiplier += 0.1m;

                labelTotalMultiplier.Text += "0,10 (" + cityOfResidence + ")";
            }
            else if (cityOfResidence == "Trabzon" ||
                cityOfResidence == "Ordu" ||
                cityOfResidence == "Giresun" ||
                cityOfResidence == "Rize" ||
                cityOfResidence == "Artvin" ||
                cityOfResidence == "Gümüşhane" ||
                cityOfResidence == "Bursa" ||
                cityOfResidence == "Eskişehir" ||
                cityOfResidence == "Bilecik" ||
                cityOfResidence == "Aydın" ||
                cityOfResidence == "Denizli" ||
                cityOfResidence == "Muğla" ||
                cityOfResidence == "Adana" ||
                cityOfResidence == "Mersin" ||
                cityOfResidence == "Balıkesir" ||
                cityOfResidence == "Çanakkale" ||
                cityOfResidence == "Antalya" ||
                cityOfResidence == "Isparta" ||
                cityOfResidence == "Burdur")
            {
                totalMultiplier += 0.05m;

                labelTotalMultiplier.Text += "0,05 (" + cityOfResidence + ")";
            }

        }
    }
}
