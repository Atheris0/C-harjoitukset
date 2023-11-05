using BankAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccounts
{
    public class CheckingAccount : BankAccount
    {
        private double withdrawalLimit;
        public CheckingAccount(string name, int number, double balance, double rate, double limit)
        : base(name, number, balance, rate)
        {
            withdrawalLimit = limit;
        }

        public double DepositMoney(double amount)
        {
            return AccountBalance += amount; 
        }

        public double DrawMoney(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
                return 0;
            }

            if (amount > withdrawalLimit)
            {
                Console.WriteLine("Withdrawal amount exceeds the limit.");
                return 0;
            }

            if (amount > AccountBalance)
            {
                Console.WriteLine("Insufficient balance.");
                return 0;
            }

            AccountBalance -= amount;
            return amount;
        }
    }
}
