using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony
{
    internal class Room
    {
        //variables names starting with lower letter (אות קטנה)
        public static bool isExpensive = true;   

        public static double price = 103.89;

        public static int age = 16;

        public static string keyboard = "razer";

        public static int Glass(int Keyboard)
        {
            isExpensive = price>100;
            Console.WriteLine("my variables are:isExpensive="+isExpensive
            + ",price="+ price + ",age=" + age + ",keyboard=" + keyboard);
            return 0;
        }
    }
}
