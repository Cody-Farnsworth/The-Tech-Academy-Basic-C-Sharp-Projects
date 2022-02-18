using System;

namespace DateTimeAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Give me any number!");
            int number = Convert.ToInt32(Console.ReadLine());
            DateTime time = DateTime.Now.AddHours(number);
            Console.WriteLine("It wil be {0} in {1} hours!", time, number);
            Console.Read();
        }
    }
}
