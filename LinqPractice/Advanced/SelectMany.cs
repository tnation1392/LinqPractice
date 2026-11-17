using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice.Advanced
{
    internal class SelectMany
    {
        public static void Run()
        {
            List<Employee> employees = new()
            {
                new Employee
                {
                    Name = "Todd",
                    Department = "QA"
                },
                new Employee
                {
                    Name = "Alex",
                    Department = "QA"
                },
                new Employee
                {
                    Name = "Kim",
                    Department = "Development"
                },
                new Employee
                {
                    Name = "Casey",
                    Department = "Management"
                }
            };

            Console.WriteLine("\nEmployees:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Department: {employee.Department}");
            }
            var employeeNames = employees.SelectMany(e => e.Name);
            Console.WriteLine("\nEmployee Names:");
            foreach (var name in employeeNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
