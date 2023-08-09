using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingExample
{
    public class SavingAccount : IAccount
    {
        double savingBal;

        public SavingAccount() 
        { 
            savingBal = 30000;
        }

        public double Balance => savingBal;

        public double Deposit(double amount)
        {
            savingBal += amount;
            return savingBal;
        }

        public double Withdraw(double amount)
        {
            if(amount > savingBal)
            {
                Console.WriteLine("InSufficient Amount!");
                Console.WriteLine("Transaction Declined!");
            }
            else
            {
                if(amount > savingBal-10000)
                {
                    Console.WriteLine("You Have to Maintain at least 10k in your saving Account!");
                    Console.WriteLine("Transaction Declined!");
                }
                else
                {
                    savingBal -= amount;
                    Console.WriteLine("Transaction Successful!");
                }
            }
            return savingBal;
        }
    }
}
