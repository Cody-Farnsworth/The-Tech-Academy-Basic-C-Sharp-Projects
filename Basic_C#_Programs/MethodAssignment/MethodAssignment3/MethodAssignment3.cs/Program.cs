using System;

namespace MethodAssignment3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();
            Console.WriteLine("Please give me a number");
            int NumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You can give me another number if you would like if not leave blanke.");
            string NumberTwo = Console.ReadLine();
            if (NumberTwo == "")
            {
                Console.WriteLine(math.add(NumberOne));
            }
            else
            {
                int Number2 = Convert.ToInt32(NumberTwo);
                Console.Write(math.add(NumberOne, Number2));
            }
            Console.ReadLine();
        }
    }
}
