using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                List<int> Numbers = new List<int> { 10, 20, 30, 40, 50 };
                Console.WriteLine("Please give me any number.");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                foreach (int number in Numbers)
                {
                    int total = number / userNumber;
                    Console.WriteLine(total);
                }
            }
            //catch(FormatException ex)
            //{
            //    Console.Write(ex.Message);
            //}
            catch(DivideByZeroException ex)
            {
                Console.Write(ex.Message);               
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                Console.Write("\nThe end");
            }
            
            Console.ReadLine();
        }
    }
}
