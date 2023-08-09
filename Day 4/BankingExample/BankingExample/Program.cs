using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount account;

            Console.WriteLine("Enter the Account Type: ");
            Console.WriteLine("1. Saving \n 2. Current");
            int acType = int.Parse(Console.ReadLine());
            switch (acType)
            {
                case 1:
                    {
                        account = new SavingAccount();
                        break;
                    }
                case 2:
                    {
                        account = new CurrentAccount();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Account Type");
                        return;
                    }
            }


            Console.WriteLine("Choose Operation \n 1. Balance \n 2. Deposit \n 3. Withdraw");
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                default:
                    {
                        Console.WriteLine("Invalid Operation");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Balance is: \t" + account.Balance);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Amount to be Deposit:");
                        double amount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance After Transaction: \t"+account.Deposit(amount));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter Amount to be Withdraw:");
                        double amount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance After Transcation: \t"+account.Withdraw(amount));
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
