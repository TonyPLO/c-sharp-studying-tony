﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.account
{
    public class TestAccount
    {
        public static void Test1()
        {
            Console.WriteLine("Test Account - Test 1");

            string firstName = "Abraham";
            string lastName = "Israel";

            Owner owner1 = new Owner(firstName, lastName);
            Account account1 = new Account(owner1, 20000, 15000);

            Console.WriteLine("Testing owner creation");

            bool allPassed = true;
            if (account1.GetOwner().GetFirstName().Equals(firstName))
            {
                Console.WriteLine("Test 1 - passed");
            }
            else
            {
                Console.Error.WriteLine("Error at Test1 owner first name at account. expected = " + firstName
                    + "| actual = " + account1.GetOwner().GetFirstName());
                allPassed = false;
            }

            if (account1.GetOwner().GetLastName().Equals(lastName))
            {
                Console.WriteLine("Test 2 - passed");
            }
            else
            {
                Console.Error.WriteLine("Error at Test2 owner last name at account. expected = " + lastName
                    + "| actual = " + account1.GetOwner().GetLastName());
                allPassed = false;
            }

            Console.WriteLine("Testing Deposit");

            account1.Deposit(1570);

            if (account1.GetBalance() == 21570)
            {
                Console.WriteLine("Test 3 - passed");
            }
            else
            {
                Console.WriteLine("Error at Test3 deposit in account. expected = " + 21570
                    + "| actual = " + account1.GetBalance());
                allPassed = false;
            }

            // Testing another instance
            firstName = "Moshe";
            lastName = "Faith";

            Owner owner2 = new Owner(firstName, lastName);
            Account account2 = new Account(owner2, 240, 5000);

            Console.WriteLine("Testing owner creation");
            if (account2.GetOwner().GetFirstName().Equals(firstName))
            {
                Console.WriteLine("Test 4 - passed");
            }
            else
            {
                Console.Error.WriteLine("Error at Test4 owner first name at account. expected = " + firstName
                    + "| actual = " + account2.GetOwner().GetFirstName());
                allPassed = false;
            }

            if (account2.GetOwner().GetLastName().Equals(lastName))
            {
                Console.WriteLine("Test 5 - passed");
            }
            else
            {
                Console.Error.WriteLine("Error at Test5 owner last name at account. expected = " + lastName
                    + "| actual = " + account2.GetOwner().GetLastName());
                allPassed = false;
            }

            Console.WriteLine("Testing Deposit");

            account2.Deposit(645);

            if (account2.GetBalance() == 240 + 645)
            {
                Console.WriteLine("Test 6 - passed");
            }
            else
            {
                Console.WriteLine("Error at Test6 deposit in account. expected = " + (240 + 645)
                    + "| actual = " + account2.GetBalance());
                allPassed = false;
            }

            // Test withdraw
            account2.Withdraw(100);

            if (account2.GetBalance() == 785)
            {
                Console.WriteLine("Test 7 - passed");
            }
            else
            {
                Console.WriteLine("Error at Test 7 Withdraw in account. expected = " + 785
                    + "| actual = " + account2.GetBalance());
                allPassed = false;
            }

            // Test overdraft
            account2.Withdraw(7000);
            if (account2.GetBalance() == 785)
            {
                Console.WriteLine("Test 8 - passed");
            }
            else
            {
                Console.WriteLine("Error at Test 8 testOverDraft in account. expected = " + 785
                    + "| actual = " + account2.GetBalance());
                allPassed = false;
            }

            // Test max overdraft
            account2.SetOverdraft(100000);

            if (account2.GetOverDraft() == 5000)
            {
                Console.WriteLine("Test 9 - passed");
            }
            else
            {
                Console.WriteLine("Error at Test 9 testOverDraft in account. expected = " + 5000
                    + "| actual = " + account2.GetOverDraft());
                allPassed = false;
            }

            // Test max overdraft
            account2.SetOverdraft(80000);

            if (account2.GetOverDraft() == 80000)
            {
                Console.WriteLine("Test 10 - passed");
            }
            else
            {
                Console.WriteLine("Error at Test 10 testOverDraft in account. expected = " + 80000
                    + "| actual = " + account2.GetOverDraft());
                allPassed = false;
            }

            account2.Withdraw(7000);
            if (account2.GetBalance() == (785 - 7000))
            {
                Console.WriteLine("Test 11 - passed");
            }
            else
            {
                Console.WriteLine("Error at Test 11 Withdraw in account. expected = " + (785 - 7000)
                    + "| actual = " + account2.GetBalance());
                allPassed = false;
            }

            Console.WriteLine("\n*********************************\n");

            if (allPassed)
            {
                Console.WriteLine("All TEST PASSED - WELL DONE!!");
            }
            else
            {
                Console.WriteLine("YOU HAVE FAILURES AT THE TESTS :( - SEE ABOVE");
            }

            Console.WriteLine("\n*********************************\n");
        }
    }
}


