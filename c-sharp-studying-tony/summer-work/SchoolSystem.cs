using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.summer_work
{
    public class SchoolSystem//Question 9
    {
        public static void PrintExcellent(ReportCard[] array)
        {
            foreach (var reportCard in array)
            {
                if (reportCard != null && reportCard.IsExcellent())
                {
                    Console.WriteLine(reportCard.GetStuName());
                }
            }
        }
        public static void Demo()
        {

            //test of subjects : 
            //85 87 86 45 100 - not exellent
            //85 85 86 - not excellent 
            // 73, 68, 85, 60, 100 - not excellent 
            // 100, 100, 100, 54 - not excellent 
            // 90, 85, 100, 60,90 - excellent

            var subjects1 = new Subject[]
            {
            new Subject("Math", 95),
            new Subject("Science", 89)
            };

            var subjects2 = new Subject[]
            {
            new Subject("Math", 91),
            new Subject("Science", 92)
            };

            var reportCards = new ReportCard[]
            {
            new ReportCard("Alice", subjects1),
            new ReportCard("Bob", subjects2)
            };

            PrintExcellent(reportCards);
        }
    }


    public class Subject
    {
        private string subName;
        private double grade;

        public Subject(string subName, double grade)
        {
            this.subName = subName;
            this.grade = grade;
        }

        public string GetSubName()
        {
            return subName;
        }

        public void SetSubName(string value)
        {
            subName = value;
        }

        public double GetGrade()
        {
            return grade;
        }

        public void SetGrade(double value)
        {
            grade = value;
        }
    }

    public class ReportCard
    {
        private string stuName;
        private Subject[] subArray;

        //Set SubArray

        //TO FIX 
        public ReportCard(string stuName, Subject[] subArray)
        {
            this.stuName = stuName;
            this.subArray = subArray;
        }

        public string GetStuName()
        {
            return stuName;
        }

        public void SetStuName(string stuName)
        {
            this.stuName = stuName;
        }

        public Subject[] GetSubArray()
        {
            return subArray;
        }

        public void SetSubArray(Subject[] subArray)
        {
            this.subArray = subArray;
        }


        //to fix
        public double Average()
        {
            double total = 0;
            int count = subArray.Length;
            foreach (var subject in subArray)//convert to regular for
                //for (int i = 0;... subArray[i]. ....
            {
                total += subject.GetGrade();
            }
            return total / count;
        }


        //to fix 
        public bool IsExcellent()
        {
            return Average() > 90;
        }
    }
}





