using System;

namespace PolyAssignment2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            IQuittable quiter = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            quiter.Quit();
            Console.ReadLine();
        }
    }
}
