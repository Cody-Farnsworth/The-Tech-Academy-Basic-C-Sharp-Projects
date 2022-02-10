using System;

namespace ClassAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();
            int initializeInMethod;
            Method(out initializeInMethod);
            Console.WriteLine("Please give me any number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give me another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            math.divid(num1);
            math.divid(num1, num2);
            Console.WriteLine("An example of using an out: {0} ", initializeInMethod);
            Numbers.show();
            Console.WriteLine("The number one is: {0}", Numbers.Number1);
            Console.ReadLine();
        }

        static void Method(out int number)
        {
            number = 44;
        }
    }
}
