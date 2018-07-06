using System;

namespace PeerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates BankCustomer Object with name Manny called employee1
            var customer1 = new BankCustomer("Manny");
            // Instantiates BankCustomer Object with name Willy called employee2
            var customer2 = new BankCustomer("Willy");
        }
    }
}
