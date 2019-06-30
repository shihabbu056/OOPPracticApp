using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticApp.Models
{
    class Refrigerator
    {
        public double MaximumWeight { get; set; }
        //public int ItemNo { get; set; }
        //public double ItemWeight { get; set; }
        public double TotalItems { get; set; }
        //public double RemainingWeight { get; set; }

        public double GetCurrentWeight(int item, double weightUnitKg)
        {
            //double totalItems = 0;
            return TotalItems += item * weightUnitKg;
        }

        public double GetRemainingWeight(int item, double weightUnitKg)
        {
            return MaximumWeight -= item * weightUnitKg;
            //return RemainingWeight -= TotalItems;
            //return remaingWeight - remaingWeight;
        }
    }
}
