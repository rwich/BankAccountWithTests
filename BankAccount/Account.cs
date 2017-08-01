using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a bank account
    /// </summary>
    public class Account
    {
        public Account()
        {

        }

        public Account(double initialBalance)
        {
            if(initialBalance < 0)
            {
                throw new ArgumentException();
            }
            Balance = initialBalance;
        }

        public double Balance
        {
            get; private set;
        }

        /// <summary>
        /// Adds an amount to the balance
        /// </summary>
        /// <param name="amt">Amount to be added</param>
        public void Deposit(double amt)
        {
            if (amt > 0)
            {
                Balance += amt;
            }
            else
            {
                throw new ArgumentException("Deposit must be greater than 0!");
            }
        }

        /// <summary>
        /// Subtacts an amount from the balance
        /// </summary>
        /// <param name="amt">Amount to be subtracted</param>
        public void Withdraw(double amt)
        {
            if(amt < 0)
            {
                throw new ArgumentException("Withdraw amount cannot be negative");
            }
            Balance -= amt;
        }
    }
}
