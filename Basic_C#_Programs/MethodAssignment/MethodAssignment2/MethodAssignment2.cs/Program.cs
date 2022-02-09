using System;

namespace MethodAssignment2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();
            int number = 10;
            decimal number2 = 6.5m;
            string number3 = "10";            
            Console.WriteLine(math.add(number));
            Console.WriteLine(math.add(number2));
            Console.WriteLine(math.add(number3));
            Console.ReadLine();
        }       
    }
}
