using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerProgram
{
    public class BankAccount
    {
         // Creates integer variable called "accountCount" and assigns value to 1
        private static int accountCount = 1;

        // 4 private member variables: customerName, checkings, savings, and loans
        private string customerName;
        private double checkings;
        private double savings;
        private double loans;

        // Public properties
        public string Name
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }
        public double BaseCheckings
        {
            get
            {
                return checkings;
            }

            set
            {
                checkings = value;
            }
        }
        public double BaseSavings
        {
            get
            {
                return savings;
            }

            set
            {
                savings = value;
            }
        }

        public double Loans { get => loans; set => loans = value; }

        // Constructor
        public BankAccount(String name, double baseCheckings, double baseSavings)
        {
            this.Name = name;
            this.BaseCheckings = baseCheckings;
            this.BaseSavings = baseSavings;
            this.Loans = loans;
        }

        // This method returns the employee's base salary
        public double getBaseCheckings()
        {
            return this.BaseCheckings;
        }

        // This method returns the employee's name
        public String getName()
        {
            return this.Name;
        }
    }
}