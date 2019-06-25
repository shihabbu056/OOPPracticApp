using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticApp.Models
{
    class Account
    {
        public int AccountId { get; set; }
        public long AccountNumber { get; set; }
        public string CustomerName { get; set; }
        private decimal Balance { get; set; }

        public decimal AddDeposit(decimal amount)
        {
            return Balance += amount;
        }

        public decimal GetWithdraw(decimal amount)
        {
            return Balance -= amount;
        }

        public string GetReport(Account account)
        {
            return "Customer Name : " + account.CustomerName + "\nAccount Number : " + account.AccountNumber +"\nBalance : " + account.Balance;
        }
    }
}
