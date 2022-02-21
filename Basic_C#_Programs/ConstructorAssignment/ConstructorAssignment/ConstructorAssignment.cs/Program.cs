using System;
using System.Linq;

namespace ConstructorAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Cody";
            Console.WriteLine("{0}. This name is args constant", myName);
            string[] words = { "apple", "strawberry", "grape", "peach", "banana" };
            var wordQuery = from word in words
                            where word[0] == 'g'
                            select word;
            foreach (string s in wordQuery)
            {
                Console.WriteLine(s + " " + "This is using Var");
            }
            var Player = new Player(100, "Cody");
            Console.WriteLine("{0} {1}, This is puting two constructors together", Player.Money, Player.Name);
        }
    }
}
