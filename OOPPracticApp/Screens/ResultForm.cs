using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPracticApp.Screens
{
    public partial class ResultForm : Form
    {
        List<double> result = new List<double>();
        public ResultForm()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            result.Add(Convert.ToDouble(textBoxPhysics.Text));
            result.Add(Convert.ToDouble(textBoxChemistry.Text));
            result.Add(Convert.ToDouble(textBoxMath.Text));
            if (result.Average() >= 80)
            {
                textBoxGradeLetter.Text = "A+";
            }
            else if (result.Average() >= 70)
            {
                textBoxGradeLetter.Text = "B+";
            }
            else if (result.Average() >= 60)
            {
                textBoxGradeLetter.Text = "C+";
            }
            else if (result.Average() >= 50)
            {
                textBoxGradeLetter.Text = "D+";
            }
            else if (result.Average() < 50)
            {
                textBoxGradeLetter.Text = "F";
            }

             textBoxAverage.Text = result.Average().ToString();
             textBoxPhysics.Text = "";
             textBoxChemistry.Text = "";
             textBoxMath.Text = "";
        }
    }
}
