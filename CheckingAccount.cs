using System;

namespace PeerProgram
{
    public class CheckingAccount : BankAccount
    {
        // Sets base to 500 for all Savings objects
        public CheckingAccount(String name) 
            : base(name, 500)
        {

        }

        public double CalculateServiceFee()
        {
            double serviceFee = 0.3;
            if (this.Amount < 500)
            {
                serviceFee = 0.0;
            }
            else
            {
                Amount = Amount * serviceFee;
            }
            
            return Amount;
        }
    }
}