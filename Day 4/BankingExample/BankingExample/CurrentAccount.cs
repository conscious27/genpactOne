

using System;

namespace BankingExample
{
    public class CurrentAccount : IAccount
    {
        double currentBal;
        public CurrentAccount()
        {
            currentBal = 75000;
        }
        public double Balance => currentBal;

        public double Deposit(double amount)
        {
            currentBal += amount;
            return currentBal;
        }

        public double Withdraw(double amount)
        {
            if (currentBal < amount)
            {
                Console.WriteLine("Insufficient Balance!");
                Console.WriteLine("Transaction Fail!");
            }
            else
            {
                currentBal -= amount;
                Console.WriteLine("Transaction Successful!");
            }
            return currentBal;
        }
    }
}
