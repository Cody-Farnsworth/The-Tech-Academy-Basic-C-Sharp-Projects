using System;
using System.Collections.Generic;
using System.Text;

namespace PolyAssignment2.cs
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public void Quit()
        {
            Console.WriteLine("They Quit");
        }
        public static bool operator== (Employee employee, Employee employee1)
        {
            return employee.Id.Equals(employee1.Id);
        }
        public static bool operator!= (Employee employee, Employee employee1)
        {
            return !employee.Id.Equals(employee1.Id);
        }
    }    
}
