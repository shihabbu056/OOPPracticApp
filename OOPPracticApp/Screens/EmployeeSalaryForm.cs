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
    public partial class EmployeeSalaryForm : Form
    {
        private Employee employee = new Employee();
        
        public EmployeeSalaryForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            employee.EmployeeId = textBoxEmployeeId.Text;
            employee.EmployeeName = textBoxEmployeeName.Text;
            employee.EmployeeEmail = textBoxEmployeeEmail.Text;

            Salary2 salary = new Salary2();
            salary.BasicAmount = Convert.ToDouble(textBoxBasicSalary.Text);
            salary.MedicalPercent = Convert.ToDouble(textBoxMedical.Text);
            salary.ConveyancePercent = Convert.ToDouble(textBoxConveyance.Text);
            employee.Salary = salary;
        }
    }
}
