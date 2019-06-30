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
    public partial class RefrigeratorForm : Form
    {
        readonly private Refrigerator _refrigerator;
        public RefrigeratorForm()
        {
            InitializeComponent();
            _refrigerator = new Refrigerator();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _refrigerator.MaximumWeight = Convert.ToDouble(textBoxMaximumWeightItCanTake.Text);
            textBoxMaximumWeightItCanTake.Text = "";
            MessageBox.Show("Save Successfully!");

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //_refrigerator.ItemNo = Convert.ToInt32(textBoxNumberOfItems.Text);
            //_refrigerator.ItemWeight = Convert.ToDouble(textBoxWeightKGUnit.Text);
            textBoxCurrentWeight.Text = _refrigerator.GetCurrentWeight(Convert.ToInt32(textBoxNumberOfItems.Text),Convert.ToDouble(textBoxWeightKGUnit.Text)).ToString();
            textBoxRemainingWeight.Text = _refrigerator.GetRemainingWeight(Convert.ToInt32(textBoxNumberOfItems.Text), Convert.ToDouble(textBoxWeightKGUnit.Text)).ToString();
            textBoxNumberOfItems.Text = "";
            textBoxWeightKGUnit.Text = "";
            if (_refrigerator.MaximumWeight <= -1)
            {
                MessageBox.Show("Items Number and Weight Overload!");
            }
        }
    }
}
