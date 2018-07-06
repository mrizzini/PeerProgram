using System;

namespace PeerProgram
{
    class SavingsAccount : BankAccount
    {
        // Sets base to 100 for all Savings objects
        public SavingsAccount(String name) 
            : base(name, 100)
        {

        }

        public decimal InterestRate { get; set; }

        public double CalculateInterestGain()
        {
            double interest = 0.7;
            if (this.Amount < 100)
            {
                interest = 0.0;
            }
            else
            {
                Amount = Amount * interest;
            }
            return Amount;
        }
    }
}