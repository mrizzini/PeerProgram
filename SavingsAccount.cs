using System;

namespace PeerProgram
{
    class SavingsAccount : BankAccount
    {
        // Sets base to 100 for all Savings objects
        public SavingsAccount(String name) : base(100)
        {

        }
        public override double CalculateInterestGain()
        {
            double interest = 0.7;
            if (this.BaseSavings < 100)
            {
                interest = 0.0;
            }
            else
            {
                BaseSavings = BaseSavings * interest;
            }
            return BaseSavings;
        }
    }
}