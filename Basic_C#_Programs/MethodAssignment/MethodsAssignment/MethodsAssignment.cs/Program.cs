using System;

namespace MethodsAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes math = new Classes();
            Console.WriteLine("Please give me a number!");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(math.add(number));
            Console.WriteLine(math.sub(number));
            Console.WriteLine(math.mult(number));
            Console.ReadLine();
        }
    }
}
