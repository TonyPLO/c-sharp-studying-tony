using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony
{
    internal class QuestionIzhar1
    {
        public static class TestSolution
        {
            //method1
            // Tests for Sum method:
            // Sum(1, 2) should return 3
            // Sum(-1, 1) should return 0
            // Sum(0, 0) should return 0
            // Sum(100, 200) should return 300
            // Sum(-50, -50) should return -100
            public static int Sum(int a, int b)
            {
                return a + b;
            }
            //method2
            // Tests for IsPalindrome method:
            // IsPalindrome("madam") should return true
            // IsPalindrome("hello") should return false
            // IsPalindrome("racecar") should return true
            // IsPalindrome("level") should return true
            // IsPalindrome("Test") should return false

            public static bool IsPalindrome(string str)
            {
                string reversed = new string(str.ToCharArray().Reverse().ToArray());
                return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
            }
            //method3
            // Tests for FindMax method:
            // FindMax(new int[] {1, 2, 3, 4, 5}) should return 5
            // FindMax(new int[] {-1, -2, -3, -4, -5}) should return -1
            // FindMax(new int[] {0, 100, 50, 25}) should return 100
            // FindMax(new int[] {10, 10, 10}) should return 10
            // FindMax(new int[] {7}) should return 7
            public static int FindMax(int[] numbers)
            {
                int max = numbers[0];
                foreach (int number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }
                return max;
            }
            //method4
            // Tests for IsEven method:
            // IsEven(2) should return true
            // IsEven(3) should return false
            // IsEven(0) should return true
            // IsEven(-2) should return true
            // IsEven(-3) should return false
            public static bool IsEven(int number)
            {
                return number % 2 == 0;
            }
            //method5
            // Tests for Factorial method:
            // Factorial(0) should return 1
            // Factorial(1) should return 1
            // Factorial(5) should return 120
            // Factorial(3) should return 6
            // Factorial(10) should return 3628800
            public static int Factorial(int number)
            {
                if (number == 0 || number == 1) return 1;
                int result = 1;
                for (int i = 2; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            }
        }
    }
}
