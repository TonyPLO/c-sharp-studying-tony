using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony
{
    public class Try1
    {
        public static void PrintEvens(int numMax)
        {
            Console.WriteLine("hello tony");
            for (int i = 0; i <= numMax; i += 2)
            {
                Console.WriteLine(i);
            }
            Room.Glass(1);
            Room.price = 97.8;
            Room.Glass(3);
        }
    }
}
//    public class Question1
//    {
//        public static void main(String[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("הזן ציון");
//                int grade = reder.nextInt();

//                grades.add(grade);
//            }
//            double sum = 0;
//            int count = 0;

//            for (int grade : grades)
//            {
//                if (grade >= 70)
//                {
//                    sum += grade;
//                    count++;
//                }
//            }

//            if (count > 0)
//            {
//                double average = sum / count;
//                Console.WriteLine("ממוצע הציונים הגדולים או שווים ל-70: " + average);
//            }
//            else
//            {
//                Console.WriteLine("לא הוזנו ציונים גדולים או שווים ל-70.");

//            }
//        }
//    }
//    public class Question2
//    {
//        public static void PrintEvens(int numMax)
//        {
//                Random random = new Random();

//                while (true)
//                {
//                    int number = 10 + random.nextInt(90);

//                    Console.WriteLine("הוגרל המספר: " + number);

//                    if (number == 18)
//                    {
//                        Console.WriteLine("הוגרל המספר 18. סיום התוכנית.");
//                        break;
//                    }
//                }
//        }
//    }   
//    public class Question3
//        public static void main(String[] args)
//        {
//             int upperCaseCount = 0;
//             int lowerCaseCount = 0;

//             while (true)
//             {
//                Console.WriteLine("הזן אות באנגלית או ספרה לסיום");
//                String input = reder.next();
//                char ch = input.charAt(0);

//                if (Character.isDigit(ch))
//                {
//                break; 
//                }

//                if (Character.isUpperCase(ch))
//                {
//                upperCaseCount++;
//                }
//                else if (Character.isLowerCase(ch))
//                {
//                lowerCaseCount++;
//                }
//        }

//        Console.WriteLine("מספר האותיות הגדולות שנקלטו: " + upperCaseCount);
//        Console.WriteLine("מספר האותיות הקטנות שנקלטו: " + lowerCaseCount);

//
//        }
//}
//

