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
    public partial class AccountOperation : Form
    {
        readonly Account _account;
        public AccountOperation()
        {
            InitializeComponent();

            _account = new Account();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            _account.AccountNumber = Convert.ToInt64(textBoxAccountNumber.Text);
            _account.CustomerName = textBoxCustomerName.Text;

            textBoxAccountNumber.Text = "";
            textBoxCustomerName.Text = "";
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            _account.AddDeposit(Convert.ToDecimal(textBoxAmount.Text));

            textBoxAmount.Text = "";
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            _account.GetWithdraw(Convert.ToDecimal(textBoxAmount.Text));
            textBoxAmount.Text = "";
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_account.GetReport(_account));
        }
    }
}
