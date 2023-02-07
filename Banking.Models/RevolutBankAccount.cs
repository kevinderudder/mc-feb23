using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Models
{
    public sealed class RevolutBankAccount : BankAccount
    {

        public string Stock { get; set; }

        public RevolutBankAccount(string accountName, string accountNumber) 
            : base(accountName, accountNumber)
        {
        }

        public RevolutBankAccount(string accountName, string accountNumber, double amount) 
            : base(accountName, accountNumber, amount)
        {
        }

        public void BuyStock(string stock) { 
            this.Stock = stock;
        }

        public override string GenerateBankAccountNumber()
        {
            return "REVO1234" + new Random().Next();
        }
    }
}
