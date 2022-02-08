using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariabledAndDataTypes.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            // This Section is for the diffrent Data types!!!!!


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // this is a simple program
            //console.writeline("what is youre name?");
            //string yourname = console.readline();
            //console.writeline("your name is: " + yourname);
            //console.readline();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            //bool isStuding = false;
            //byte hoursWorked = 42;
            //SByte currentTemp = -23;
            //char questionMark = '\u2103';

            //decimal moneyInBank = 100.5m;

            //double heightInCentimeters = 211.30202092;

            //float secondsLeft = 2.62F;

            //short tempOnMars = -341;

            //string myName = "Cody";

            //int currantAge = 30;
            //string yeatsOld = currantAge.ToString();

            //bool isRaing = true;
            // string raingingStatus = Convert.ToString(isRaing);

            //Console.WriteLine(raingingStatus);
            // Console.ReadLine();



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // This section is for Math Operations.

            //Addition section
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int comnined = total + otherTotal;


            //Subtraction or diffrence section
            // int difference = 10 - 5;


            //Mulitply section
            //int product = 10 * 5;


            //Division section
            //int quotient = 100 / 17; this will round DOWN ALWAYS!
            // you can put "double" insted of int and make the numbers decimals and it will give you a non rounded number.


            //remanders section
            //int remainder = 10 % 2;even number will return 0 if the 10 was 11 it will return a 1 or odd.

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Comparision section
            //bool TrueOrFalse = 12 > 5; This returns a true
            //bool TrueOrFalse = 12 < 5; This returns a false

            //int roomTemp = 70;
            //int currentTemp = 70;
            //bool isWarm = roomTemp >= currentTemp; This returns a true, comparison symboles <, >, <=, >=, == , !=


            // && this symbol means AND for bool
            // || this symbol means OR for bool
            // ^ this symbol is XOR for Bool

            //Bool section comparisons
            //true && false = false
            //true && true = true
            //false && false = false

            //true || false = true
            //true || true = true
            //false || false = false

            //true == false = flase
            //true == true = true
            //false == false = false

            //true != false = True
            //true != true = False
            //false != false = False

            //true ^ false = true
            //true ^ true = false
            //false ^ false = false

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // If Else section
            //int currentTemp = 70;
            //int rommTemp = 70;

            //if(currentTemp == rommTemp)
            //{
            //    Console.WriteLine("Its exactly room temp!");
            //}
            //ELSE IF CAN GO HERE TOOOOOOOOOO MAKE SURE YOU PUT PERAMS IN THE ()
            //else
            //{
            //    Console.WriteLine("It is not exactly room temp!");
            //}
            //Console.ReadLine();

            //short hand turnary operator
            //string Results = var == var ? "" : "";


            //userimput example
            //int "" = Convert.ToInt32(Console.ReadLine());


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //switch statments

            //int day = 4;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thrsday");
            //        break;

            //        Outputs "Thursday" (day 4)

            // default: is the final switch for everything that wasnting in the switch.
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //While loop

            //while (!"") then put the switch inside the brackets
            //make sure the write lines and variables are inside each case in order to keep the while loop going.
            // put a DO statement before the while loop in order to get it to start the loop at least once


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            // Sting helpful tips

            // \ what follows the backslash is part of the string, this lets "" to be entered in the string for a \ in the string you do a \\
            // \n is for a new line in the same statement
            // \t is for a tab
            // the @ tells the program that everything inside the "" is part of the string

            // string name = "Jesse";
            // bool TorF = name.Contains("s"); True
            // TorF = name.EndsWith("s"): False

            //int length = name.Length; 5
            //.ToUpper() changes it to all upper case
            //.ToLower() changes to all lower case

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Jesse");

            // can use += as a append to a string/

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Arrays and list

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 650;


            //List<int> intlist = new List<int>();
            //intlist.Add(4);
            //intlist.Add(10);
            //intlist.Remove(10);

            // insides the brackets can be changed to any data type



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Itteration section

            // keep the Main(string[] args)

            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++) 
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("");
            //    }
            //}

            //string[] names = { "", "", "", "" };

            //for (int j = object, j < names.Length; j++)
            //{
            //    if (names[j] == "") ;
            //    {
            //        Console.WriteLine("");
            //    }
            //}

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach(int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine(score);
            //    }
            //}

            //List<int> testScores = new List<int>(){ 98, 99, 12, 74, 23, 99};
            //List<int> passingScores = new List<int>;

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //      passingScores.Add(score);
            //    }
            //}
            //
            //  Console.WriteLine(passingScores.Count);


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Exceptions part

            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a  second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();



        }
    }
}
