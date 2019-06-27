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
    public partial class CalculatorForm : Form
    {
        readonly private Calculator _calculator;
        public CalculatorForm()
        {
            InitializeComponent();
            _calculator = new Calculator();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _calculator.FirstNumber = Convert.ToDouble(textBoxFirstNumber.Text);
            _calculator.SecondNumber = Convert.ToDouble(textBoxSecondNumber.Text);
            textBoxFirstNumber.Text = "";
            textBoxSecondNumber.Text = "";
            textBoxResult.Text = _calculator.Add(_calculator).ToString();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            _calculator.FirstNumber = Convert.ToDouble(textBoxFirstNumber.Text);
            _calculator.SecondNumber = Convert.ToDouble(textBoxSecondNumber.Text);
            textBoxFirstNumber.Text = "";
            textBoxSecondNumber.Text = "";
            textBoxResult.Text = _calculator.Subtract(_calculator).ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            _calculator.FirstNumber = Convert.ToDouble(textBoxFirstNumber.Text);
            _calculator.SecondNumber = Convert.ToDouble(textBoxSecondNumber.Text);
            textBoxFirstNumber.Text = "";
            textBoxSecondNumber.Text = "";
            textBoxResult.Text = _calculator.Multiply(_calculator).ToString();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            _calculator.FirstNumber = Convert.ToDouble(textBoxFirstNumber.Text);
            _calculator.SecondNumber = Convert.ToDouble(textBoxSecondNumber.Text);
            textBoxFirstNumber.Text = "";
            textBoxSecondNumber.Text = "";
            textBoxResult.Text = _calculator.Divide(_calculator).ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstNumber.Text = "";
            textBoxSecondNumber.Text = "";
            textBoxResult.Text = "";
        }
    }
}
