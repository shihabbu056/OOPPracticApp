using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticApp.Models
{
    class Salary
    {
        public string EmplayeeName { get; set; }
        public decimal TotalSalary { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal HouseRent { get; set; }
        public decimal MedicalAllowance { get; set; }

        public void GetHouseRent(decimal houseRent)
        {
            TotalSalary += (BasicSalary*houseRent)/100;
        }

        public void GetMedicalAllowance(decimal medicalAllowance)
        {
            TotalSalary += (BasicSalary*medicalAllowance)/100;
        }

        public string GetTotalSalary(Salary salary)
        {
            return salary.EmplayeeName+" your salary is : "+(TotalSalary+BasicSalary).ToString();
        }
    }
}
