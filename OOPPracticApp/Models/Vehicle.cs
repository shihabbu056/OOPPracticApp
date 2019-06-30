using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticApp.Models
{
    class Vehicle
    {
        private List<Vehicle> vehicles = new List<Vehicle>(); 
        public string VehicleName { get; set; }
        public int RegNo { get; set; }
        public int SpeedMesures { get; set; }

        public List<Vehicle> VehicleSpeed
        {
            get { return vehicles; }
            set { vehicles = value; }
        }
    }
}
