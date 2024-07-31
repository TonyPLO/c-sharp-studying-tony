using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * TODO: 
 * - See for example Stadium class
 * - All variable begin in small letter
 * - Not use with Props
 * - All public variables should be privates
 * - Make internal - public 
 * 
 * */
namespace c_sharp_studying_tony.account
{
    public class Account
    {
        private Owner owner;
        private double balance;
        private int overdraft;
        public const int MAX_OVERDRAFT = 90000;

        public Account(Owner owner, double balance, int overdraft)
        {
            this.owner = owner;
            this.balance = balance;
            this.overdraft = overdraft > MAX_OVERDRAFT ? MAX_OVERDRAFT : overdraft;
        }

        public Owner GetOwner()
        {
            return owner;
        }

        public double GetBalance()
        {
            return balance;
        }

        public int GetOverDraft()
        {
            return overdraft;
        }

        public void SetOverdraft(int overdraft)
        {
            if (overdraft > MAX_OVERDRAFT)
            {
                Console.WriteLine($"Cannot set overdraft more than {MAX_OVERDRAFT}");
            }
            else
            {
                this.overdraft = overdraft;
            }
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (balance - amount < -overdraft)
            {
                Console.WriteLine("Withdrawal exceeds overdraft limit. Transaction denied.");
            }
            else
            {
                balance -= amount;
            }
        }
    }
}
