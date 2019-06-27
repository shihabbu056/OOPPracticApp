using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticApp.Models
{
    class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double Result { get; set; }

        public double Add(Calculator calculator)
        {
            return Result = FirstNumber + SecondNumber;
        }

        public double Subtract(Calculator calculator)
        {
            return Result = FirstNumber-SecondNumber;
        }

        public double Multiply(Calculator calculator)
        {
            return Result = FirstNumber * SecondNumber;
        }

        public double Divide(Calculator calculator)
        {
            return Result = FirstNumber / SecondNumber;
        }
    }
}
