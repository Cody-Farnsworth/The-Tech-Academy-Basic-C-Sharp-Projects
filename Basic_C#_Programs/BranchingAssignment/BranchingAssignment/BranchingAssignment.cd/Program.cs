using System;

namespace BranchingAssignment.cd
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            Console.WriteLine("Please enter package weight:");
            int Pweight = Convert.ToInt32(Console.ReadLine());
            if(Pweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day");
                return;
            }
            else
            {
                Console.WriteLine("Please enter package width: ");
            }
            int Pwidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package height: ");
            int Pheight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter pack length: ");
            int Plength = Convert.ToInt32(Console.ReadLine());
            int Pdim = Plength + Pwidth + Pheight;
            int Pdim2 = Plength * Pwidth * Pheight;
            string Pquote = ((Pdim2 * Pweight) / 100m).ToString("C2");
            if(Pdim > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: " + Pquote);
            }
            Console.WriteLine("Thank You!");
            Console.Read();

        }
    }
}


