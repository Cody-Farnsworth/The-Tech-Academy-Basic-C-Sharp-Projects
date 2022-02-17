using System;
namespace EnumsAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the day of the week");
            string answer = Console.ReadLine();
            try
            {
                DaysOfTheWeeks daysOfTheWeeks = (DaysOfTheWeeks)Enum.Parse(typeof(DaysOfTheWeeks), answer);
                Console.WriteLine("you have entered {0}", daysOfTheWeeks);               
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week!");
            }
            Console.ReadLine();
        }
    }
}
