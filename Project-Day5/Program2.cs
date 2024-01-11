using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day5
{
    internal class Program2
    {
        static void Main()
        {
            // Initailize List of Employees

            // Initialize Object

            // Object Initializer

            Employee employee = new Employee()
            { Id = 1, Name = "Ajay", Dob = DateOnly.Parse("12/12/2005"), Manager = "Deepak" };

            //Employee emp2 = new Employee();
            //emp2.Id= 2;
            //emp2.Name = "AAA";
            //emp2.Manager = "aa";
            //emp2.Dob = DateOnly.Parse("12/12/2003");

            // Initialize List
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 2, Name = "aa" });
            employees.Add(new Employee() { Id = 3 });

            // List Initializer

            List<Employee> empsList = new List<Employee>()
            {
                new Employee() { Id = 4,Name="Deepak", Manager="Deepak", Dob=DateOnly.Parse("12/12/2003") },
                new Employee() { Id = 5,Name="Manoj", Manager="Deepak", Dob=DateOnly.Parse("12/12/2003")},
new Employee() { Id = 3,Name="Deepak", Manager="Deepak", Dob=DateOnly.Parse("12/12/2003") },
new Employee() { Id = 2,Name="Deepak", Manager="Deepak", Dob=DateOnly.Parse("12/12/2003") },
new Employee() { Id = 1,Name="Deepak", Manager="Deepak", Dob=DateOnly.Parse("12/12/2003") },
            };



            // Get Record where id = 1

            Employee emp = empsList.Where(x => x.Id == 1).SingleOrDefault();

            if (emp != null)
                Console.WriteLine("found");
            else
                Console.WriteLine("No emp with this id");

            Employee emp1 = empsList.FirstOrDefault(x => x.Name.Contains("Manoj"));
            var list1 = empsList.Where(x=>x.Name.Contains("Deepak")).ToList();
            Console.WriteLine("Count of Total EMployees who have name Deepak is " + list1.Count);



        }
    }
}
