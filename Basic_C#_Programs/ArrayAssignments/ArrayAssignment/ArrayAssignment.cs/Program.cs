using System;
using System.Collections.Generic;

namespace ArrayAssignment.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please pick a number 0 thru 4: ");
            int choice=Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[5];
            bool arrayGood = false;
            stringArray[0] = "Hey";
            stringArray[1] = "What";
            stringArray[2] = "Is";
            stringArray[3] = "Your";
            stringArray[4] = "Name?";
            do
            {
                switch (choice)
                {
                    case 0:
                        Console.WriteLine(stringArray[0]);
                        arrayGood = true;
                        break;
                    case 1:
                        Console.WriteLine(stringArray[1]);
                        arrayGood = true;
                        break;
                    case 2:
                        Console.WriteLine(stringArray[2]);
                        arrayGood = true;
                        break;
                    case 3:
                        Console.WriteLine(stringArray[3]);
                        arrayGood = true;
                        break;
                    case 4:
                        Console.WriteLine(stringArray[4]);
                        arrayGood = true;
                        break;
                    default:
                        Console.WriteLine("Please choose and number from 0 to 4");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!arrayGood);
            Console.WriteLine("Please pick another number 0 thru 4: ");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[5];
            bool arrayGood2 = false;
            intArray[0] = 10;
            intArray[1] = 14;
            intArray[2] = 28;
            intArray[3] = 33;
            intArray[4] = 44;
            do
            {
                switch (choice2)
                {
                    case 0:
                        Console.WriteLine("you choose: " + intArray[0]);
                        arrayGood2 = true;
                        break;
                    case 1:
                        Console.WriteLine("you choose: " + intArray[1]);
                        arrayGood2 = true;
                        break;
                    case 2:
                        Console.WriteLine("you choose: " + intArray[2]);
                        arrayGood2 = true;
                        break;
                    case 3:
                        Console.WriteLine("you choose: " + intArray[3]);
                        arrayGood2 = true;
                        break;
                    case 4:
                        Console.WriteLine("you choose: " + intArray[4]);
                        arrayGood2 = true;
                        break;
                    default:
                        Console.WriteLine("Please choose and number from 0 to 4");
                        choice2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!arrayGood2);
            Console.WriteLine("Please pick another number 0 thru 4: ");
            int choice3 = Convert.ToInt32(Console.ReadLine());
            List<string> stringList = new List<string>();
            bool arrayGood3 = false;
            stringList.Add("Hi");
            stringList.Add("How");
            stringList.Add("Are");
            stringList.Add("You");
            stringList.Add("Today?");

            do
            {
                switch (choice3)
                {
                    case 0:
                        Console.WriteLine(stringList[0]);
                        arrayGood3 = true;
                        break;
                    case 1:
                        Console.WriteLine(stringList[1]);
                        arrayGood3 = true;
                        break;
                    case 2:
                        Console.WriteLine(stringList[2]);
                        arrayGood3 = true;
                        break;
                    case 3:
                        Console.WriteLine(stringList[3]);
                        arrayGood3 = true;
                        break;
                    case 4:
                        Console.WriteLine(stringList[4]);
                        arrayGood3 = true;
                        break;
                    default:
                        Console.WriteLine("Please choose and number from 0 to 4");
                        choice3 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!arrayGood3);
            Console.Read();
        }
    }
}
