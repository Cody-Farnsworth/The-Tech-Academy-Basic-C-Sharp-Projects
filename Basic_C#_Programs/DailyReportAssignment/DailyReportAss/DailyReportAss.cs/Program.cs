using System;

namespace DailyReportAss.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What Page Number?");
            string Page = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string TorF = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share?Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you's like to provide?Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHrs = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this Shortly. \nHave a great day!");
            Console.Read();

            // This very simple code will display somne messages for the student to answer. After each answer is given it will store them in each variable name for that answer.
            //Then it will give them a nice goodbye message and end the program.



        }
    }
}
