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
        decimal minimumGrossSalary;
        int yearsWorked;
        string cityOfResidence;
        string highestEducationLevel;
        string managerialPosition;
        int childrenZeroToSix;
        int childrenSevenToEighteen;
        int childrenOverEighteen;


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
                "PhD / Associate Professorship in an Unrelated Field"
            };

            comboBoxEducation.Items.AddRange(educationLevels.ToArray());
        }

        private void FillPositionCombobox()
        {
            List<string> positions = new List<string>
            {
                "-",
                "Team Lead",
                "Group Manager",
                "Technical Manager",
                "Software Architect",
                "Project Manager",
                "Director",
                "Head of Projects",
                "CTO (Chief Technology Officer)",
                "CEO (Chief Executive Officer)",
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
            checkBoxCertifiedEnglish.Enabled = !checkBoxGraduateOfEnglish.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCertifiedAdditional.Checked)
            {
                label5.Visible = true;
                numericUpDownCertifiedAdditional.Visible = true;
            }
            else
            {
                label5.Visible = false;
                numericUpDownCertifiedAdditional.Visible = false;
                numericUpDownCertifiedAdditional.Value = 0;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            totalMultiplier = 0;
            bool isLabelUpdated = false;

            grossMinimumWage = numericUpDownGrossMinimumWage.Value;
            baseSalary = grossMinimumWage * 2;
            yearsWorked = (int)numericUpDownYearsWorked.Value;
            cityOfResidence = comboBoxCities.SelectedItem.ToString();
            highestEducationLevel = comboBoxEducation.SelectedItem.ToString();
            managerialPosition = comboBoxPosition.SelectedItem.ToString();
            childrenZeroToSix = (int)numericUpDownZeroToSix.Value;
            childrenSevenToEighteen = (int)numericUpDownSevenToEighteen.Value;
            childrenOverEighteen = (int)numericUpDownOverEighteen.Value;

            labelBaseSalary.Visible = true;
            labelBaseSalary.Text = "Base Salary = Gross Minimum Wage * 2 = " +
                grossMinimumWage.ToString("F2") + " * 2 = " +
                baseSalary.ToString("F2") + " TL";

            labelTotalMultiplier.Text = "Total Multiplier: ";

            // Adjusts the totalMultiplier based on years worked
            if (yearsWorked >= 2 && yearsWorked <= 4)
            {
                totalMultiplier += 0.6m;
                labelTotalMultiplier.Text += "0,60 (Years Working)";
                isLabelUpdated = true;
            }
            else if (yearsWorked >= 5 && yearsWorked <= 9)
            {
                totalMultiplier += 1;
                labelTotalMultiplier.Text += "1,00 (Years Working)";
                isLabelUpdated = true;
            }
            else if (yearsWorked >= 10 && yearsWorked <= 14)
            {
                totalMultiplier += 1.2m;
                labelTotalMultiplier.Text += "1,20 (Years Working)";
                isLabelUpdated = true;
            }
            else if (yearsWorked >= 15 && yearsWorked <= 20)
            {
                totalMultiplier += 1.35m;
                labelTotalMultiplier.Text += "1,35 (Years Working)";
                isLabelUpdated = true;
            }
            else if (yearsWorked > 20)
            {
                totalMultiplier += 1.5m;
                labelTotalMultiplier.Text += "1,50 (Years Working)";
                isLabelUpdated = true;
            }

            // Adjusts the totalMultiplier based on the city of residence
            if (cityOfResidence == "İstanbul")
            {
                totalMultiplier += 0.3m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,30 (" + cityOfResidence + ")";
                isLabelUpdated = true;
            }
            else if (cityOfResidence == "Ankara" || cityOfResidence == "İzmir")
            {
                totalMultiplier += 0.2m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,20 (" + cityOfResidence + ")";
                isLabelUpdated = true;
            }
            else if (cityOfResidence == "Kocaeli" || cityOfResidence == "Sakarya" || cityOfResidence == "Düzce" ||
                     cityOfResidence == "Bolu" || cityOfResidence == "Yalova" || cityOfResidence == "Edirne" ||
                     cityOfResidence == "Kırklareli" || cityOfResidence == "Tekirdağ")
            {
                totalMultiplier += 0.1m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,10 (" + cityOfResidence + ")";
                isLabelUpdated = true;
            }
            else if (cityOfResidence == "Trabzon" || cityOfResidence == "Ordu" || cityOfResidence == "Giresun" ||
                     cityOfResidence == "Rize" || cityOfResidence == "Artvin" || cityOfResidence == "Gümüşhane" ||
                     cityOfResidence == "Bursa" || cityOfResidence == "Eskişehir" || cityOfResidence == "Bilecik" ||
                     cityOfResidence == "Aydın" || cityOfResidence == "Denizli" || cityOfResidence == "Muğla" ||
                     cityOfResidence == "Adana" || cityOfResidence == "Mersin" || cityOfResidence == "Balıkesir" ||
                     cityOfResidence == "Çanakkale" || cityOfResidence == "Antalya" || cityOfResidence == "Isparta" ||
                     cityOfResidence == "Burdur")
            {
                totalMultiplier += 0.05m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,05 (" + cityOfResidence + ")";
                isLabelUpdated = true;
            }

            // Adjusts the totalMultiplier based on the education level
            if (highestEducationLevel == "Master’s Degree in a Relevant Field")
            {
                totalMultiplier += 0.1m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,10 (Master's Degree)";
                isLabelUpdated = true;
            }
            else if (highestEducationLevel == "PhD in a Relevant Field")
            {
                totalMultiplier += 0.3m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,30 (PhD)";
                isLabelUpdated = true;
            }
            else if (highestEducationLevel == "Associate Professorship in a Relevant Field")
            {
                totalMultiplier += 0.35m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,35 (Associate Professorship)";
                isLabelUpdated = true;
            }
            else if (highestEducationLevel == "Master’s Degree in an Unrelated Field")
            {
                totalMultiplier += 0.05m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,05 (Master's Degree in an Unrelated Field)";
                isLabelUpdated = true;
            }
            else if (highestEducationLevel == "PhD / Associate Professorship in an Unrelated Field")
            {
                totalMultiplier += 0.15m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,15 (PhD / Associate Professorship in an Unrelated Field)";
                isLabelUpdated = true;
            }

            // Adjusts the totalMultiplier based on English proficiency
            if (checkBoxCertifiedEnglish.Checked || checkBoxGraduateOfEnglish.Checked)
            {
                totalMultiplier += 0.2m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                if (checkBoxGraduateOfEnglish.Checked)
                {
                    labelTotalMultiplier.Text += "0,20 (Graduate of English-Taught Program)";
                }
                else
                {
                    labelTotalMultiplier.Text += "0,20 (Certified English Proficiency)";
                }
                isLabelUpdated = true;
            }

            if (checkBoxCertifiedAdditional.Checked && numericUpDownCertifiedAdditional.Value != 0)
            {
                totalMultiplier += numericUpDownCertifiedAdditional.Value * 0.05m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += (numericUpDownCertifiedAdditional.Value * 0.05m).ToString("F2") + " (Certified Knowledge of Additional Foreign Language(s))";
                isLabelUpdated = true;
            }

            // Adjusts the totalMultiplier based on the managerial position
            if (managerialPosition == "Team Lead" || managerialPosition == "Group Manager" ||
                managerialPosition == "Technical Manager" || managerialPosition == "Software Architect")
            {
                totalMultiplier += 0.5m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,50 (" + managerialPosition + ")";
                isLabelUpdated = true;
            }
            else if (managerialPosition == "Project Manager")
            {
                totalMultiplier += 0.75m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,75 (" + managerialPosition + ")";
                isLabelUpdated = true;
            }
            else if (managerialPosition == "Director" || managerialPosition == "Head of Projects")
            {
                totalMultiplier += 0.85m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,85 (" + managerialPosition + ")";
                isLabelUpdated = true;
            }
            else if (managerialPosition == "CTO (Chief Technology Officer)" || managerialPosition == "CEO (Chief Executive Officer)")
            {
                totalMultiplier += 1;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "1,00 (" + managerialPosition + ")";
                isLabelUpdated = true;
            }
            else if (managerialPosition == "IT Officer / Manager (there are no more than 5 staff in the department)")
            {
                totalMultiplier += 0.4m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,40 (IT Officer / Manager - <=5 Staff)";
                isLabelUpdated = true;
            }
            else if (managerialPosition == "IT Officer / Manager (there are more than 5 staff in the department)")
            {
                totalMultiplier += 0.6m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,60 (IT Officer / Manager - >5 Staff)";
                isLabelUpdated = true;
            }

            // Family allowance
            if (checkBoxMarried.Checked)
            {
                totalMultiplier += 0.2m;
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += "0,20 (Married and Spouse is not Working)";
                isLabelUpdated = true;
            }

            // Calculate the allowance for children
            List<decimal> childCoefficients = new List<decimal>();

            for (int i = 0; i < childrenZeroToSix; i++)
            {
                childCoefficients.Add(0.20m);
            }

            for (int i = 0; i < childrenSevenToEighteen; i++)
            {
                childCoefficients.Add(0.30m);
            }

            for (int i = 0; i < childrenOverEighteen; i++)
            {
                childCoefficients.Add(0.40m);
            }

            childCoefficients.Sort((a, b) => b.CompareTo(a));

            decimal childAllowance = 0;
            for (int i = 0; i < Math.Min(2, childCoefficients.Count); i++)
            {
                childAllowance += childCoefficients[i];
            }

            totalMultiplier += childAllowance;
            if (childAllowance > 0)
            {
                if (isLabelUpdated) labelTotalMultiplier.Text += " + ";
                labelTotalMultiplier.Text += childAllowance.ToString("F2") + " (Child Allowance)";
            }

            if (isLabelUpdated) labelTotalMultiplier.Text += " = " + totalMultiplier.ToString("F2");
            else labelTotalMultiplier.Text += totalMultiplier.ToString("F2");

            minimumGrossSalary = baseSalary * (totalMultiplier + 1);
            labelMinimumGrossSalary.Visible = true;
            labelMinimumGrossSalary.Text = "Minimum Monthly Gross Salary = Base Salary x (" + totalMultiplier.ToString("F2") + " + 1) = " + baseSalary.ToString("F2") + " x (" +
                totalMultiplier.ToString("F2") + " + 1) = " + minimumGrossSalary.ToString("F2") + " TL";
        }
    }
}
