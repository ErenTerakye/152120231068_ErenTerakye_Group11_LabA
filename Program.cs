﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using personalInformation;
using userManagement;

namespace _152120231068_ErenTerakye_Group11_LabA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // *Uncomment the form you want to run*
            // Application.Run(new SalaryCalculator());
            // Application.Run(new PersonalInformation());
            // Application.Run(new Notes());
            // Application.Run(new PhoneBook());
            Application.Run(new UserLoginForm());
        }
    }
}
