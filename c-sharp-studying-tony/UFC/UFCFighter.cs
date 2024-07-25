using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.UFC
{
    internal class UFCFighter
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int PowerPunch { get; set; }
        public int[] Record { get; set; } = new int[3]; // wins, losses, draws

        public UFCFighter(string name, int weight, int height, int powerPunch, int wins, int losses, int draws)
        {
            Name = name;
            Weight = weight;
            Height = height;
            PowerPunch = powerPunch;
            Record[0] = wins;
            Record[1] = losses;
            Record[2] = draws;
        }

        public void DisplayFighterData()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Height: {Height} cm");
            Console.WriteLine($"Reach: {PowerPunch} cm");
            Console.WriteLine($"Record: {Record[0]}{Record[1]}{Record[2]}");
        }
        public void ChangeWeight(int newWeight)
        {
            Weight = newWeight;
        }

        public void Change(int newHeight, int newPowerPunch, int wins, int losses, int draws)
        {
            Height = newHeight;
            PowerPunch = newPowerPunch;
            Record[0] = wins;
            Record[1] = losses;
            Record[2] = draws;
        }

        public bool HasPositiveRecord()
        {
            return Record[0] > Record[1];
        }
    }

    public class ObjectBasicsDemo
    {
        public static void FighterDemo()
        {
            UFCFighter fighter1 = new UFCFighter("Conor McGregor", 70, 175, 180, 22, 6, 0);//שם משקל גובה כוח ניצחונות אפסדים תקו
            UFCFighter fighter2 = new UFCFighter("Francis Ngannou", 119, 193, 210, 17, 3, 0);
            UFCFighter fighter3 = new UFCFighter("Tyson Fury", 115, 206, 185, 30, 0, 1);
            UFCFighter fighter4 = new UFCFighter("Tony BASS", 140, 230, 2369, 3579, 0, 1);
            UFCFighter fighter5 = new UFCFighter("Izhar", 80, 178, 185, 4, 480, 74);

            fighter1.DisplayFighterData();
            fighter2.DisplayFighterData();
            fighter3.DisplayFighterData();
            fighter4.DisplayFighterData();
            fighter5.DisplayFighterData();

            fighter2.ChangeWeight(62);
            fighter2.DisplayFighterData();

            Console.WriteLine($"Has positive record: {fighter2.HasPositiveRecord()}");
        }

        public static void Demo()
        {
            FighterDemo();
        }
    }
}
