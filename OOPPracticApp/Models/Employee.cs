using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticApp.Models
{
    class Employee
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public Salary2 Salary { get; set; }

        public bool GetMedical(double medicalPercent)
        {
            Salary.BasicAmount += (Salary.BasicAmount * Salary.MedicalPercent) / 100;
            return true;
        }

        public bool GetConveyance(double conveyancePercent)
        {
            Salary.BasicAmount += (Salary.BasicAmount * Salary.ConveyancePercent) / 100;
            return true;
        }

        public int IncrementSalary(double amount)
        {

        }

        public double GetTotalSalary()
        {

        }
    }
}
