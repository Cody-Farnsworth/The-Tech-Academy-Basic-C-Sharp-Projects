using System;

namespace PolyAssignment2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee1 = new Employee();
            IQuittable quiter = new Employee();
            employee.Id = 1;
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee1.Id = 1;
            employee1.FirstName = "Samp";
            employee1.LastName = "Stud";
            employee.SayName();
            quiter.Quit();
            Console.WriteLine(employee == employee1);
            Console.ReadLine();
        }
    }
}
