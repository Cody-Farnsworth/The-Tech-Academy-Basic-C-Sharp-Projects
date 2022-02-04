using System;

namespace MathComparisonAssignment.cs
{
    class Program
    {
        private const double V = 4.3;

        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your Hourly Rate?");
            string P1HR = Console.ReadLine();
            float P1HRF = Convert.ToInt32(P1HR);
            Console.WriteLine("How many hours do you work per week?");
            string P1HW = Console.ReadLine();
            int P1HWI = Convert.ToInt32(P1HW);
            float WeekWage1 = P1HRF * P1HWI;
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your Hourly Rate?");
            string P2HR = Console.ReadLine();
            float P2HRF = Convert.ToInt32(P2HR);
            Console.WriteLine("How many hours do you work per week?");
            string P2HW = Console.ReadLine();
            int P2HWI = Convert.ToInt32(P2HW);
            float WeekWage2 = P2HRF * P2HWI;
            float WeeksPerMonth = 4;
            int MonthsPerYear = 13;
            float MonthWage1 = WeekWage1 * WeeksPerMonth;
            float MonthWage2 = WeekWage2 * WeeksPerMonth;
            float YearWage1 = MonthWage1 * MonthsPerYear;
            float YearWage2 = MonthWage2 * MonthsPerYear;
            Console.WriteLine("Annual salary of Person 1 is: " + YearWage1);
            Console.WriteLine("Annual salary of Person 2 is: " + YearWage2);
            bool More = YearWage1 > YearWage2;
            Console.WriteLine("Does Person 1 make more money then Person 2?" + More);
            Console.Read();


        }
    }
}
