using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            var employees = new List<Employee>();
            employees.Add(new Employee { FirstName = "Joe", LastName = "Paul", Id = 1 });
            employees.Add(new Employee { FirstName = "Joe", LastName = "Paullu", Id = 2 });
            employees.Add(new Employee { FirstName = "Jim", LastName = "Paus", Id = 3 });
            employees.Add(new Employee { FirstName = "Josh", LastName = "Paur", Id = 4 });
            employees.Add(new Employee { FirstName = "Joll", LastName = "Paut", Id = 5 });
            employees.Add(new Employee { FirstName = "Jore", LastName = "Pauy", Id = 6 });
            employees.Add(new Employee { FirstName = "Jake", LastName = "Pauu", Id = 7 });
            employees.Add(new Employee { FirstName = "Jod", LastName = "Paui", Id = 8 });
            employees.Add(new Employee { FirstName = "Jimp", LastName = "Pauo", Id = 9 });
            employees.Add(new Employee { FirstName = "Jass", LastName = "Paup", Id = 10 });
            List<Employee> str = new List<Employee>();
            foreach (Employee employee1 in employees) 
            {
                if (employee1.FirstName == "Joe")
                {
                    str.Add(employee1);                   
                }
            }
            foreach(Employee name in str)
            {
                Console.WriteLine(name.FirstName);
            }
            var list = employees.FindAll(x => x.FirstName == "Joe");
            foreach (var name in list)
            {
                Console.WriteLine(name.FirstName);
            }
            var list1 = employees.FindAll(x => x.Id > 5);
            foreach (var name in list1)
            {
                Console.WriteLine(name.FirstName + "" + name.Id);
            }
        }
    }
}
