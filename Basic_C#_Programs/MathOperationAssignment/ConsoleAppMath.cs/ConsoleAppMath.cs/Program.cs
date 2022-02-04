using System;

namespace ConsoleAppMath.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Choose a Number");
            string UserNumS = Console.ReadLine();
            int UserNum = Convert.ToInt32(UserNumS);
            int  TotalM= UserNum * 50;          
            Console.WriteLine(" Your number multiplied by 50 is: " + TotalM);
            Console.WriteLine("Please Choose another Number");
            string UserNumS2 = Console.ReadLine();
            int UserNum2 = Convert.ToInt32(UserNumS2);
            int TotalA = UserNum2 + 25;
            Console.WriteLine(" Your number plus 25 is: " + TotalA);
            Console.WriteLine("Please Choose another Number");
            string UserNumS3 = Console.ReadLine();
            int UserNum3 = Convert.ToInt32(UserNumS3);
            float TotalD = (float)(UserNum3 / 12.5f);
            Console.WriteLine(" Your number divided by 12.5 is: " + TotalD);
            Console.WriteLine("Please Choose another Number");
            string UserNumS4 = Console.ReadLine();
            int UserNum4 = Convert.ToInt32(UserNumS4);
            bool TotalG = UserNum4 > 50;
            Console.WriteLine("Is your number greater then 50? " + TotalG);
            Console.WriteLine("Please Choose a Number");
            string UserNumS5 = Console.ReadLine();
            int UserNum5 = Convert.ToInt32(UserNumS5);
            int TotalL = UserNum5 % 7;
            Console.WriteLine("The remainder of you number divided by 7 is: " + TotalL);

            Console.Read();


        }
    }
}
