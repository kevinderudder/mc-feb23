using System.Drawing;

namespace Banking.Models
{
    public abstract class BankAccount
    {
        // fields
        //private string _accountNumber;
        //private string _accountName;
        private double _amount;

        // properties
        public string AccountNumber { get; private set; }

        public string AccountName { get; set; }

        public double Amount
        {
            get { return _amount; }
            private set {
                if (value < 0) throw new Exception("value must be positive!");
                _amount = value; 
            }
        }

        // constructors
        public BankAccount(string accountName, string accountNumber)
            : this(accountName, accountNumber, 0)
        {
            //AccountName   = accountName;
            //AccountNumber = accountNumber;
            //Amount = 0;
        }

        public BankAccount(string accountName, string accountNumber, double amount)
        {
            AccountName = accountName;
            AccountNumber = GenerateBankAccountNumber();
            Amount = amount;
        }

        // methods
        public void Add(double amount) {
            this.Amount += amount;
        }

        public void Subtract(double amount) {
            if (amount > this.Amount) throw new Exception("te veel");
            this.Amount -= amount;
        }

        public abstract string GenerateBankAccountNumber();


        // events

        // overrides
        public override string ToString()
        {
            return $"{this.AccountName} - {this.AccountNumber}";
;        }
    }



   
}


