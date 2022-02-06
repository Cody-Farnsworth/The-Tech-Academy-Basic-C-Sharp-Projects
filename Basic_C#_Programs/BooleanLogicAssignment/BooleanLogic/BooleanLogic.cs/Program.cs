using System;

namespace BooleanLogic.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageI = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI? True or False");
            string DUI = Console.ReadLine();
            bool DUIB = Convert.ToBoolean(DUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string Speed = Console.ReadLine();
            int SpeedI = Convert.ToInt32(Speed);
            bool ageB = ageI > 15;
            bool DUIBB = DUIB == false;
            bool SpeedB = SpeedI <= 3;
            bool Qualified = ageB && DUIBB && SpeedB;
            Console.WriteLine("Qualified? " + Qualified);
        }
    }
}
