using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPPracticApp.Screens;

namespace OOPPracticApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AccountOperation());
            //Application.Run(new SalaryCalculation());
            //Application.Run(new CalculatorForm());
            //Application.Run(new PersonInformationForm());
            //Application.Run(new RefrigeratorForm());
            Application.Run(new VehicleForm());
        }
    }
}
