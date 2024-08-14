using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.summer_work
{
    internal class Question5
    {
        static void testQuestion5()
        {
            int count = 0;
            int number = 1;

            while (count < 10)
            {
                int sum1 = SumOfDivisors(number);
                int sum2 = SumOfDivisors(sum1);

                if (sum2 == number && number != sum1 && number < sum1)
                {
                    Console.WriteLine($"{number} and {sum1} are mates");
                    count++;
                }

                number++;
            }
        }

        static int SumOfDivisors(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
