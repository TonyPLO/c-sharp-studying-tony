using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.summer_work
{
    public class Question8
    {
       public static void TestQuestion8()
        {
            Console.WriteLine("Enter a passphrase:");
            string input = Console.ReadLine();
            string encrypted = Encrypt(input);
            Console.WriteLine("The encrypted sentence:");
            Console.WriteLine(encrypted);
        }

        public static string Encrypt(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (c == ' ')
                {
                    result.Append('@');
                }
                else
                {
                    result.Append(c);
                    result.Append(Char.ToUpper(c));
                }
            }

            return result.ToString();
        }
    }
}
