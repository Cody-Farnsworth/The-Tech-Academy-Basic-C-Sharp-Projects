using System;

namespace DoWhileAssignment.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please pick a number from 1 to 10");
            int number = Convert.ToInt32(Console.ReadLine());
            bool myNumber = number == 7;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1 thats the wrong number!");
                        Console.WriteLine("Please pick a number from 1 to 10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2 thats the wrong number!");
                        Console.WriteLine("Please pick a number from 1 to 10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3 thats the wrong number!");
                        Console.WriteLine("Please pick a number from 1 to 10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4 thats the wrong number!");
                        Console.WriteLine("Please pick a number from 1 to 10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5 thats the wrong number!");
                        Console.WriteLine("Please pick a number from 1 to 10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed 6 thats the wrong number!");
                        Console.WriteLine("Please pick a number from 1 to 10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7 thats the right number!");
                        myNumber = true;
                        break;
                    case 8:
                        Console.WriteLine("You guessed 8 thats the wrong number!");
                        Console.WriteLine("Please pick a number from 1 to 10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("You guessed 9 thats the wrong number!");
                        Console.WriteLine("Please pick a number from 1 to 10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20:
                        Console.WriteLine("You guessed 10 thats the wrong number!");
                        Console.WriteLine("Please pick a number from 1 to 10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You guessed a number not between 1 and 10!");
                        Console.WriteLine("Please pick a number from 1 to 10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!myNumber);
            Console.Read();
        }
    }
}
