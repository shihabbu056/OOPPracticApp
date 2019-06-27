using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPPracticApp.Models;

namespace OOPPracticApp.Screens
{
    public partial class SalaryCalculation : Form
    {
        private readonly Salary _salary;
        public SalaryCalculation()
        {
            InitializeComponent();
            _salary = new Salary();
        }

        private void buttonShowMeSalary_Click(object sender, EventArgs e)
        {
            _salary.EmplayeeName = textBoxEmployeeName.Text;
            _salary.BasicSalary = Convert.ToDecimal(textBoxBasicAmount.Text);
            //_salary.HouseRent = Convert.ToDecimal(textBoxHouseRent.Text);
            //_salary.MedicalAllowance = Convert.ToDecimal(textBoxMedicalAllowance.Text);
            _salary.GetHouseRent(Convert.ToDecimal(textBoxHouseRent.Text));
            _salary.GetMedicalAllowance(Convert.ToDecimal(textBoxMedicalAllowance.Text));

            MessageBox.Show(_salary.GetTotalSalary(_salary));
        }
    }
}
