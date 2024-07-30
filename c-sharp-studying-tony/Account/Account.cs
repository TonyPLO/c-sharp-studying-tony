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
    internal class Account
    {
        public Owner owner;//{ get; private set; }
        public double Balance { get; private set; }
        public int Overdraft { get; private set; }
        public const int MAX_OVERDRAFT = 90000;


        
        public Account(Owner owner, double balance, int overdraft)
        {
            this.owner = owner;
            Balance = balance;
            Overdraft = overdraft > MAX_OVERDRAFT ? MAX_OVERDRAFT : overdraft;
        }

        public void SetOverdraft(int overdraft)
        {
            if (overdraft > MAX_OVERDRAFT)
            {
                Console.WriteLine($"Cannot set overdraft more than {MAX_OVERDRAFT}");
            }
            else
            {
                Overdraft = overdraft;
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance - amount < -Overdraft)
            {
                Console.WriteLine("Withdrawal exceeds overdraft limit. Transaction denied.");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}
