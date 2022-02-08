using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttierationAssignment.cs
{
    class Program
    {
        static void Main()
        {
            //Part 1
            string[] obj = { "The Car is ", "The Book is ", "The House is ", "The Key is ", "The Paper is " };
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i] += color;
            }
            for (int i = 0; i < obj.Length; i++)
            {
                Console.WriteLine(obj[i]);
            }


            //Part 2
            //This makes a infinite loop
            //while (true)
            //{
            //    Console.WriteLine("Hi!");
            //}

            //This fixs the infinate loop
            //bool x = true;
            //while (x)
            //{
            //    Console.WriteLine("hi!");
            //    x = false;
            //}

            //Part 3
            //int temp = 70;
            //int newtemp = 80;
            //while (temp < newtemp)
            //{
            //    Console.WriteLine("The old temp was colder");
            //    temp = 81;
            //}

            //int temp2 = 70;
            //int newtemp2 = 80;
            //while (temp2 <= newtemp2)
            //{
            //    Console.WriteLine("The old temp was colder");
            //    temp2 = 80;
            //}


            //Part 4
            List<string> cardNames = new List<string>() { "Jack", "Queen", "King", "Ace", "Ten", "Nine", "Eight", "Seven", "Six", "Five", "Four", "Two" };
            Console.WriteLine("What is your favorite playing card value?Please, spell it out.");
            string value = Console.ReadLine();
            foreach (string name1 in cardNames)
            {
                if (!cardNames.Contains(value))
                {
                    Console.WriteLine("That is not a valid card name!");
                    break;
                }
                else
                {
                    if (name1 == value)
                    {
                        Console.WriteLine(cardNames.IndexOf(value));
                    }
                }
            }

            //Part 5
            List<string> studentNames = new List<string>() { "Jack", "Jill", "Bob", "Jack", "Cody", "Marry" };
            Console.WriteLine("Please give me a name");
            string value1 = Console.ReadLine();
            for (int i = 0; i < studentNames.Count; i++)
            {
                if (!studentNames.Contains(value1))
                {
                    Console.WriteLine("That is not a name in the list!");
                    break;
                }
                else
                {
                    if (value1 == studentNames[i])
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            //Part 6
            List<string> Names2 = new List<string>() { "Jack", "Jill", "Jill", "Bob", "Tim", "Eirk" };
            List<string> uniqueList = new List<string>() { "" };
            foreach (string name in Names2)
            {
                string message = name;
                bool booool = false;
                foreach (string name2 in uniqueList)
                {
                    if (name == name2)
                    {
                        booool = true;
                    }
                }
                if (booool == true)
                {
                    message += " is a repeat.";
                }
                else
                {
                    uniqueList.Add(name);
                }
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
