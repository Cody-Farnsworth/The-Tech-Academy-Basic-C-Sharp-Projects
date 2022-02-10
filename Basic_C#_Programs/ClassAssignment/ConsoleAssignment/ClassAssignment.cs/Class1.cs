using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment.cs
{

    static class Numbers
    {
        public static int Number1 = 1;

        public static void show()
        {
            Console.WriteLine("This is a class static example: ");
        }
    }


    public class Class1
    {
        public void divid(int num1)
        {
            int sol = num1 / 2;
            Console.WriteLine("Your number divided by 2 is: {0}", sol);
        }
        public void divid(int num1, int num2)
        {
            int sol2 = num1 / num2 / 2;
            Console.WriteLine("Your first number divided by your second number is: {0}", sol2);
        }
    }
}


