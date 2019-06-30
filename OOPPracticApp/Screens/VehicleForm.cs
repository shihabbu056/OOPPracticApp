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
    public partial class VehicleForm : Form
    {
        readonly private Vehicle _vehicle;
        private List<int> speeds =new List<int>();
        public VehicleForm()
        {
            InitializeComponent();
            _vehicle = new Vehicle();
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            _vehicle.VehicleName = textBoxVehicleName.Text;
            _vehicle.RegNo = Convert.ToInt32(textBoxRegNo.Text);
            MessageBox.Show("Vehicle Save Successfully!");
            textBoxVehicleName.Text = "";
            textBoxRegNo.Text = "";
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
           // speeds = new List<int>();
            speeds.Add(Convert.ToInt32(textBoxSpeed.Text));
            _vehicle.VehicleSpeed = speeds;
            textBoxSpeed.Text = "";

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            //textBoxMinSpeed.Text = _vehicle.VehicleSpeed();
            textBoxMinSpeed.Text = speeds.Min().ToString();
            textBoxMaxSpeed.Text = speeds.Max().ToString();
            textBoxAvgSpeed.Text = speeds.Average().ToString();
        }
    }
}
