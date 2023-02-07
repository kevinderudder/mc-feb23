using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
    public class KbcBankAccount : BankAccount
    {
        public KbcBankAccount(string accountName, string accountNumber) : base(accountName, accountNumber)
        {
        }

        public KbcBankAccount(string accountName, string accountNumber, double amount) : base(accountName, accountNumber, amount)
        {
        }
    }
}
