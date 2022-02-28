using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalChallengeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Enter the Students First Name: ");
                var firstName = Console.ReadLine();

                Console.WriteLine("Enter the Students Last Name: ");
                var lastName = Console.ReadLine();

                var newStudent = new Student { FirstName = firstName, LastName = lastName };
                db.Students.Add(newStudent);
                db.SaveChanges();

                var query = from b in db.Students
                            orderby b.FirstName
                            select b;

                Console.WriteLine("All Students in the database: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            
            
        }

        public class Student
        {
            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
        }

    }
}
