using System.Drawing;

namespace Banking.Models
{
    public abstract class BankAccount:IDisposable
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

        public BankAccountType Type { get; set; }

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

        public override bool Equals(object? obj)
        {
            //BankAccount other = (BankAccount)obj;
            BankAccount other = obj as BankAccount;
            if (other == null) return false;

          
            
            return base.Equals(this.AccountNumber == other.AccountNumber);
        }

        public void Dispose()
        {
            this.AccountNumber = null;
            this.AccountName = null;
            this.Amount = 0;
        }

        //public bool Equals(BankAccount? other)
        //{
        //    throw new NotImplementedException();
        //}
    }



   
}


